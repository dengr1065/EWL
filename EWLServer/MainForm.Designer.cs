namespace EWLServer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userName = new System.Windows.Forms.Label();
            this.getInfo = new System.Windows.Forms.Button();
            this.systemVer = new System.Windows.Forms.Label();
            this.connStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.playSound = new System.Windows.Forms.Button();
            this.startProgram = new System.Windows.Forms.Button();
            this.shellCommand = new System.Windows.Forms.Button();
            this.fmFiles = new System.Windows.Forms.ListBox();
            this.create = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.screenPreviewTab = new System.Windows.Forms.TabPage();
            this.enableScreen = new System.Windows.Forms.CheckBox();
            this.screen = new System.Windows.Forms.PictureBox();
            this.fmTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fmReinit = new System.Windows.Forms.Button();
            this.fmUpload = new System.Windows.Forms.Button();
            this.fbTab = new System.Windows.Forms.TabPage();
            this.fbProgress = new System.Windows.Forms.ProgressBar();
            this.fbList = new System.Windows.Forms.ListBox();
            this.fbDownload = new System.Windows.Forms.Button();
            this.fbUpload = new System.Windows.Forms.Button();
            this.fbUp = new System.Windows.Forms.Button();
            this.fbPath = new System.Windows.Forms.TextBox();
            this.fbDrives = new System.Windows.Forms.ComboBox();
            this.fbReload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.screenPreviewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.fmTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.fbTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // listen
            // 
            this.listen.AutoEllipsis = true;
            this.listen.Location = new System.Drawing.Point(15, 12);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(156, 24);
            this.listen.TabIndex = 2;
            this.listen.Text = "Увімк. сервер";
            this.listen.UseVisualStyleBackColor = true;
            this.listen.Click += new System.EventHandler(this.Listen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.getInfo);
            this.groupBox1.Controls.Add(this.systemVer);
            this.groupBox1.Controls.Add(this.connStatus);
            this.groupBox1.Location = new System.Drawing.Point(15, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 133);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інформація";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(6, 48);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(82, 15);
            this.userName.TabIndex = 3;
            this.userName.Text = "Користувач: -";
            // 
            // getInfo
            // 
            this.getInfo.Location = new System.Drawing.Point(9, 104);
            this.getInfo.Name = "getInfo";
            this.getInfo.Size = new System.Drawing.Size(75, 23);
            this.getInfo.TabIndex = 2;
            this.getInfo.Text = "Отримати";
            this.getInfo.UseVisualStyleBackColor = true;
            this.getInfo.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // systemVer
            // 
            this.systemVer.AutoSize = true;
            this.systemVer.Location = new System.Drawing.Point(6, 32);
            this.systemVer.Name = "systemVer";
            this.systemVer.Size = new System.Drawing.Size(65, 15);
            this.systemVer.TabIndex = 1;
            this.systemVer.Text = "Система: -";
            // 
            // connStatus
            // 
            this.connStatus.AutoSize = true;
            this.connStatus.Location = new System.Drawing.Point(6, 16);
            this.connStatus.Name = "connStatus";
            this.connStatus.Size = new System.Drawing.Size(132, 15);
            this.connStatus.TabIndex = 0;
            this.connStatus.Text = "Підключення: відсутнє";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.playSound);
            this.groupBox2.Controls.Add(this.startProgram);
            this.groupBox2.Controls.Add(this.shellCommand);
            this.groupBox2.Location = new System.Drawing.Point(15, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox2.Size = new System.Drawing.Size(335, 198);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дії";
            // 
            // playSound
            // 
            this.playSound.Location = new System.Drawing.Point(9, 53);
            this.playSound.Name = "playSound";
            this.playSound.Size = new System.Drawing.Size(150, 28);
            this.playSound.TabIndex = 2;
            this.playSound.Text = "Програти аудіофайл...";
            this.playSound.UseVisualStyleBackColor = true;
            this.playSound.Click += new System.EventHandler(this.PlaySound_Click);
            // 
            // startProgram
            // 
            this.startProgram.Location = new System.Drawing.Point(176, 19);
            this.startProgram.Name = "startProgram";
            this.startProgram.Size = new System.Drawing.Size(150, 28);
            this.startProgram.TabIndex = 1;
            this.startProgram.Text = "Запустити програму...";
            this.startProgram.UseVisualStyleBackColor = true;
            this.startProgram.Click += new System.EventHandler(this.StartProgram_Click);
            // 
            // shellCommand
            // 
            this.shellCommand.Location = new System.Drawing.Point(9, 19);
            this.shellCommand.Name = "shellCommand";
            this.shellCommand.Size = new System.Drawing.Size(150, 28);
            this.shellCommand.TabIndex = 0;
            this.shellCommand.Text = "Команда консолі...";
            this.shellCommand.UseVisualStyleBackColor = true;
            this.shellCommand.Click += new System.EventHandler(this.ShellCommand_Click);
            // 
            // fmFiles
            // 
            this.fmFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmFiles.FormattingEnabled = true;
            this.fmFiles.IntegralHeight = false;
            this.fmFiles.ItemHeight = 15;
            this.fmFiles.Location = new System.Drawing.Point(3, 3);
            this.fmFiles.Name = "fmFiles";
            this.fmFiles.Size = new System.Drawing.Size(376, 300);
            this.fmFiles.TabIndex = 0;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(194, 12);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(156, 24);
            this.create.TabIndex = 10;
            this.create.Text = "Створити";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.Create_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.screenPreviewTab);
            this.tabControl.Controls.Add(this.fmTab);
            this.tabControl.Controls.Add(this.fbTab);
            this.tabControl.Location = new System.Drawing.Point(362, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(390, 367);
            this.tabControl.TabIndex = 11;
            // 
            // screenPreviewTab
            // 
            this.screenPreviewTab.Controls.Add(this.enableScreen);
            this.screenPreviewTab.Controls.Add(this.screen);
            this.screenPreviewTab.Location = new System.Drawing.Point(4, 24);
            this.screenPreviewTab.Name = "screenPreviewTab";
            this.screenPreviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.screenPreviewTab.Size = new System.Drawing.Size(382, 339);
            this.screenPreviewTab.TabIndex = 0;
            this.screenPreviewTab.Text = "Перегляд екрану";
            this.screenPreviewTab.UseVisualStyleBackColor = true;
            // 
            // enableScreen
            // 
            this.enableScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enableScreen.AutoSize = true;
            this.enableScreen.Location = new System.Drawing.Point(361, 6);
            this.enableScreen.Name = "enableScreen";
            this.enableScreen.Size = new System.Drawing.Size(15, 14);
            this.enableScreen.TabIndex = 10;
            this.enableScreen.UseVisualStyleBackColor = true;
            this.enableScreen.CheckedChanged += new System.EventHandler(this.EnableScreen_CheckedChanged);
            // 
            // screen
            // 
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(3, 3);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(376, 333);
            this.screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.screen.TabIndex = 9;
            this.screen.TabStop = false;
            // 
            // fmTab
            // 
            this.fmTab.Controls.Add(this.fmFiles);
            this.fmTab.Controls.Add(this.panel1);
            this.fmTab.Location = new System.Drawing.Point(4, 22);
            this.fmTab.Name = "fmTab";
            this.fmTab.Padding = new System.Windows.Forms.Padding(3);
            this.fmTab.Size = new System.Drawing.Size(382, 341);
            this.fmTab.TabIndex = 1;
            this.fmTab.Text = "Файли EWL";
            this.fmTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fmReinit);
            this.panel1.Controls.Add(this.fmUpload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 35);
            this.panel1.TabIndex = 4;
            // 
            // fmReinit
            // 
            this.fmReinit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fmReinit.Location = new System.Drawing.Point(311, 4);
            this.fmReinit.Name = "fmReinit";
            this.fmReinit.Size = new System.Drawing.Size(28, 28);
            this.fmReinit.TabIndex = 2;
            this.fmReinit.UseVisualStyleBackColor = true;
            // 
            // fmUpload
            // 
            this.fmUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fmUpload.Location = new System.Drawing.Point(345, 4);
            this.fmUpload.Name = "fmUpload";
            this.fmUpload.Size = new System.Drawing.Size(28, 28);
            this.fmUpload.TabIndex = 3;
            this.fmUpload.UseVisualStyleBackColor = true;
            // 
            // fbTab
            // 
            this.fbTab.Controls.Add(this.fbProgress);
            this.fbTab.Controls.Add(this.fbList);
            this.fbTab.Controls.Add(this.fbDownload);
            this.fbTab.Controls.Add(this.fbUpload);
            this.fbTab.Controls.Add(this.fbUp);
            this.fbTab.Controls.Add(this.fbPath);
            this.fbTab.Controls.Add(this.fbDrives);
            this.fbTab.Controls.Add(this.fbReload);
            this.fbTab.Location = new System.Drawing.Point(4, 24);
            this.fbTab.Name = "fbTab";
            this.fbTab.Size = new System.Drawing.Size(382, 339);
            this.fbTab.TabIndex = 2;
            this.fbTab.Text = "Файли";
            this.fbTab.UseVisualStyleBackColor = true;
            // 
            // fbProgress
            // 
            this.fbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbProgress.Enabled = false;
            this.fbProgress.Location = new System.Drawing.Point(3, 314);
            this.fbProgress.MarqueeAnimationSpeed = 20;
            this.fbProgress.Name = "fbProgress";
            this.fbProgress.Size = new System.Drawing.Size(376, 16);
            this.fbProgress.TabIndex = 7;
            // 
            // fbList
            // 
            this.fbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbList.FormattingEnabled = true;
            this.fbList.IntegralHeight = false;
            this.fbList.ItemHeight = 15;
            this.fbList.Location = new System.Drawing.Point(3, 68);
            this.fbList.Name = "fbList";
            this.fbList.Size = new System.Drawing.Size(376, 240);
            this.fbList.TabIndex = 6;
            this.fbList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FbList_MouseDoubleClick);
            // 
            // fbDownload
            // 
            this.fbDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fbDownload.Image = ((System.Drawing.Image)(resources.GetObject("fbDownload.Image")));
            this.fbDownload.Location = new System.Drawing.Point(283, 35);
            this.fbDownload.Name = "fbDownload";
            this.fbDownload.Size = new System.Drawing.Size(28, 28);
            this.fbDownload.TabIndex = 5;
            this.fbDownload.UseVisualStyleBackColor = true;
            this.fbDownload.Click += new System.EventHandler(this.FbDownload_Click);
            // 
            // fbUpload
            // 
            this.fbUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fbUpload.Image = ((System.Drawing.Image)(resources.GetObject("fbUpload.Image")));
            this.fbUpload.Location = new System.Drawing.Point(317, 35);
            this.fbUpload.Name = "fbUpload";
            this.fbUpload.Size = new System.Drawing.Size(28, 28);
            this.fbUpload.TabIndex = 4;
            this.fbUpload.UseVisualStyleBackColor = true;
            this.fbUpload.Click += new System.EventHandler(this.FbUpload_Click);
            // 
            // fbUp
            // 
            this.fbUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fbUp.Location = new System.Drawing.Point(351, 35);
            this.fbUp.Name = "fbUp";
            this.fbUp.Size = new System.Drawing.Size(28, 28);
            this.fbUp.TabIndex = 3;
            this.fbUp.Text = "..";
            this.fbUp.UseVisualStyleBackColor = true;
            this.fbUp.Click += new System.EventHandler(this.FbUp_Click);
            // 
            // fbPath
            // 
            this.fbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbPath.Location = new System.Drawing.Point(3, 39);
            this.fbPath.Name = "fbPath";
            this.fbPath.ReadOnly = true;
            this.fbPath.Size = new System.Drawing.Size(274, 23);
            this.fbPath.TabIndex = 2;
            // 
            // fbDrives
            // 
            this.fbDrives.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fbDrives.FormattingEnabled = true;
            this.fbDrives.Location = new System.Drawing.Point(37, 6);
            this.fbDrives.Name = "fbDrives";
            this.fbDrives.Size = new System.Drawing.Size(342, 23);
            this.fbDrives.TabIndex = 1;
            this.fbDrives.SelectedIndexChanged += new System.EventHandler(this.FbDrives_SelectedIndexChanged);
            // 
            // fbReload
            // 
            this.fbReload.Image = ((System.Drawing.Image)(resources.GetObject("fbReload.Image")));
            this.fbReload.Location = new System.Drawing.Point(3, 3);
            this.fbReload.Name = "fbReload";
            this.fbReload.Size = new System.Drawing.Size(28, 28);
            this.fbReload.TabIndex = 0;
            this.fbReload.UseVisualStyleBackColor = true;
            this.fbReload.Click += new System.EventHandler(this.FbReload_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 391);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.create);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listen);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(780, 430);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EWL Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.screenPreviewTab.ResumeLayout(false);
            this.screenPreviewTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.fmTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.fbTab.ResumeLayout(false);
            this.fbTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label connStatus;
        private System.Windows.Forms.Label systemVer;
        private System.Windows.Forms.Button getInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button shellCommand;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button startProgram;
        private System.Windows.Forms.Button playSound;
        private System.Windows.Forms.ListBox fmFiles;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage screenPreviewTab;
        private System.Windows.Forms.CheckBox enableScreen;
        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.TabPage fmTab;
        private System.Windows.Forms.Button fmUpload;
        private System.Windows.Forms.Button fmReinit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage fbTab;
        private System.Windows.Forms.ListBox fbList;
        private System.Windows.Forms.Button fbDownload;
        private System.Windows.Forms.Button fbUpload;
        private System.Windows.Forms.Button fbUp;
        private System.Windows.Forms.TextBox fbPath;
        private System.Windows.Forms.ComboBox fbDrives;
        private System.Windows.Forms.Button fbReload;
        private System.Windows.Forms.ProgressBar fbProgress;
    }
}

