﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

using System;
using System.ComponentModel;
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
    public partial class AssayResultsWithoutReport
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Prepare(string name)
        {
        	DeleteHelper.DeleteProtocol(name + ".assay-protocol");
        	DeleteHelper.DeleteResults(name + " (1).assay-results");
        	DownloadProtocol.Search_Protocol(name);
        	DownloadProtocol.WaitFor();
        	DownloadProtocol.Download_Protocol(name);
        	Delay.Seconds(10);
        }

        public void unCheck()
        {
        	repo.ProtocolAnalysisDesktop.SaveRibbonList.SaveChangesToProtocol.Uncheck();
        }

        public void SelectResult(string _result)
        {
        	HelperSelectProtocolResult.SelectNUVResultItem(_result);
        }

        public void SelectProtocol(string _protocol)
        {
        	HelperSelectProtocolResult.SelectProtocolItem(_protocol);
        }

        public void checkExistanceFile(string resultName)
        {
        	string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MyAssays\Results\");
        	string pathFull = path + resultName + " (1).assay-results";
        	
        	if(File.Exists(pathFull))
        		Report.Success(String.Format("File {0} created as {0} (1).assay-results", resultName));
        	else Report.Error(String.Format("File {0} was not created as {0} (1).assay-results", resultName));
        }

        public void checkCalculation()
        {
        	if (repo.ResultsAnalysis.SeventhTabInfo.Exists() && repo.ResultsAnalysis.SeventhTab.Selected)
        		Report.Success("Calculation was performed.");
        	else Report.Error("Calculation was not performed.");
        }

    }
}