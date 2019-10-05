namespace EWLServer
{
    partial class BuilderForm
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
            this.lIP = new System.Windows.Forms.Label();
            this.ipOct0 = new System.Windows.Forms.NumericUpDown();
            this.lOctSep0 = new System.Windows.Forms.Label();
            this.ipOct1 = new System.Windows.Forms.NumericUpDown();
            this.ipOct2 = new System.Windows.Forms.NumericUpDown();
            this.lOctSep1 = new System.Windows.Forms.Label();
            this.lOctSep2 = new System.Windows.Forms.Label();
            this.ipOct3 = new System.Windows.Forms.NumericUpDown();
            this.selectStub = new System.Windows.Forms.Button();
            this.stubPanel = new System.Windows.Forms.Panel();
            this.gMsg = new System.Windows.Forms.GroupBox();
            this.lMessage = new System.Windows.Forms.Label();
            this.stubLoc = new System.Windows.Forms.TextBox();
            this.lStubLoc = new System.Windows.Forms.Label();
            this.build = new System.Windows.Forms.Button();
            this.lPacket = new System.Windows.Forms.Label();
            this.bindPanel = new System.Windows.Forms.Panel();
            this.enableBinding = new System.Windows.Forms.CheckBox();
            this.lBindStub = new System.Windows.Forms.Label();
            this.bindStub = new System.Windows.Forms.TextBox();
            this.selectBindStub = new System.Windows.Forms.Button();
            this.selectBindFile = new System.Windows.Forms.Button();
            this.bindFile = new System.Windows.Forms.TextBox();
            this.lBindFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ipOct0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOct3)).BeginInit();
            this.stubPanel.SuspendLayout();
            this.gMsg.SuspendLayout();
            this.bindPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lIP
            // 
            this.lIP.AutoSize = true;
            this.lIP.Location = new System.Drawing.Point(12, 15);
            this.lIP.Name = "lIP";
            this.lIP.Size = new System.Drawing.Size(112, 15);
            this.lIP.TabIndex = 0;
            this.lIP.Text = "Вкажіть IP сервера:";
            // 
            // ipOct0
            // 
            this.ipOct0.Location = new System.Drawing.Point(235, 12);
            this.ipOct0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOct0.Name = "ipOct0";
            this.ipOct0.Size = new System.Drawing.Size(48, 23);
            this.ipOct0.TabIndex = 1;
            // 
            // lOctSep0
            // 
            this.lOctSep0.AutoSize = true;
            this.lOctSep0.Location = new System.Drawing.Point(289, 14);
            this.lOctSep0.Name = "lOctSep0";
            this.lOctSep0.Size = new System.Drawing.Size(10, 15);
            this.lOctSep0.TabIndex = 2;
            this.lOctSep0.Text = ".";
            // 
            // ipOct1
            // 
            this.ipOct1.Location = new System.Drawing.Point(305, 12);
            this.ipOct1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOct1.Name = "ipOct1";
            this.ipOct1.Size = new System.Drawing.Size(48, 23);
            this.ipOct1.TabIndex = 3;
            // 
            // ipOct2
            // 
            this.ipOct2.Location = new System.Drawing.Point(375, 12);
            this.ipOct2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOct2.Name = "ipOct2";
            this.ipOct2.Size = new System.Drawing.Size(48, 23);
            this.ipOct2.TabIndex = 4;
            // 
            // lOctSep1
            // 
            this.lOctSep1.AutoSize = true;
            this.lOctSep1.Location = new System.Drawing.Point(359, 14);
            this.lOctSep1.Name = "lOctSep1";
            this.lOctSep1.Size = new System.Drawing.Size(10, 15);
            this.lOctSep1.TabIndex = 5;
            this.lOctSep1.Text = ".";
            // 
            // lOctSep2
            // 
            this.lOctSep2.AutoSize = true;
            this.lOctSep2.Location = new System.Drawing.Point(429, 14);
            this.lOctSep2.Name = "lOctSep2";
            this.lOctSep2.Size = new System.Drawing.Size(10, 15);
            this.lOctSep2.TabIndex = 6;
            this.lOctSep2.Text = ".";
            // 
            // ipOct3
            // 
            this.ipOct3.Location = new System.Drawing.Point(445, 12);
            this.ipOct3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOct3.Name = "ipOct3";
            this.ipOct3.Size = new System.Drawing.Size(48, 23);
            this.ipOct3.TabIndex = 7;
            // 
            // selectStub
            // 
            this.selectStub.Location = new System.Drawing.Point(393, 11);
            this.selectStub.Name = "selectStub";
            this.selectStub.Size = new System.Drawing.Size(75, 23);
            this.selectStub.TabIndex = 8;
            this.selectStub.Text = "Обрати...";
            this.selectStub.UseVisualStyleBackColor = true;
            // 
            // stubPanel
            // 
            this.stubPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stubPanel.Controls.Add(this.gMsg);
            this.stubPanel.Controls.Add(this.stubLoc);
            this.stubPanel.Controls.Add(this.lStubLoc);
            this.stubPanel.Controls.Add(this.selectStub);
            this.stubPanel.Location = new System.Drawing.Point(12, 41);
            this.stubPanel.Name = "stubPanel";
            this.stubPanel.Padding = new System.Windows.Forms.Padding(8);
            this.stubPanel.Size = new System.Drawing.Size(481, 135);
            this.stubPanel.TabIndex = 9;
            // 
            // gMsg
            // 
            this.gMsg.Controls.Add(this.lMessage);
            this.gMsg.Location = new System.Drawing.Point(11, 41);
            this.gMsg.Name = "gMsg";
            this.gMsg.Size = new System.Drawing.Size(457, 81);
            this.gMsg.TabIndex = 11;
            this.gMsg.TabStop = false;
            this.gMsg.Text = "Повідомлення";
            // 
            // lMessage
            // 
            this.lMessage.Location = new System.Drawing.Point(6, 19);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(445, 59);
            this.lMessage.TabIndex = 0;
            // 
            // stubLoc
            // 
            this.stubLoc.Location = new System.Drawing.Point(194, 11);
            this.stubLoc.Name = "stubLoc";
            this.stubLoc.Size = new System.Drawing.Size(193, 23);
            this.stubLoc.TabIndex = 10;
            // 
            // lStubLoc
            // 
            this.lStubLoc.AutoSize = true;
            this.lStubLoc.Location = new System.Drawing.Point(11, 15);
            this.lStubLoc.Name = "lStubLoc";
            this.lStubLoc.Size = new System.Drawing.Size(177, 15);
            this.lStubLoc.TabIndex = 9;
            this.lStubLoc.Text = "Сумісний клієнт EWL (EWL 3+):";
            // 
            // build
            // 
            this.build.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.build.Enabled = false;
            this.build.Location = new System.Drawing.Point(397, 289);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(96, 28);
            this.build.TabIndex = 10;
            this.build.Text = "Створити";
            this.build.UseVisualStyleBackColor = true;
            // 
            // lPacket
            // 
            this.lPacket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lPacket.AutoSize = true;
            this.lPacket.Location = new System.Drawing.Point(12, 296);
            this.lPacket.Name = "lPacket";
            this.lPacket.Size = new System.Drawing.Size(117, 15);
            this.lPacket.TabIndex = 11;
            this.lPacket.Text = "Пакет: 000000004950";
            // 
            // bindPanel
            // 
            this.bindPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bindPanel.Controls.Add(this.selectBindFile);
            this.bindPanel.Controls.Add(this.bindFile);
            this.bindPanel.Controls.Add(this.lBindFile);
            this.bindPanel.Controls.Add(this.selectBindStub);
            this.bindPanel.Controls.Add(this.bindStub);
            this.bindPanel.Controls.Add(this.lBindStub);
            this.bindPanel.Enabled = false;
            this.bindPanel.Location = new System.Drawing.Point(12, 207);
            this.bindPanel.Name = "bindPanel";
            this.bindPanel.Padding = new System.Windows.Forms.Padding(8);
            this.bindPanel.Size = new System.Drawing.Size(481, 76);
            this.bindPanel.TabIndex = 12;
            // 
            // enableBinding
            // 
            this.enableBinding.AutoSize = true;
            this.enableBinding.Location = new System.Drawing.Point(15, 182);
            this.enableBinding.Name = "enableBinding";
            this.enableBinding.Size = new System.Drawing.Size(243, 19);
            this.enableBinding.TabIndex = 0;
            this.enableBinding.Text = "RBind (Привязування до іншого файлу)";
            this.enableBinding.UseVisualStyleBackColor = true;
            // 
            // lBindStub
            // 
            this.lBindStub.AutoSize = true;
            this.lBindStub.Location = new System.Drawing.Point(11, 14);
            this.lBindStub.Name = "lBindStub";
            this.lBindStub.Size = new System.Drawing.Size(187, 15);
            this.lBindStub.TabIndex = 10;
            this.lBindStub.Text = "Завантажувач RBind (RBindStub):";
            // 
            // bindStub
            // 
            this.bindStub.Location = new System.Drawing.Point(204, 11);
            this.bindStub.Name = "bindStub";
            this.bindStub.Size = new System.Drawing.Size(183, 23);
            this.bindStub.TabIndex = 11;
            // 
            // selectBindStub
            // 
            this.selectBindStub.Location = new System.Drawing.Point(393, 11);
            this.selectBindStub.Name = "selectBindStub";
            this.selectBindStub.Size = new System.Drawing.Size(75, 23);
            this.selectBindStub.TabIndex = 12;
            this.selectBindStub.Text = "Обрати...";
            this.selectBindStub.UseVisualStyleBackColor = true;
            // 
            // selectBindFile
            // 
            this.selectBindFile.Location = new System.Drawing.Point(393, 40);
            this.selectBindFile.Name = "selectBindFile";
            this.selectBindFile.Size = new System.Drawing.Size(75, 23);
            this.selectBindFile.TabIndex = 15;
            this.selectBindFile.Text = "Обрати...";
            this.selectBindFile.UseVisualStyleBackColor = true;
            // 
            // bindFile
            // 
            this.bindFile.Location = new System.Drawing.Point(135, 40);
            this.bindFile.Name = "bindFile";
            this.bindFile.Size = new System.Drawing.Size(252, 23);
            this.bindFile.TabIndex = 14;
            // 
            // lBindFile
            // 
            this.lBindFile.AutoSize = true;
            this.lBindFile.Location = new System.Drawing.Point(11, 43);
            this.lBindFile.Name = "lBindFile";
            this.lBindFile.Size = new System.Drawing.Size(118, 15);
            this.lBindFile.TabIndex = 13;
            this.lBindFile.Text = "Файл для прив\'язки:";
            // 
            // BuilderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 329);
            this.Controls.Add(this.bindPanel);
            this.Controls.Add(this.enableBinding);
            this.Controls.Add(this.lPacket);
            this.Controls.Add(this.build);
            this.Controls.Add(this.stubPanel);
            this.Controls.Add(this.ipOct3);
            this.Controls.Add(this.lOctSep2);
            this.Controls.Add(this.lOctSep1);
            this.Controls.Add(this.ipOct2);
            this.Controls.Add(this.ipOct1);
            this.Controls.Add(this.lOctSep0);
            this.Controls.Add(this.ipOct0);
            this.Controls.Add(this.lIP);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuilderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Створити...";
            ((System.ComponentModel.ISupportInitialize)(this.ipOct0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOct3)).EndInit();
            this.stubPanel.ResumeLayout(false);
            this.stubPanel.PerformLayout();
            this.gMsg.ResumeLayout(false);
            this.bindPanel.ResumeLayout(false);
            this.bindPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lIP;
        private System.Windows.Forms.NumericUpDown ipOct0;
        private System.Windows.Forms.Label lOctSep0;
        private System.Windows.Forms.NumericUpDown ipOct1;
        private System.Windows.Forms.NumericUpDown ipOct2;
        private System.Windows.Forms.Label lOctSep1;
        private System.Windows.Forms.Label lOctSep2;
        private System.Windows.Forms.NumericUpDown ipOct3;
        private System.Windows.Forms.Button selectStub;
        private System.Windows.Forms.Panel stubPanel;
        private System.Windows.Forms.Label lStubLoc;
        private System.Windows.Forms.GroupBox gMsg;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.TextBox stubLoc;
        private System.Windows.Forms.Button build;
        private System.Windows.Forms.Label lPacket;
        private System.Windows.Forms.Panel bindPanel;
        private System.Windows.Forms.CheckBox enableBinding;
        private System.Windows.Forms.Button selectBindFile;
        private System.Windows.Forms.TextBox bindFile;
        private System.Windows.Forms.Label lBindFile;
        private System.Windows.Forms.Button selectBindStub;
        private System.Windows.Forms.TextBox bindStub;
        private System.Windows.Forms.Label lBindStub;
    }
}