using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

using Ranorex;
using WinForms = System.Windows.Forms;

namespace MyAssays.Wizard.RanorexTests
{
    public partial class ActivateMyAssays
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        
        private string _myAssaysPath;
        private string activatorFile;
        
        private void Init()
        {
        	_myAssaysPath = StartAnalysisHelper.MadFolderPath;
        	activatorFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "activator", "Activator_Release", "Activator.exe");
        }

        public void RunMyAssays()
        {
        	Report.Log(ReportLevel.Info, "Application", String.Format("Run application '{0}\\MyAssays.Desktop.Explorer.exe' with arguments '' in normal mode.", _myAssaysPath));
            Host.Local.RunApplication(_myAssaysPath + "\\MyAssays.Desktop.Explorer.exe", "", _myAssaysPath, false);
        }

        public void ValidateUseInternetConnectionCheckbox()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.UseInternetConnectionForActivation'.", repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.UseInternetConnectionForActivationInfo, new RecordItemIndex(16));
            	
            try
            {
            	Validate.EnableReport = false;
            	Validate.Attribute(repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.UseInternetConnectionForActivationInfo, "Checked", "True");
            	Validate.EnableReport = true;
            }
            catch (RanorexException e)
            {
            	Report.Info("Expected RanorexException occured: " + e);
            	repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.UseInternetConnectionForActivation.Element.SetAttributeValue("CheckState", "Checked");
            }
        }

        public void Key_Sequence_SomeText()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence email with focus on 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.SomeText'.", repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SomeTextInfo);
            repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SomeText.PressKeys(emailName);
        }

        public void Key_Sequence_SerialTextBox()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence serial code with focus on 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.SerialTextBox'.", repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SerialTextBoxInfo);
            repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SerialTextBox.PressKeys(serialCode);
        }

        public void ValidateLicensing()
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.SomeElement13' at 55;6.", repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SomeElement13Info);
            repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SomeElement13.Click("55;6");
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence serial code with focus on 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.SerialTextBox'.", repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SerialTextBoxInfo);
            repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SerialTextBox.PressKeys(serialCode);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.SomeElement14' at 50;15.", repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SomeElement14Info);
            repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SomeElement14.Click("50;15");
            Report.Log(ReportLevel.Info, "Keyboard", String.Format("Key sequence email with focus on 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.SomeText' - {0}.", emailName), repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SomeTextInfo);
            repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.SomeText.PressKeys(emailName);
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.UseInternetConnectionForActivation'.", repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.UseInternetConnectionForActivationInfo, new RecordItemIndex(16));
            	
            try
            {
            	Validate.EnableReport = false;
            	Validate.Attribute(repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.UseInternetConnectionForActivationInfo, "Checked", "True");
            	Validate.EnableReport = true;
            }
            catch (RanorexException e)
            {
            	Report.Info("Expected RanorexException occured: " + e);
            	repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.UseInternetConnectionForActivation.Element.SetAttributeValue("CheckState", "Checked");
            }
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.");
            Delay.Duration(5000, false);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.Next1' at 14;8.", repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.Next1Info);
            repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.Next1.Press();//.Click("14;8");
            
        }

        public void Mouse_Click_Next()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.Next' at 26;2.", repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.NextInfo);
            repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.Next.Press();
        }

        public void Mouse_Click_Activate()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.Activate' at 29;8.", repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.ActivateInfo);
            repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.Activate.Press();
        }

        public void Mouse_Click_Close()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopLicenseDeactivation.SomeContainer4.Close' at 50;12.", repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.CloseInfo);
            repo.MyAssaysDesktopLicenseActivationDeactivation.SomeContainer4.Close.Press();
        }

        public void Mouse_Click_CloseButton()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.CloseButton' at 11;1.", repo.MyAssaysExplorer.CloseButtonInfo);
            repo.MyAssaysExplorer.CloseButton.Click("11;1");
        }

        public void Activate(string id, string serial, string email)
        {
        	Report.Log(ReportLevel.Info, String.Format("Activator path: {0}", activatorFile));
        	var args = String.Format("/id:{0} /s:{1} /e:{2}", id, serial, email);
        	ProcessStartInfo p = new ProcessStartInfo(activatorFile, args);
        	p.RedirectStandardOutput = true;
        	p.UseShellExecute = false;
        	
			Process process = Process.Start(p);
			
			string output = process.StandardOutput.ReadToEnd();

			process.WaitForExit();
			
			Report.Log(ReportLevel.Info, output);
			
			Validate.IsTrue(output.Contains("Successfully activated"), "Validate output contains \"Successful activated message\" message");
        }

        public void AddVersionToLog()
        {
        	Report.Log(ReportLevel.Info, "Info", String.Format("Product version: {0}", repo.MyAssaysExplorer.BackStage.ProductVersion.TextValue));
        }
        

    }
}