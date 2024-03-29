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
using System.Linq;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.Diagnostics;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyAssays.Wizard.RanorexTests
{
    public partial class AddAllProtocols
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
               
        private void Init()
        {
        }

        public void CheckItems()
        {        	
        	var progressBar = repo.MyAssaysExplorer.LayoutRoot.SomeProgressBar;
			
        	while (progressBar.Visible) 
        		continue;
        	
            var protocols = repo.MyAssaysExplorer.LayoutRoot.SomeList.Children.ToList();
            foreach (var protocol in protocols)
            {
            	if (protocol.Children[0].Children[0].Element.GetAttributeValueText("Text").Contains("AlphaLISA")) //As<Ranorex.ListItem>().Text
            		continue;
            	protocol.Click();
                CheckProtocol.Protocol = protocol.As<Ranorex.ListItem>().Text;
                try
                {
                	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.LayoutRoot.DownloadAndLaunchRibbonButton' at 22;2.", repo.MyAssaysExplorer.LayoutRoot.DownloadAndLaunchRibbonButtonInfo, new RecordItemIndex(0));
            		repo.MyAssaysExplorer.LayoutRoot.DownloadAndLaunchRibbonButton.Click("22;2");
            		Delay.Milliseconds(200);
                	Report.Info(String.Format("Validation '{0}' protocol.", protocol.As<Ranorex.ListItem>().Text));
                	CheckProtocol.Start();
                }
                catch(ProtocolNotCalculatedException exc)
                {
                	Report.Warn(String.Format("Protocol {0} is not calculated correctly.", exc.Message));
                	Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(13));
                	try
					{
						foreach (Process proc in Process.GetProcessesByName("MyAssays.Desktop.Analysis"))
					            {
					                proc.Kill();
					                Report.Info(String.Format("Killed process {0}.", "MyAssays.Desktop.Analysis"));
					            }
					}
					catch(Exception ex)
					{
						Report.Warn(String.Format("Error with killing {0}. {1}", "MyAssays.Desktop.Analysis", ex));
					}
                }
                
            }
        }
    }
}