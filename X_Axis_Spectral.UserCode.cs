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
    public partial class X_Axis_Spectral
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void waitForCalculation()
        {
        	HelperConstants.waitForCalculation();
        }

        public void CheckTransformsParameters()
        {
        	var transformsList = repo.ProtocolAnalysisDesktop.TransformsList.Children;

        	foreach(Unknown transform in transformsList)
        	{
        		Report.Info("Index of selected transform:" + transform.Element.ChildIndex);
        		transform.Click();
        		Delay.Seconds(2);
        		
        		checkAxisProperty(repo.ProtocolAnalysisDesktop.X_AxisProperty, "X Axis");
        		checkAxisProperty(repo.ProtocolAnalysisDesktop.Y_AxisProperty, "Y Axis");
        	}
        }
        
        private void checkAxisProperty(Adapter adapter, string propertyName)
        {
        	adapter.Click();
        	string actualProperties = "";
        	string expectedProperties = String.Concat("Index", "X (Wavelength)", "Y");
        	var dropdownElements = repo.MyAssaysDesktopAnalysis.Self.Find<Ranorex.WpfElement>("./listitem");
        	
        	foreach(var dropdownElement in dropdownElements)
        		actualProperties += dropdownElement.Children[0].Children[1].Element.GetAttributeValueText("text");
        	
        	adapter.Click();
        	
        	Validate.AreEqual(actualProperties, expectedProperties, String.Format("{0} dropdown property has 'X (Wavelength)' item.", propertyName));
        }

        public void OpenPropertyEditor()
        {
        	OpenProperties.OpenPropertiesInProtocolAnalysis();
        }

    }
}