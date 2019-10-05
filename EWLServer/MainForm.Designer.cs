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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.screen = new System.Windows.Forms.PictureBox();
            this.enableScreen = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fmUpload = new System.Windows.Forms.Button();
            this.fmReinit = new System.Windows.Forms.Button();
            this.fmFiles = new System.Windows.Forms.ListBox();
            this.create = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.groupBox2.Size = new System.Drawing.Size(335, 198);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дії";
            // 
            // playSound
            // 
            this.playSound.Location = new System.Drawing.Point(6, 53);
            this.playSound.Name = "playSound";
            this.playSound.Size = new System.Drawing.Size(150, 28);
            this.playSound.TabIndex = 2;
            this.playSound.Text = "Програти аудіофайл...";
            this.playSound.UseVisualStyleBackColor = true;
            this.playSound.Click += new System.EventHandler(this.PlaySound_Click);
            // 
            // startProgram
            // 
            this.startProgram.Location = new System.Drawing.Point(179, 19);
            this.startProgram.Name = "startProgram";
            this.startProgram.Size = new System.Drawing.Size(150, 28);
            this.startProgram.TabIndex = 1;
            this.startProgram.Text = "Запустити програму...";
            this.startProgram.UseVisualStyleBackColor = true;
            this.startProgram.Click += new System.EventHandler(this.StartProgram_Click);
            // 
            // shellCommand
            // 
            this.shellCommand.Location = new System.Drawing.Point(6, 19);
            this.shellCommand.Name = "shellCommand";
            this.shellCommand.Size = new System.Drawing.Size(150, 28);
            this.shellCommand.TabIndex = 0;
            this.shellCommand.Text = "Команда консолі...";
            this.shellCommand.UseVisualStyleBackColor = true;
            this.shellCommand.Click += new System.EventHandler(this.ShellCommand_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.screen);
            this.groupBox3.Controls.Add(this.enableScreen);
            this.groupBox3.Location = new System.Drawing.Point(356, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 225);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перегляд екрану";
            // 
            // screen
            // 
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(3, 19);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(390, 203);
            this.screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.screen.TabIndex = 1;
            this.screen.TabStop = false;
            // 
            // enableScreen
            // 
            this.enableScreen.AutoSize = true;
            this.enableScreen.Location = new System.Drawing.Point(105, 2);
            this.enableScreen.Name = "enableScreen";
            this.enableScreen.Size = new System.Drawing.Size(15, 14);
            this.enableScreen.TabIndex = 0;
            this.enableScreen.UseVisualStyleBackColor = true;
            this.enableScreen.CheckedChanged += new System.EventHandler(this.EnableScreen_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.fmUpload);
            this.groupBox4.Controls.Add(this.fmReinit);
            this.groupBox4.Controls.Add(this.fmFiles);
            this.groupBox4.Location = new System.Drawing.Point(356, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 138);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Файли";
            // 
            // fmUpload
            // 
            this.fmUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fmUpload.Location = new System.Drawing.Point(362, 53);
            this.fmUpload.Name = "fmUpload";
            this.fmUpload.Size = new System.Drawing.Size(28, 28);
            this.fmUpload.TabIndex = 2;
            this.fmUpload.UseVisualStyleBackColor = true;
            this.fmUpload.Click += new System.EventHandler(this.FmUpload_Click);
            // 
            // fmReinit
            // 
            this.fmReinit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fmReinit.Location = new System.Drawing.Point(362, 19);
            this.fmReinit.Name = "fmReinit";
            this.fmReinit.Size = new System.Drawing.Size(28, 28);
            this.fmReinit.TabIndex = 1;
            this.fmReinit.UseVisualStyleBackColor = true;
            this.fmReinit.Click += new System.EventHandler(this.FmReinit_Click);
            // 
            // fmFiles
            // 
            this.fmFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fmFiles.FormattingEnabled = true;
            this.fmFiles.ItemHeight = 15;
            this.fmFiles.Location = new System.Drawing.Point(6, 19);
            this.fmFiles.Name = "fmFiles";
            this.fmFiles.Size = new System.Drawing.Size(350, 94);
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 391);
            this.Controls.Add(this.create);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox enableScreen;
        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.Button startProgram;
        private System.Windows.Forms.Button playSound;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button fmReinit;
        private System.Windows.Forms.ListBox fmFiles;
        private System.Windows.Forms.Button fmUpload;
        private System.Windows.Forms.Button create;
    }
}

