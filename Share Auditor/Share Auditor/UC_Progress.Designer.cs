namespace Share_Auditor
{
    partial class UC_Progress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Progress));
            this.pictureBox_LoadingIcon = new System.Windows.Forms.PictureBox();
            this.label_OverviewStatus = new System.Windows.Forms.Label();
            this.label_ProgressText = new System.Windows.Forms.Label();
            this.button_FinishAudit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LoadingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_LoadingIcon
            // 
            this.pictureBox_LoadingIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LoadingIcon.Image")));
            this.pictureBox_LoadingIcon.Location = new System.Drawing.Point(305, 98);
            this.pictureBox_LoadingIcon.Name = "pictureBox_LoadingIcon";
            this.pictureBox_LoadingIcon.Size = new System.Drawing.Size(200, 190);
            this.pictureBox_LoadingIcon.TabIndex = 0;
            this.pictureBox_LoadingIcon.TabStop = false;
            // 
            // label_OverviewStatus
            // 
            this.label_OverviewStatus.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label_OverviewStatus.ForeColor = System.Drawing.Color.CadetBlue;
            this.label_OverviewStatus.Location = new System.Drawing.Point(0, 35);
            this.label_OverviewStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_OverviewStatus.Name = "label_OverviewStatus";
            this.label_OverviewStatus.Size = new System.Drawing.Size(801, 41);
            this.label_OverviewStatus.TabIndex = 43;
            this.label_OverviewStatus.Text = "Auditing. Please wait...";
            this.label_OverviewStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ProgressText
            // 
            this.label_ProgressText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label_ProgressText.ForeColor = System.Drawing.Color.Gray;
            this.label_ProgressText.Location = new System.Drawing.Point(0, 310);
            this.label_ProgressText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ProgressText.Name = "label_ProgressText";
            this.label_ProgressText.Size = new System.Drawing.Size(801, 62);
            this.label_ProgressText.TabIndex = 44;
            this.label_ProgressText.Text = "Auditing. Please wait...";
            this.label_ProgressText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_FinishAudit
            // 
            this.button_FinishAudit.BackColor = System.Drawing.Color.White;
            this.button_FinishAudit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_FinishAudit.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.button_FinishAudit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_FinishAudit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_FinishAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FinishAudit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FinishAudit.ForeColor = System.Drawing.Color.CadetBlue;
            this.button_FinishAudit.Location = new System.Drawing.Point(335, 162);
            this.button_FinishAudit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_FinishAudit.Name = "button_FinishAudit";
            this.button_FinishAudit.Size = new System.Drawing.Size(125, 59);
            this.button_FinishAudit.TabIndex = 47;
            this.button_FinishAudit.Text = "Finish";
            this.button_FinishAudit.UseVisualStyleBackColor = false;
            this.button_FinishAudit.Click += new System.EventHandler(this.button_FinishAudit_Click);
            // 
            // UC_Progress
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox_LoadingIcon);
            this.Controls.Add(this.button_FinishAudit);
            this.Controls.Add(this.label_ProgressText);
            this.Controls.Add(this.label_OverviewStatus);
            this.Name = "UC_Progress";
            this.Size = new System.Drawing.Size(801, 434);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LoadingIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_LoadingIcon;
        private System.Windows.Forms.Label label_OverviewStatus;
        public System.Windows.Forms.Label label_ProgressText;
        private System.Windows.Forms.Button button_FinishAudit;
    }
}
