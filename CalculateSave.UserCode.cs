using System;
using System.IO;
using System.Reflection;
using System.Xml;
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
    public partial class CalculateSave
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private string _originValue;
        public static string _xmlValue;
        
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void checkPackageContent()
        {   Delay.Seconds(2);
        	string targetDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "temp\\1\\");
        	
        	string[] protocols = Directory.GetFiles(targetDirectory, "*.assay-protocol");
        	string[] runDetails = Directory.GetFiles(targetDirectory, "*.assayRunDetails.xml");
        	string[] reports = Directory.GetFiles(targetDirectory, "*.report.xml");
        	
        	if(protocols.Length != 1)
        		Report.Error(toString(targetDirectory, protocols.Length, "protocols."));
        		
        	if(runDetails.Length != 1)
        		Report.Error(toString(targetDirectory, runDetails.Length, "runDetails files."));
			
        	if(reports.Length != 1)
        		Report.Error(toString(targetDirectory, reports.Length, "reports."));       	
        }
        
        private string toString(string targetDirectory, int count, string typeFile)
        {
        	return String.Format("The directory {0} containe {1} {2}" , targetDirectory, count, typeFile);
        }

        public string getPadValue()
        {
        	_originValue = repo.ResultsAnalysis.TabControlGrid.PadText.TextValue.Replace(" ", "").Replace("\r\n", "");
        	return _originValue;			
        }

        public static string getXMLValue(string xmlFile)
        {
        	if( String.IsNullOrEmpty(xmlFile))
        		xmlFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "temp\\1\\default.assayRunDetails.xml");
        	
        	 XmlDocument doc = new XmlDocument();
        	 doc.LoadXml(File.ReadAllText(xmlFile));
		
		     // Get and display all titles.
		     XmlElement root = doc.DocumentElement;
		     XmlNodeList elemList = root.GetElementsByTagName("Contents");
		     for (int i=0; i < elemList.Count; i++)
		     {   
		        _xmlValue = elemList[i].InnerXml;
		     } 
		     
		     return _xmlValue;
        }
        
        
        public void comparePadXML()
        {
        	string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ExpectedRunDetails\WFs\WF4_expectedXML.txt");
        	string expected = File.ReadAllText(path);
        	Report.Info("Expected value: " + expected);
        	_xmlValue = _xmlValue.Replace(" ", "").Replace("\n", "").Replace("\r", "");
        	Report.Info("Actual value: " + _xmlValue);
;
        	Validate.AreEqual(_xmlValue, expected, "The measurements-pad values are equal to runDetails values");  
        }

        public void extractResult(string name)
        {
        	ExtractProtocolHelper.ExtractResultsTo(null, null, name + " (1).assay-results");        	
        }

        public void deleteTempFolder()
        {
        	ExtractProtocolHelper.DeleteTempFolder();
        }

        public void isResultsActive()
        {
        	if(repo.ResultsAnalysis.SeventhTabInfo.Exists() && repo.ResultsAnalysis.SeventhTab.Selected)
        		Report.Success("Calculations performed.");
        	else Report.Error("Results were not calculated.");
        }

        public void selectProtocol(string name)
        {
        	HelperSelectProtocolResult.SelectProtocolItem(name);
        	Delay.Seconds(10);
        }

        public void addProtocol(string fileName)
        {
        	HelperLoadFileToFolder.addToFolderProtocol(fileName, null, "Protocols", null);
        	Delay.Seconds(2);
        }

        public void cleanHelper()
        {
        	CleanDataHelper.DeleteProtocols();
        	CleanDataHelper.DeleteResults();
        	CleanDataHelper.DeleteCustomLayouts();
        	ExtractProtocolHelper.DeleteTempFolder();
        	Delay.Seconds(2);
        }

        public void waitForCalculation()
        {
        	Report.Log(ReportLevel.Info, "Delay", String.Format("Waiting for {0}s.", HelperConstants.WAIT_CALCULATION));
        	Delay.Seconds(HelperConstants.WAIT_CALCULATION);
        }
    }
}