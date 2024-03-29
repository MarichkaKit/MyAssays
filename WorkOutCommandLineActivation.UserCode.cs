﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyAssays.Wizard.RanorexTests
{
    public partial class WorkOutCommandLineActivation
    {
        private string activatorFile;       
        
        private void Init()
        {
            activatorFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "activator", "Activator_Release", "Activator.exe");
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

    }
}