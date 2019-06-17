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
    ///The X_Axix_Kinetic recording.
    /// </summary>
    [TestModule("e177a930-59ef-49b8-899c-8e99ce207974", ModuleType.Recording, 1)]
    public partial class X_Axix_Kinetic : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static X_Axix_Kinetic instance = new X_Axix_Kinetic();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public X_Axix_Kinetic()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static X_Axix_Kinetic Instance
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

            OpenPropertyEditor();
            Delay.Milliseconds(0);
            
            CheckTransformsParameters();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.CalculateButton' at Center.", repo.ProtocolAnalysisDesktop.CalculateButtonInfo, new RecordItemIndex(2));
            repo.ProtocolAnalysisDesktop.CalculateButton.Click();
            Delay.Milliseconds(200);
            
            waitForCalculation();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.HomeRibbonTab' at Center.", repo.ResultsAnalysis.HomeRibbonTabInfo, new RecordItemIndex(4));
            repo.ResultsAnalysis.HomeRibbonTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.PropertiesBttn' at Center.", repo.ResultsAnalysis.PropertiesBttnInfo, new RecordItemIndex(5));
            repo.ResultsAnalysis.PropertiesBttn.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.XY_Reduction_Seconds' at Center.", repo.ResultsAnalysis.XY_Reduction_SecondsInfo, new RecordItemIndex(6));
            repo.ResultsAnalysis.XY_Reduction_Seconds.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Cycle') on item 'ResultsAnalysis.X_AxisChartTitleCycle'.", repo.ResultsAnalysis.X_AxisChartTitleCycleInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.ResultsAnalysis.X_AxisChartTitleCycleInfo, "Text", "Cycle");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.XY_Reduction_Minutes' at Center.", repo.ResultsAnalysis.XY_Reduction_MinutesInfo, new RecordItemIndex(9));
            repo.ResultsAnalysis.XY_Reduction_Minutes.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(10));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Cycle') on item 'ResultsAnalysis.X_AxisChartTitleCycle'.", repo.ResultsAnalysis.X_AxisChartTitleCycleInfo, new RecordItemIndex(11));
            Validate.Attribute(repo.ResultsAnalysis.X_AxisChartTitleCycleInfo, "Text", "Cycle");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.XY_Reduction_Hours' at Center.", repo.ResultsAnalysis.XY_Reduction_HoursInfo, new RecordItemIndex(12));
            repo.ResultsAnalysis.XY_Reduction_Hours.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(13));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Cycle') on item 'ResultsAnalysis.X_AxisChartTitleCycle'.", repo.ResultsAnalysis.X_AxisChartTitleCycleInfo, new RecordItemIndex(14));
            Validate.Attribute(repo.ResultsAnalysis.X_AxisChartTitleCycleInfo, "Text", "Cycle");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
