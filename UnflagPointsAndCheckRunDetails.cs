﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Repository;

namespace MyAssays.Wizard.RanorexTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UnflagPointsAndCheckRunDetails recording.
    /// </summary>
    [TestModule("f5d37cb8-bdc2-45ad-a642-9afe6c8e72e2", ModuleType.Recording, 1)]
    public partial class UnflagPointsAndCheckRunDetails : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static UnflagPointsAndCheckRunDetails instance = new UnflagPointsAndCheckRunDetails();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UnflagPointsAndCheckRunDetails()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UnflagPointsAndCheckRunDetails Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.ResultsTab' at Center.", repo.ResultsAnalysis.ResultsTabInfo, new RecordItemIndex(0));
            repo.ResultsAnalysis.ResultsTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.ChartTopPanel.SomeTabPage5' at 34;10.", repo.ResultsAnalysis.ChartTopPanel.SomeTabPage5Info, new RecordItemIndex(1));
            repo.ResultsAnalysis.ChartTopPanel.SomeTabPage5.Click("34;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultMatrixTransform.A1Checkbox' at Center.", repo.ResultMatrixTransform.A1CheckboxInfo, new RecordItemIndex(2));
            repo.ResultMatrixTransform.A1Checkbox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(3));
            Delay.Duration(3000, false);
            
            ToggleFlagPoint("1", "0.374");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.SomeButton1' at Center.", repo.ResultsAnalysis.SomeButton1Info, new RecordItemIndex(6));
            repo.ResultsAnalysis.SomeButton1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "False"), "1", "0.374");
            Delay.Milliseconds(0);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "True"), "2", "0.353");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.ChartTopPanel.SomeTabPage' at 34;10.", repo.ResultsAnalysis.ChartTopPanel.SomeTabPageInfo, new RecordItemIndex(10));
            repo.ResultsAnalysis.ChartTopPanel.SomeTabPage.Click("34;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(11));
            Delay.Duration(3000, false);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "False"), "1", "0.374");
            Delay.Milliseconds(0);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "True"), "2", "0.353");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.ChartTopPanel.SomeTabPage1' at 34;10.", repo.ResultsAnalysis.ChartTopPanel.SomeTabPage1Info, new RecordItemIndex(14));
            repo.ResultsAnalysis.ChartTopPanel.SomeTabPage1.Click("34;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(15));
            Delay.Duration(3000, false);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "False"), "1", "0.374");
            Delay.Milliseconds(0);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "True"), "2", "0.353");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.ChartTopPanel.SomeTabPage2' at 34;10.", repo.ResultsAnalysis.ChartTopPanel.SomeTabPage2Info, new RecordItemIndex(18));
            repo.ResultsAnalysis.ChartTopPanel.SomeTabPage2.Click("34;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(19));
            Delay.Duration(3000, false);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "False"), "1", "0.374");
            Delay.Milliseconds(0);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "True"), "2", "0.353");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.ChartTopPanel.SomeTabPage3' at 34;10.", repo.ResultsAnalysis.ChartTopPanel.SomeTabPage3Info, new RecordItemIndex(22));
            repo.ResultsAnalysis.ChartTopPanel.SomeTabPage3.Click("34;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(23));
            Delay.Duration(3000, false);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "False"), "1", "0.374");
            Delay.Milliseconds(0);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "True"), "2", "0.353");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.ChartTopPanel.SomeTabPage4' at 34;10.", repo.ResultsAnalysis.ChartTopPanel.SomeTabPage4Info, new RecordItemIndex(26));
            repo.ResultsAnalysis.ChartTopPanel.SomeTabPage4.Click("34;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(27));
            Delay.Duration(3000, false);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "False"), "1", "0.374");
            Delay.Milliseconds(0);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "True"), "2", "0.353");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.ChartTopPanel.SomeTabPage6' at 34;10.", repo.ResultsAnalysis.ChartTopPanel.SomeTabPage6Info, new RecordItemIndex(30));
            repo.ResultsAnalysis.ChartTopPanel.SomeTabPage6.Click("34;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(31));
            Delay.Duration(3000, false);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "False"), "1", "0.374");
            Delay.Milliseconds(0);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "True"), "2", "0.353");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.MeasurementsTab' at 79;53.", repo.ResultsAnalysis.MeasurementsTabInfo, new RecordItemIndex(34));
            repo.ResultsAnalysis.MeasurementsTab.Click("79;53");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(35));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.Chart2' at 10;7.", repo.ResultsAnalysis.Chart2Info, new RecordItemIndex(36));
            repo.ResultsAnalysis.Chart2.Click("10;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(37));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.Unknown1Checkbox' at 6;5.", repo.ResultsAnalysis.Unknown1CheckboxInfo, new RecordItemIndex(38));
            repo.ResultsAnalysis.Unknown1Checkbox.Click("6;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(39));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.Unknown1Checkbox' at 6;5.", repo.ResultsAnalysis.Unknown1CheckboxInfo, new RecordItemIndex(40));
            repo.ResultsAnalysis.Unknown1Checkbox.Click("6;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(41));
            Delay.Duration(3000, false);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "False"), "1", "0.374");
            Delay.Milliseconds(0);
            
            ValidatePointFlagState(ValueConverter.ArgumentFromString<bool>("expectedState", "True"), "2", "0.353");
            Delay.Milliseconds(0);
            
            CheckassayRunDetails();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
