﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

using System;
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
    public partial class VersionChangingMicroplate
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        
        PopupWatcher _closeChangingVersionWatcher;
        
        private void Init()
        {
            _closeChangingVersionWatcher = new PopupWatcher();
        	_closeChangingVersionWatcher.Watch(@"/form[@title='MyAssays Analysis']", confirmChangingVersion); 
        }

        public void selectListItem(int num)
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.MicroplateTab' at Center.");
            repo.ResultsAnalysis.MicroplateTab.Click();
            Delay.Milliseconds(200);
            
            var layouts =  repo.ResultsAnalysis.LayoutItems.Children.ToList();
          	layouts.ElementAt(num).As<Ranorex.ListItem>().Select();
          	Report.Info("Layout is selected.");
        }

        public void selectVersion(string num)
        {  
        	_closeChangingVersionWatcher.Start();
        	repo.ResultsAnalysis.SelectVersion.SelectedItemText = "Version " + num;   
        	Delay.Seconds(2);
        	_closeChangingVersionWatcher.Stop();
        }
        
        private static void confirmChangingVersion(Ranorex.Core.RxPath myPath, Ranorex.Core.Element myElemen)  
		{
        	Report.Log(ReportLevel.Info, "Comfirming changing version.");
        	Report.Screenshot();
        	
         	if(repo.MyAssaysAnalysis.ButtonOKInfo.Exists())
         	{
         		repo.MyAssaysAnalysis.ButtonOK.Click(); 
         	}
        }

    }
}