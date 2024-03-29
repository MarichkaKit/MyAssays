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
    ///The CalculateSaveAndExport recording.
    /// </summary>
    [TestModule("805eb12c-e8e3-4024-9b13-bacb4a7f9a0c", ModuleType.Recording, 1)]
    public partial class CalculateSaveAndExport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static CalculateSaveAndExport instance = new CalculateSaveAndExport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CalculateSaveAndExport()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CalculateSaveAndExport Instance
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

            CleanHelper();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.CalculateButton' at Center.", repo.ProtocolAnalysisDesktop.CalculateButtonInfo, new RecordItemIndex(1));
            repo.ProtocolAnalysisDesktop.CalculateButton.Click();
            Delay.Milliseconds(200);
            
            WaitForCalculation();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.HomeListItem' at Center.", repo.ResultsAnalysis.HomeListItemInfo, new RecordItemIndex(3));
            repo.ResultsAnalysis.HomeListItem.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.MeasurementsTab' at Center.", repo.ResultsAnalysis.MeasurementsTabInfo, new RecordItemIndex(4));
            repo.ResultsAnalysis.MeasurementsTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(5));
            Delay.Duration(10000, false);
            
            UpdatePad("A1 1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.CalculateBttn' at Center.", repo.ResultsAnalysis.CalculateBttnInfo, new RecordItemIndex(7));
            repo.ResultsAnalysis.CalculateBttn.Click();
            Delay.Milliseconds(200);
            
            WaitForCalculation();
            Delay.Milliseconds(0);
            
            SavingResults();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.HomeListItem' at Center.", repo.ResultsAnalysis.HomeListItemInfo, new RecordItemIndex(10));
            repo.ResultsAnalysis.HomeListItem.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.ExportButton' at Center.", repo.ResultsAnalysis.ExportButtonInfo, new RecordItemIndex(11));
            repo.ResultsAnalysis.ExportButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(12));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportWizard.Complete.CustomXML' at Center.", repo.ExportWizard.Complete.CustomXMLInfo, new RecordItemIndex(13));
            repo.ExportWizard.Complete.CustomXML.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportWizard.Next' at Center.", repo.ExportWizard.NextInfo, new RecordItemIndex(14));
            repo.ExportWizard.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(15));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportWizard.XML' at Center.", repo.ExportWizard.XMLInfo, new RecordItemIndex(16));
            repo.ExportWizard.XML.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportWizard.Next' at Center.", repo.ExportWizard.NextInfo, new RecordItemIndex(17));
            repo.ExportWizard.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportWizard.Complete.DefaultRadioButton' at Center.", repo.ExportWizard.Complete.DefaultRadioButtonInfo, new RecordItemIndex(18));
            repo.ExportWizard.Complete.DefaultRadioButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportWizard.Next' at Center.", repo.ExportWizard.NextInfo, new RecordItemIndex(19));
            repo.ExportWizard.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'ExportWizard.Complete.ConfigureProtocolToAutoExport'.", repo.ExportWizard.Complete.ConfigureProtocolToAutoExportInfo, new RecordItemIndex(20));
            repo.ExportWizard.Complete.ConfigureProtocolToAutoExport.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'ExportWizard.Complete.OpenWithDefaultViewer'.", repo.ExportWizard.Complete.OpenWithDefaultViewerInfo, new RecordItemIndex(21));
            repo.ExportWizard.Complete.OpenWithDefaultViewer.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportWizard.Finish' at Center.", repo.ExportWizard.FinishInfo, new RecordItemIndex(22));
            repo.ExportWizard.Finish.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(23));
            Delay.Duration(5000, false);
            
            CompareExportedFile("Matrix Transform Kinetics 12x8 (1)");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
