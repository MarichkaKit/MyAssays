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
    public partial class CalculateAndExport
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
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

        public void CompareExportedFile(string fileName)
        {
        	ExtractProtocolHelper.DeleteTempFolder();
        	ExtractProtocolHelper.ExtractResultsTo(null, null, fileName + ".assay-results");
        	
        	var pathToResultsXML =  Path.Combine(HelperConstants.getDesktopTempFolder(), "1");
        	var pathToReportXML =  Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MyAssays\Reports");
        	
        	var resultsXML = File.ReadAllText(Directory.GetFiles(pathToResultsXML,"*.report.xml").First());
        	var reportXML = File.ReadAllText(Directory.GetFiles(pathToReportXML,"*.xml").First());
        	
        	Report.Info("Comparing xml file in *.assay-results file and in Report folder.");
        	Validate.AreEqual(reportXML, resultsXML);
        }

    }
}