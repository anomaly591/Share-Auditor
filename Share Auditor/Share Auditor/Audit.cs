using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl; // For DirectorySecurity class
using System.Security.Principal; // For NTAccount

namespace Share_Auditor
{
    class Audit
    {
        private Form1 form1;
        private UC_Progress ucProgress;
        private UC_Audit ucAudit;
        private BackgroundWorker bgWorker_Audit;
        private string auditLocation;
        private string exportLocation;
        private bool showSystemAccounts;
        private bool auditEventLogs;
        private Logs log;
        private int foldersCounted = 0;
        private int foldersScanned = 0;
        private int foldersAccessErrors = 0;
        private int numLevelsDeepSetting = 3;
        private string currentFolder = "";

        // Entry point for the audit - manages the various configurations surrounding the audit
        public Audit(Form1 _form1, UC_Progress _ucProgress, string _auditLocation, string _exportLocation, string numLevelsDeep, bool _auditEventLogs, bool _showSystemAccounts)
        {
            this.form1 = _form1;
            this.ucProgress = _ucProgress;
            this.auditLocation = _auditLocation;
            this.exportLocation = _exportLocation;
            this.auditEventLogs = _auditEventLogs;
            this.showSystemAccounts = _showSystemAccounts;
            this.ucAudit = _form1.ucAudit; // Access ucAudit instance from form1 field

            // Check how many levels deep the application needs to scan and audit
            calculateHowManyLevelsDeepToScan(numLevelsDeep);

            // Configure logging
            log = new Logs();
            log.generateFileName(exportLocation, "permissions", "csv");
             
            // Background worker for scanning and reporting
            bgWorker_Audit = new BackgroundWorker();
            bgWorker_Audit.WorkerReportsProgress = true;
            bgWorker_Audit.DoWork += new DoWorkEventHandler(bgWorker_Scan_DoWork);
            bgWorker_Audit.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_Scan_RunWorkerCompleted);
            bgWorker_Audit.WorkerReportsProgress = true;
            bgWorker_Audit.RunWorkerAsync();
        }

        // Check how many levels deep the application needs to scan and audit
        private void calculateHowManyLevelsDeepToScan(string levelsDeep)
        {
            if (levelsDeep == "unlimited") { }
            switch (levelsDeep)
            {
                case "1": this.numLevelsDeepSetting = 1; break;
                case "2": this.numLevelsDeepSetting = 2; break;
                case "3": this.numLevelsDeepSetting = 3; break;
                case "4": this.numLevelsDeepSetting = 4; break;
                case "5": this.numLevelsDeepSetting = 5; break;
                case "Unlimited": this.numLevelsDeepSetting = 9999999; break;
            }
        }

        private void bgWorker_Scan_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1500); // Sleep to stop panel flicker on shorter audits (< 1s)
            directorySearch(auditLocation, exportLocation, showSystemAccounts, 1);
        }

        private void bgWorker_Scan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            ucProgress.changeScanProgressDisplay(true);
            ucAudit.displayError("Scan Completed -> " + foldersScanned + " folders audited.", false); 

            // Add finished audit information to the logfile
            log.addToPermissionsLogFile(System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine);
            log.addToPermissionsLogFile("Folders Scanned: " + foldersScanned + " | Folders with access errors (can not scan deeper):  " + foldersAccessErrors);
            log.addToPermissionsLogFile("Date/Time log completed:" + dt.ToString("HH:mm:ss dd/MM/yy")); 
            if (foldersAccessErrors > 0)
            {
                log.addToPermissionsLogFile(System.Environment.NewLine); 
            }
        }

        // This function is where directories are recursively audited
        private void directorySearch(string location, string exportLocation, bool showSystemAccounts, int currentLevel)
        {
            if (currentLevel > numLevelsDeepSetting)
            {
                // Reached levels limit so do not continue
            }
            else
            {
                List<string> dirs = new List<string>();
                try
                {
                    foreach (string dir in Directory.GetDirectories(location))
                    {
                        foldersCounted++;
                        dirs.Add(dir);
                    }
                }
                catch (Exception e)
                {
                    // Suppress error because you want the audit scan to continue
                    foldersAccessErrors++;
                }

                foreach (string dir in dirs)
                {
                    currentFolder = dir;
                    foldersScanned++;

                    try
                    {
                        List<string> logListCSV = new List<string>();
                        DirectoryInfo di = new DirectoryInfo(dir);
                        var permissions = di.Attributes;
                        string csvDir = dir;
                        string csvPermissions = ""; 

                        DirectorySecurity dSecurity = Directory.GetAccessControl(dir);
                        foreach (FileSystemAccessRule rule in dSecurity.GetAccessRules(true, true, typeof(NTAccount)))
                        {
                            //Console.WriteLine(csvDir + " ::: " + rule.IdentityReference + " [" + rule.AccessControlType + ": " + rule.FileSystemRights + "]"); 

                            // Check that the results do not contain numeric ACLs -> msdn.microsoft.com/en-us/library/aa364399.aspx
                            if 
                            (
                                !rule.FileSystemRights.ToString().Contains("268435456") &&
                                !rule.FileSystemRights.ToString().Contains("-536805376") &&
                                !rule.FileSystemRights.ToString().Contains("-1610612736")
                            )
                            {
                                if (showSystemAccounts)
                                {
                                    string csvFormat = rule.IdentityReference + " [" + rule.AccessControlType + ": " + rule.FileSystemRights + "]";
                                    string csvSantised = csvFormat.Replace(",", " ");
                                    csvPermissions += ", " + csvSantised;
                                }
                                else
                                {
                                    // Check results do not show system accounts
                                    if (!rule.IdentityReference.ToString().Contains("BUILTIN") &&
                                            !rule.IdentityReference.ToString().Contains(@"NT AUTHORITY\SYSTEM"))
                                    {
                                        string csvFormat = rule.IdentityReference + " [" + rule.AccessControlType + ": " + rule.FileSystemRights + "]";
                                        string csvSantised = csvFormat.Replace(",", " ");
                                        csvPermissions += ", " + csvSantised;
                                    }
                                }
                            }
                        }
                         
                        // Update status on Progress User Control
                        ucProgress.Invoke(new System.Windows.Forms.MethodInvoker(delegate
                        {
                            ucProgress.setProgressMessage(foldersScanned + " folders scanned");
                        }));

                        // Add string to List<string>
                        //logListCSV.Add(csvDir + ", " + csvPermissions);
                        logListCSV.Add(csvDir + csvPermissions + ", ");

                        // Add List<string> to logfile function
                        log.addListToPermissionsLogFile(logListCSV); 
                    }
                    catch (Exception e)
                    {
                        foldersAccessErrors++;
                        log.addToPermissionsLogFile(" -----------------> Error accessing directory. " + e);
                        continue;
                    }

                    // Keep recursive search going! 
                    directorySearch(dir, exportLocation, showSystemAccounts, currentLevel + 1);
                }
            }
        }
    }
}
