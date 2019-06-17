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

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyAssays.Wizard.RanorexTests
{
    public partial class BestFitMethodInMultiplex
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void selectTransform(int num)
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Transforms1' at Center.");
            repo.ProtocolAnalysisDesktop.TransformsList.Children[num].Click();
        }

        public void toWidescreen(int toLeft)
        {
        	if(repo.ProtocolAnalysisDesktop.PropertyEditorPanel.Element.ScreenRectangle.Width < (repo.ProtocolAnalysisDesktop.Self.ScreenRectangle.Width / 2))
        	{
//       start coordinates 	
        	var x = repo.ProtocolAnalysisDesktop.PropertyEditorPanel.Element.ScreenLocation.X - 5;
			var y = repo.ProtocolAnalysisDesktop.PropertyEditorPanel.Element.ScreenLocation.Y + 30;
			
			Mouse.MoveTo(new Point(x, y));          			
        	Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
        	Delay.Seconds(1);
        	Mouse.MoveTo(new Point(x - toLeft, y), 2000);
        	Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
        	Delay.Seconds(1);
        	}
        }

        public void openProperties(Ranorex.Adapter adapter)
        {
        	if (!adapter.Visible)
        	{
        		repo.ProtocolAnalysisDesktop.Properties.Click();
        	}
        	else
        	{
        		Report.Screenshot();
        	}
        }

        public void CheckLinerRegression(string state)
        {
        	if(!repo.ProtocolAnalysisDesktop.ListFits.Children[3].Element.GetAttributeValueText("Checked").ToLower().Equals(state))
        		repo.ProtocolAnalysisDesktop.ListFits.Children[3].Click();
        }

        public void Set_Value_FitMethod_cb(string index)
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.FitMethod' at Center.", repo.ProtocolAnalysisDesktop.FitMethodsInfo);
            repo.ProtocolAnalysisDesktop.FitMethod_cb.Click();
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute SelectedItemIndex to '2' on item 'ProtocolAnalysisDesktop.FitMethod_cb'.", repo.ProtocolAnalysisDesktop.FitMethod_cbInfo);
            repo.ProtocolAnalysisDesktop.FitMethod_cb.Element.SetAttributeValue("SelectedItemIndex", index);
            
            repo.ProtocolAnalysisDesktop.Self.Click();
        }

        public void WaitForCalculation()
        {
        	HelperConstants.waitForCalculation();
        }

    }
}