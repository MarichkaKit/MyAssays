using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyAssays.Wizard.RanorexTests
{
    public partial class AddQCFeatureToMTA
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void RunProtocolFile(string fileName)
        {
        	RunAnalysisProtocol.Instance.protocolName = fileName;
        	RunAnalysisProtocol.Start();
        }

        public void CleanHelper()
        {
        	CleanDataHelper.DeleteResults();
        	CleanDataHelper.DeleteProtocols();
        	CleanDataHelper.DeleteReports();
        	CleanDataHelper.DeleteQCDirectory();
        }

        public void ResolveSavingProtocol()
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Ribbon' at 13;37.", repo.ProtocolAnalysisDesktop.RibbonInfo, new RecordItemIndex(0));
            repo.ProtocolAnalysisDesktop.Ribbon.Click("13;37");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.SaveContainer' at Center.", repo.ProtocolAnalysisDesktop.SaveContainerInfo, new RecordItemIndex(1));
            repo.ProtocolAnalysisDesktop.SaveContainer.Click();
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'True' on item 'ProtocolAnalysisDesktop.SomeList1.SaveChangesToProtocol'.", repo.ProtocolAnalysisDesktop.SaveRibbonList.SaveChangesToProtocolInfo, new RecordItemIndex(2));
            repo.ProtocolAnalysisDesktop.SaveRibbonList.SaveChangesToProtocol.Element.SetAttributeValue("Checked", "True");
            
            repo.ProtocolAnalysisDesktop.HomeRibbon.Click();
        }

        public void CheckReportXML(string resultsName, string version, string expectedFileName)
        {
        	ExtractProtocolHelper.DeleteTempFolder();
        	ExtractProtocolHelper.ExtractResultsTo(null, null, resultsName);
        		
        	var resultsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "temp", version);
        	var actualXML = File.ReadAllText(Directory.GetFiles(resultsFolder, "*.report.xml").First()).Replace(" ", "").Replace("\r\n", "");
        	
        	/* 
 			 * We will split the expected file on several lines and will validate an existence each of one
			 * because the *.report.xml file contains date and time (till seconds). 
        	 * It may cause differences in seconds and test will not be stable.
        	 */
        	var expectedXMLStrings = File.ReadAllLines(Path.Combine(HelperConstants.getExeAssemblyPath(), @"ExpectedRunDetails\QualityControl", expectedFileName));
        	
        	Report.Info("Actual xml:" + actualXML);
        	Report.Info("Expected xml:" + expectedXMLStrings[0] + expectedXMLStrings[1]);
        	
        	if(actualXML.Contains(expectedXMLStrings[0]) && actualXML.Contains(expectedXMLStrings[1]))
        		Report.Success("Tables was added to *.report.xml");
        	else Report.Failure("QC analysis report is not as expected.");
        	
        	ExtractProtocolHelper.DeleteTempFolder();
        }

        public void CheckQCInProtocol(string protocolName)
        {
        	ExtractProtocolHelper.DeleteTempFolder();
        	ExtractProtocolHelper.ExtractProtocolTo(null, null, protocolName);
        	
        	var tempFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "temp");
        	var resultsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MyAssays\Results\");
        	
        	var settingsQC = Directory.GetFiles(tempFolder, "settings.qc.xml");
        	if(settingsQC.Length == 0)
        		Report.Failure("Protocol does not contains a settings.qc.xml file.");
        	else
        	{
        		var actualQC = File.ReadAllText(settingsQC.First()).Replace(" ", "").Replace("\r\n", "");
	        	var expectedQC = File.ReadAllText(Path.Combine(HelperConstants.getExeAssemblyPath(), @"ExpectedRunDetails\QualityControl\SettingsMTA.qc.txt")).Replace("PATH_TO_RESULTS", resultsFolder)
	        																																			   .Replace(" ", "")
	        																																			   .Replace("\r\n", "");
	        	
	        	Report.Info("Actual xml:" + actualQC);
	        	Report.Info("Expected xml:" + expectedQC);
	        	
	        	if(actualQC.Equals(expectedQC.Replace("BIT_NUM", "8")) || actualQC.Equals(expectedQC.Replace("BIT_NUM", "16")))
	        		Report.Success("QC analysis report contains selected table output types for observation.");
	        	else Report.Failure("QC analysis settings file is not as expected.");
        	}

        	ExtractProtocolHelper.DeleteTempFolder();
        }

        public void WaitForCalculation()
        {
        	HelperConstants.waitForCalculation();
        }

        public void CheckQCs(int expectedCount)
        {
        	var filesCount = Directory.GetFiles(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MyAssays\QC"), "*.qc.xml").Length;
        	Report.Info("Validating a created report.");
        	Validate.AreEqual(filesCount, expectedCount);
        }

        public void CheckReports(int expectedCount)
        {
        	var filesCount = Directory.GetFiles(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MyAssays\Reports"), "*.xlsx").Length;
        	Report.Info("Validating a created report.");
        	Validate.AreEqual(filesCount, expectedCount);
        }

        public void InputLimit(string limit, Ranorex.Adapter adapter)
        {
        	adapter.Click();
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}'.");
            Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}");
            Keyboard.Press(limit);
        }

        public void InputObservation(string observationStr, Ranorex.Adapter adapter)
        {
        	adapter.Click();
        	Keyboard.Press(observationStr);
        }

    }
}