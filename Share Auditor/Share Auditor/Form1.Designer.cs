namespace Share_Auditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog_AuditLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_ExportLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_UCContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_UCContainer
            // 
            this.panel_UCContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_UCContainer.Location = new System.Drawing.Point(0, -2);
            this.panel_UCContainer.Name = "panel_UCContainer";
            this.panel_UCContainer.Size = new System.Drawing.Size(801, 434);
            this.panel_UCContainer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 432);
            this.Controls.Add(this.panel_UCContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(817, 471);
            this.MinimumSize = new System.Drawing.Size(817, 471);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Share Auditor v0.02";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_AuditLocation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_ExportLocation;
        private System.Windows.Forms.Panel panel_UCContainer;
    }
}

