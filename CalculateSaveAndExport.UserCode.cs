using System;
using System.IO;
using System.Linq;
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
    public partial class CalculateSaveAndExport
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void CompareExportedFile(string fileName)
        {
        	ExtractProtocolHelper.DeleteTempFolder();
        	ExtractProtocolHelper.ExtractResultsTo(null, null, fileName + ".assay-results");
        	
        	var pathToResultsXML =  Path.Combine(HelperConstants.getDesktopTempFolder(), "2");
        	var pathToReportXML =  Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MyAssays\Reports");
        	
        	var resultsXML = File.ReadAllText(Directory.GetFiles(pathToResultsXML,"*.report.xml").First());
        	var reportXML = File.ReadAllText(Directory.GetFiles(pathToReportXML,"*.xml").First());
        	
        	Report.Info("Comparing xml file in *.assay-results file and in Report folder.");
        	Validate.AreEqual(reportXML, resultsXML);
        }

        public void WaitForCalculation()
        {
        	HelperConstants.waitForCalculation();
        }

        public void CleanHelper()
        {
        	CleanDataHelper.DeleteReports();
        	CleanDataHelper.DeleteResults();
        }

        public void UpdatePad(string concatValue)
        {
        	var padValue = repo.ResultsAnalysis.PadValue.TextValue ;
        	repo.ResultsAnalysis.PadValue.TextValue = concatValue + padValue.Substring(3, padValue.Length - 4);

        	Delay.Seconds(10);
        }

        public void SavingResults()
        {
        	SaveResults.Start();
        }

    }
}