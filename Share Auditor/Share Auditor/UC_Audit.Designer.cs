namespace Share_Auditor
{
    partial class UC_Audit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Audit));
            this.label_ErrorMessage = new System.Windows.Forms.Label();
            this.button_StartAudit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_BrowseExportLocation = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_exportLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_BrowseAuditLocation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_auditLocation = new System.Windows.Forms.TextBox();
            this.cb_numLevelsDeep = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_IncludeSystemAccounts = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ErrorMessage
            // 
            this.label_ErrorMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_ErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_ErrorMessage.Location = new System.Drawing.Point(40, 320);
            this.label_ErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ErrorMessage.Name = "label_ErrorMessage";
            this.label_ErrorMessage.Size = new System.Drawing.Size(520, 74);
            this.label_ErrorMessage.TabIndex = 47;
            this.label_ErrorMessage.Text = " Error Message";
            this.label_ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_StartAudit
            // 
            this.button_StartAudit.BackColor = System.Drawing.Color.White;
            this.button_StartAudit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_StartAudit.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.button_StartAudit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_StartAudit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_StartAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_StartAudit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_StartAudit.ForeColor = System.Drawing.Color.CadetBlue;
            this.button_StartAudit.Location = new System.Drawing.Point(599, 327);
            this.button_StartAudit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_StartAudit.Name = "button_StartAudit";
            this.button_StartAudit.Size = new System.Drawing.Size(125, 59);
            this.button_StartAudit.TabIndex = 46;
            this.button_StartAudit.Text = "Start";
            this.button_StartAudit.UseVisualStyleBackColor = false;
            this.button_StartAudit.Click += new System.EventHandler(this.button_StartAudit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(39, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Export Location";
            // 
            // button_BrowseExportLocation
            // 
            this.button_BrowseExportLocation.BackColor = System.Drawing.Color.White;
            this.button_BrowseExportLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_BrowseExportLocation.BackgroundImage")));
            this.button_BrowseExportLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_BrowseExportLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BrowseExportLocation.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.button_BrowseExportLocation.FlatAppearance.BorderSize = 0;
            this.button_BrowseExportLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BrowseExportLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BrowseExportLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_BrowseExportLocation.Location = new System.Drawing.Point(478, 258);
            this.button_BrowseExportLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_BrowseExportLocation.Name = "button_BrowseExportLocation";
            this.button_BrowseExportLocation.Size = new System.Drawing.Size(30, 30);
            this.button_BrowseExportLocation.TabIndex = 44;
            this.button_BrowseExportLocation.UseVisualStyleBackColor = false;
            this.button_BrowseExportLocation.Click += new System.EventHandler(this.button_BrowseExportLocation_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tb_exportLocation);
            this.panel3.Location = new System.Drawing.Point(44, 250);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 40);
            this.panel3.TabIndex = 25;
            // 
            // tb_exportLocation
            // 
            this.tb_exportLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_exportLocation.BackColor = System.Drawing.Color.White;
            this.tb_exportLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_exportLocation.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tb_exportLocation.ForeColor = System.Drawing.Color.SlateGray;
            this.tb_exportLocation.Location = new System.Drawing.Point(4, 7);
            this.tb_exportLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_exportLocation.Name = "tb_exportLocation";
            this.tb_exportLocation.Size = new System.Drawing.Size(412, 24);
            this.tb_exportLocation.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(39, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 42;
            this.label2.Text = "Audit Location";
            // 
            // button_BrowseAuditLocation
            // 
            this.button_BrowseAuditLocation.BackColor = System.Drawing.Color.White;
            this.button_BrowseAuditLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_BrowseAuditLocation.BackgroundImage")));
            this.button_BrowseAuditLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_BrowseAuditLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BrowseAuditLocation.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.button_BrowseAuditLocation.FlatAppearance.BorderSize = 0;
            this.button_BrowseAuditLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BrowseAuditLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BrowseAuditLocation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_BrowseAuditLocation.Location = new System.Drawing.Point(478, 143);
            this.button_BrowseAuditLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_BrowseAuditLocation.Name = "button_BrowseAuditLocation";
            this.button_BrowseAuditLocation.Size = new System.Drawing.Size(30, 30);
            this.button_BrowseAuditLocation.TabIndex = 41;
            this.button_BrowseAuditLocation.UseVisualStyleBackColor = false;
            this.button_BrowseAuditLocation.Click += new System.EventHandler(this.button_BrowseAuditLocation_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_auditLocation);
            this.panel1.Location = new System.Drawing.Point(44, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 40);
            this.panel1.TabIndex = 25;
            // 
            // tb_auditLocation
            // 
            this.tb_auditLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_auditLocation.BackColor = System.Drawing.Color.White;
            this.tb_auditLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_auditLocation.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tb_auditLocation.ForeColor = System.Drawing.Color.SlateGray;
            this.tb_auditLocation.Location = new System.Drawing.Point(4, 7);
            this.tb_auditLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_auditLocation.Name = "tb_auditLocation";
            this.tb_auditLocation.Size = new System.Drawing.Size(412, 24);
            this.tb_auditLocation.TabIndex = 13;
            // 
            // cb_numLevelsDeep
            // 
            this.cb_numLevelsDeep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_numLevelsDeep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_numLevelsDeep.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cb_numLevelsDeep.FormattingEnabled = true;
            this.cb_numLevelsDeep.Location = new System.Drawing.Point(604, 181);
            this.cb_numLevelsDeep.Name = "cb_numLevelsDeep";
            this.cb_numLevelsDeep.Size = new System.Drawing.Size(110, 31);
            this.cb_numLevelsDeep.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(600, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 50;
            this.label3.Text = "Folder Levels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(186, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Where to start the audit?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(186, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "Where to export the results?";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(558, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 46);
            this.label6.TabIndex = 53;
            this.label6.Text = "How many folders deep do you want to audit?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label7.ForeColor = System.Drawing.Color.CadetBlue;
            this.label7.Location = new System.Drawing.Point(580, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 28);
            this.label7.TabIndex = 54;
            this.label7.Text = "System Accounts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Share Auditor";
            // 
            // checkBox_IncludeSystemAccounts
            // 
            this.checkBox_IncludeSystemAccounts.AutoSize = true;
            this.checkBox_IncludeSystemAccounts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBox_IncludeSystemAccounts.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox_IncludeSystemAccounts.Location = new System.Drawing.Point(573, 267);
            this.checkBox_IncludeSystemAccounts.Name = "checkBox_IncludeSystemAccounts";
            this.checkBox_IncludeSystemAccounts.Size = new System.Drawing.Size(180, 23);
            this.checkBox_IncludeSystemAccounts.TabIndex = 57;
            this.checkBox_IncludeSystemAccounts.Text = "Include System Accounts";
            this.checkBox_IncludeSystemAccounts.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 34);
            this.panel2.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(667, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "www.jmcdermott.ie";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(121)))), ((int)(((byte)(122)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(11, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 66);
            this.panel4.TabIndex = 59;
            // 
            // UC_Audit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBox_IncludeSystemAccounts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_numLevelsDeep);
            this.Controls.Add(this.label_ErrorMessage);
            this.Controls.Add(this.button_StartAudit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_BrowseExportLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_BrowseAuditLocation);
            this.MaximumSize = new System.Drawing.Size(801, 434);
            this.MinimumSize = new System.Drawing.Size(801, 434);
            this.Name = "UC_Audit";
            this.Size = new System.Drawing.Size(801, 434);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ErrorMessage;
        private System.Windows.Forms.Button button_StartAudit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_BrowseExportLocation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_exportLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_BrowseAuditLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_auditLocation;
        private System.Windows.Forms.ComboBox cb_numLevelsDeep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_IncludeSystemAccounts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
    }
}
