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
using System.Linq;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyAssays.Wizard.RanorexTests
{
    public partial class AddProtocol
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        
        private string _protocol = "Four Parameter Logistic Curve";
        
        private string _myAssaysPath;
        
        private void Init()
        {
        	_myAssaysPath = StartAnalysisHelper.MadFolderPath;
        }

        public void RunMyAssays()
        {
        	Report.Log(ReportLevel.Info, "Application", String.Format("Run application '{0}\\MyAssays.Desktop.Explorer.exe' with arguments '' in normal mode.", _myAssaysPath));
            Host.Local.RunApplication(_myAssaysPath + "\\MyAssays.Desktop.Explorer.exe", "", _myAssaysPath, false);
        }

        public void CheckItems()
        {
        	var protocols = repo.MyAssaysExplorer.LayoutRoot.ResultsListView.Children;
        	foreach(var protocol in protocols)
        	{
        		if (protocol.Children[0].Children[0].Element.GetAttributeValueText("Text").Equals(_protocol))
        		{
        		    protocol.As<Ranorex.ListItem>().Select();
        		    Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.LayoutRoot.DownloadRibbonButton' at 10;55.", repo.MyAssaysExplorer.LayoutRoot.DownloadRibbonButtonInfo);
            		repo.MyAssaysExplorer.LayoutRoot.DownloadRibbonButton.Click();
        		    break;
        		}
 				        		
        	}
        }

        public void ClickSearchButton()
        {
        	var button = repo.MyAssaysExplorer.Self.Children[0].Children[0].Children[0].Children[3].Children[1];
        	button.EnsureVisible();
        	button.Focus();
        	button.Click();
        }

        public void WaitDownloading()
        {
        	
        	var progressBar = repo.MyAssaysExplorer.LayoutRoot.SomeProgressBar;
        	while (progressBar.Visible) 
        	{
        		Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'MyAssaysExplorer.ByRefFolderStepViewModel19289328MyAss'.", repo.MyAssaysExplorer.ProtocolTabInfo);
            	Validate.Attribute(repo.MyAssaysExplorer.ProtocolTabInfo, "Enabled", "True");
            	Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'MyAssaysExplorer.SearchRibbonBar.InnerPath'.", repo.MyAssaysExplorer.SearchBttnInfo);
            	Validate.Attribute(repo.MyAssaysExplorer.SearchBttnInfo, "Enabled", "True");
            	Delay.Seconds(2);
        	}
        }         

    }
}