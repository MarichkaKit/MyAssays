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
    public partial class AppearingAdditionalVersion
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        
        private int _indexActual;
        private int _index;
        private int _indexAfterChanging;
        private int _indexBeforeChanging;
        
        private void Init()
        {
            // Your recording specific initialization code goes here.
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
        	Delay.Seconds(2);
        }

        public void addLayout(string fileName)
        {
        	HelperLoadFileToFolder.addLayout(fileName, null, null);
        	Delay.Seconds(2);
        }

        public void selectProtocol(string name)
        {
        	HelperSelectProtocolResult.SelectProtocolItem(name);
        	Delay.Seconds(10);
        }

        public void layoutIndexBeforeChanging()
        {
        	_indexBeforeChanging = GetSelectedLayout();
        }

        public void selectListItem(int num)
        {
        	var layouts =  repo.ResultsAnalysis.LayoutItems.Children.ToList();          	
          	layouts.ElementAt(num).As<Ranorex.ListItem>().Select();
          	Report.Info("Layout is selected .");
        }

        public void selectVersion(string num)
        {  
        	repo.ResultsAnalysis.SelectVersion.SelectedItemText = "Version " + num;   
        	Delay.Seconds(2);        	
        }

        public void checkSelectedLayout(Adapter adapter)
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.MicroplateTab' at Center.");
            adapter.Click();
            Delay.Milliseconds(200);
            
        	_indexActual = GetSelectedLayout();
        	Validate.AreEqual(_indexActual, _indexBeforeChanging, "Validating selected layout.");
        }

        public void selectedLayoutAfterChanging()
        {
        	_indexAfterChanging = GetSelectedLayout();
        }

         public void checkSelectedLayoutAfter(Adapter adapter)
        {
         	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.MicroplateTab' at Center.");
            adapter.Click();
            Delay.Milliseconds(200);
            
        	_indexActual = GetSelectedLayout();
        	Validate.AreEqual(_indexActual, _indexAfterChanging, "Validating selected layout.");
        }
       
         public int GetSelectedLayout()
        {  
        	_index = 0;        	
        	var layouts = repo.ResultsAnalysis.LayoutItems.Children.ToList();
       
        	foreach (var layout in layouts)
        	{      		
        		if(layout.As<Ranorex.ListItem>().Selected)
        		{
        			Report.Info("SelectedLayoutIndex is " + _index);
        			break;
        		} 
        		_index++;
        	}        	
        	return _index;
        }

        public void waitForCalculation()
        {
        	Report.Log(ReportLevel.Info, "Delay", String.Format("Waiting for {0}s.", HelperConstants.WAIT_CALCULATION));
        	Delay.Seconds(HelperConstants.WAIT_CALCULATION);
        }

    }
}