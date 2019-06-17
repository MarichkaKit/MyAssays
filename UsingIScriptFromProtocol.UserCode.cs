using System;
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
    public partial class UsingIScriptFromProtocol
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void CommandLineImport(string protocolName, string param = "")
        {
        	var file = Path.Combine(HelperConstants.getExeAssemblyPath(), @"Inputs\ImportMeasurements\ELISA Absorbance 405nm.xml");
        	
        	var arg =  " \"/import-raw:" + file + "\"" + param;
        	Report.Info("Argument string: " + arg);
        	Report.Info(String.Format("Validating Exists on file '{0}'. {1}.", file, File.Exists(file)));
        	
        	StartAnalysisHelper.Protocol = protocolName;
        	StartAnalysisHelper.StartAnalysis(arg);
        	
            Delay.Seconds(HelperConstants.TIME_TO_OPEN_PROTOCOL);
        }

        public void renameIScriptFolder(bool invert)
        {
        	HelperDirectoryAndFilesOperations.RenameIScriptsFolder(invert);
        }

        public void Prepare()
        {
        	CleanDataHelper.DeleteProtocols();
        	CleanDataHelper.DeleteResults();
        	Delay.Seconds(2);
        }

        public void KillApp(string appName)
        {
        	Report.Screenshot();
        	KillProcessHelper.KillProcess(appName);
        }

    }
}