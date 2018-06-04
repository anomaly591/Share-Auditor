using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Share_Auditor
{
    public partial class UC_Progress : UserControl
    {
        private Form1 form1;

        public UC_Progress(Form1 f)
        {
            form1 = f;
            InitializeComponent();
            label_ProgressText.Text = "";
        }
        
        public void setProgressMessage(string msg)
        {
            label_ProgressText.Text = msg;
        }

        public void changeScanProgressDisplay(bool isScanCompleted)
        {
            if (isScanCompleted)
            {
                pictureBox_LoadingIcon.Visible = false;
                label_OverviewStatus.Text = "Scan completed. Results successfully exported.";
            }
            else
            {
                pictureBox_LoadingIcon.Visible = true;
                label_OverviewStatus.Text = "Auditing. Please wait...";
            }
        }

        private void button_FinishAudit_Click(object sender, EventArgs e)
        {
            form1.showAuditUC();
            changeScanProgressDisplay(false);
        }
    }
}
