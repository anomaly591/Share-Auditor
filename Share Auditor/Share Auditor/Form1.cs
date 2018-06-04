using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Share_Auditor
{
    public partial class Form1 : Form
    {

        //  CODE MAP
        //  -----------------------------------------------
        //  form1.cs            Loading point for application
        //  logs.cs             Class to handle writing to logfiles
        //  uc_progress.cs      User Control that shows progress of an ongoing audit
        //  uc_audit.cs         User Control that displays audit configuration options to the user 
        //  audit.cs            Class that handles the actual auditing of directories
        //  -----------------------------------------------

        public UC_Audit ucAudit;
        private UC_Progress ucProgress;
        private string auditLocation_Setting = Properties.Settings.Default["AuditLocation"].ToString();
        private string exportLocation_Setting = Properties.Settings.Default["ExportLocation"].ToString();
        private string includeAdministrator_Setting = Properties.Settings.Default["IncludeAdministrator"].ToString();
        private string numLevels_Setting = Properties.Settings.Default["NumLevels"].ToString();
        
        public Form1()
        {
            InitializeComponent();
            ucProgress = new UC_Progress(this);
            ucAudit = new UC_Audit(this, ucProgress, auditLocation_Setting, exportLocation_Setting, includeAdministrator_Setting, numLevels_Setting);
            panel_UCContainer.Controls.Add(ucAudit);
        }

        // Show the user control where audit settings are configured
        public void showAuditUC()
        {
            panel_UCContainer.Controls.Clear();
            panel_UCContainer.Controls.Add(ucAudit);
        }
        
        // Show the user control where progress of an ongoing audit is displayed
        public void showProgressUC()
        {
            panel_UCContainer.Controls.Clear();
            panel_UCContainer.Controls.Add(ucProgress);
            ucProgress.changeScanProgressDisplay(false);
        }
        
    }
}
