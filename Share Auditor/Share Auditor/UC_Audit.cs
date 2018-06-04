using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Share_Auditor
{
    public partial class UC_Audit : UserControl
    {
        private Form1 form1;
        private UC_Progress ucProgress;

        public UC_Audit(Form1 f, UC_Progress ucP, string auditLocation_Setting, string exportLocation_Setting, string includeAdministrator_Setting, string numLevels_Setting)
        {
            InitializeComponent();
            this.ucProgress = ucP;
            this.form1 = f;
            displayError("", true);
            tb_auditLocation.Text = auditLocation_Setting;
            tb_exportLocation.Text = exportLocation_Setting;
            populateComboBox(numLevels_Setting);
            this.ActiveControl = label_ErrorMessage;
        }

        private void populateComboBox(string numLevels_Setting)
        {
            cb_numLevelsDeep.Items.Add("1");
            cb_numLevelsDeep.Items.Add("2");
            cb_numLevelsDeep.Items.Add("3");
            cb_numLevelsDeep.Items.Add("4");
            cb_numLevelsDeep.Items.Add("5");
            cb_numLevelsDeep.Items.Add("Unlimited");

            // Set selected combobox item
            switch (numLevels_Setting)
            {
                case "1": cb_numLevelsDeep.SelectedIndex = 0; break;
                case "2": cb_numLevelsDeep.SelectedIndex = 1; break;
                case "3": cb_numLevelsDeep.SelectedIndex = 2; break;
                case "4": cb_numLevelsDeep.SelectedIndex = 3; break;
                case "5": cb_numLevelsDeep.SelectedIndex = 4; break;
                case "Unlimited": cb_numLevelsDeep.SelectedIndex = 5; break;
                default: cb_numLevelsDeep.SelectedIndex = 0; break;
            }
        }

        private void prepareAudit()
        {
            Properties.Settings.Default["AuditLocation"] = tb_auditLocation.Text;
            Properties.Settings.Default["ExportLocation"] = tb_exportLocation.Text;
            Properties.Settings.Default["NumLevels"] = cb_numLevelsDeep.SelectedItem.ToString();
            Properties.Settings.Default.Save();

            bool includeSystemAccounts = false;
            bool okToBeginAudit = true;

            // Validate audit location
            if (string.IsNullOrWhiteSpace(tb_auditLocation.Text)) { okToBeginAudit = false; displayError("Please enter an audit location.", true); }
            if (!Directory.Exists(tb_auditLocation.Text)) { okToBeginAudit = false; displayError("Invalid audit location.", true); }

            // Validate export location
            if (string.IsNullOrWhiteSpace(tb_exportLocation.Text)) { okToBeginAudit = false; displayError("Please enter an export location.", true); }
            if (!Directory.Exists(tb_exportLocation.Text)) { okToBeginAudit = false; displayError("Invalid export location.", true); }
             
            if (checkBox_IncludeSystemAccounts.Checked) { includeSystemAccounts = true; }
            if (okToBeginAudit)
            {
                displayError("", true);
                Audit audit = new Audit(form1, ucProgress, tb_auditLocation.Text, tb_exportLocation.Text, cb_numLevelsDeep.SelectedItem.ToString(), true, includeSystemAccounts);
                form1.showProgressUC(); 
            }
        }

        public void displayError(string error, bool showRed)
        {
            label_ErrorMessage.Text = error;
            if (showRed)
            {
                label_ErrorMessage.ForeColor = ColorTranslator.FromHtml("#AD4040");
            }
            else
            {
                label_ErrorMessage.ForeColor = ColorTranslator.FromHtml("#649964");
            }
        }

        private void button_BrowseAuditLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog_AuditLocation = new FolderBrowserDialog();
            if (folderBrowserDialog_AuditLocation.ShowDialog() == DialogResult.OK)
            {
                tb_auditLocation.Text = folderBrowserDialog_AuditLocation.SelectedPath;
            }
        }

        private void button_BrowseExportLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog_ExportLocation = new FolderBrowserDialog();
            if (folderBrowserDialog_ExportLocation.ShowDialog() == DialogResult.OK)
            {
                tb_exportLocation.Text = folderBrowserDialog_ExportLocation.SelectedPath;
            }
        }

        private void button_StartAudit_Click(object sender, EventArgs e)
        {
            prepareAudit();
        }

    }
}
