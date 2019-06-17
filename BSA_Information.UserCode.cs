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
    public partial class BSA_Information
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_InformationVerticalScroll()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.BackStage.InformationVerticalScroll' at Center.", repo.MyAssaysExplorer.BackStage.InformationVerticalScrollInfo);
            repo.MyAssaysExplorer.BackStage.InformationVerticalScroll.Click();
        }

        public void Set_Value_InformationVerticalScroll()
        {
        	var scroll = repo.MyAssaysExplorer.BackStage.InformationVerticalScroll;
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '0' on item 'MyAssaysExplorer.BackStage.InformationVerticalScroll'.", repo.MyAssaysExplorer.BackStage.InformationVerticalScrollInfo);
            scroll.Element.SetAttributeValue("Value", scroll.Element.GetAttributeValueText("MaxValue"));
        }

    }
}