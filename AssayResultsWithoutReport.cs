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
    ///The AssayResultsWithoutReport recording.
    /// </summary>
    [TestModule("e63b503e-36dd-411e-a886-f892768f6dc5", ModuleType.Recording, 1)]
    public partial class AssayResultsWithoutReport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static AssayResultsWithoutReport instance = new AssayResultsWithoutReport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AssayResultsWithoutReport()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AssayResultsWithoutReport Instance
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

            Prepare("Quantikine®");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.ProtocolTab' at Center.", repo.MyAssaysExplorer.ProtocolTabInfo, new RecordItemIndex(1));
            repo.MyAssaysExplorer.ProtocolTab.Click();
            Delay.Milliseconds(200);
            
            SelectProtocol("Quantikine®");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(3));
            Delay.Duration(15000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.SomeList' at 36;41.", repo.ProtocolAnalysisDesktop.SomeListInfo, new RecordItemIndex(4));
            repo.ProtocolAnalysisDesktop.SomeList.Click("36;41");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.SaveRibbonList.SomeContainer' at 111;31.", repo.ProtocolAnalysisDesktop.SaveRibbonList.SomeContainerInfo, new RecordItemIndex(5));
            repo.ProtocolAnalysisDesktop.SaveRibbonList.SomeContainer.Click("111;31");
            Delay.Milliseconds(200);
            
            unCheck();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.SaveRibbonList.SaveRibbonButton' at Center.", repo.ProtocolAnalysisDesktop.SaveRibbonList.SaveRibbonButtonInfo, new RecordItemIndex(7));
            repo.ProtocolAnalysisDesktop.SaveRibbonList.SaveRibbonButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(8));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Stack' at 56;5.", repo.ProtocolAnalysisDesktop.StackInfo, new RecordItemIndex(9));
            repo.ProtocolAnalysisDesktop.Stack.Click("56;5");
            Delay.Milliseconds(200);
            
            checkExistanceFile("Quantikine®");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.ResultsTab' at Center.", repo.MyAssaysExplorer.ResultsTabInfo, new RecordItemIndex(11));
            repo.MyAssaysExplorer.ResultsTab.Click();
            Delay.Milliseconds(200);
            
            SelectResult("Quantikine®");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(13));
            Delay.Duration(15000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.HomeListItem' at 44;5.", repo.ResultsAnalysis.HomeListItemInfo, new RecordItemIndex(14));
            repo.ResultsAnalysis.HomeListItem.Click("44;5");
            Delay.Milliseconds(200);
            
            checkCalculation();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
