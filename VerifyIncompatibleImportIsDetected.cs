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
    ///The VerifyIncompatibleImportIsDetected recording.
    /// </summary>
    [TestModule("5a5e6b49-3f12-4598-881e-a3668f8079c6", ModuleType.Recording, 1)]
    public partial class VerifyIncompatibleImportIsDetected : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static VerifyIncompatibleImportIsDetected instance = new VerifyIncompatibleImportIsDetected();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyIncompatibleImportIsDetected()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyIncompatibleImportIsDetected Instance
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

            DeleteProtocols();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.ProtocolTab' at Center.", repo.MyAssaysExplorer.ProtocolTabInfo, new RecordItemIndex(1));
            repo.MyAssaysExplorer.ProtocolTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.FolderPageNavigation.NewBttn' at Center.", repo.MyAssaysExplorer.FolderPageNavigation.NewBttnInfo, new RecordItemIndex(2));
            repo.MyAssaysExplorer.FolderPageNavigation.NewBttn.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.MyDataIsInAFileOrSpreadAcrossMu' at Center.", repo.NewProtocolWizard.ProtocolWizard.MyDataIsInAFileOrSpreadAcrossMuInfo, new RecordItemIndex(3));
            repo.NewProtocolWizard.ProtocolWizard.MyDataIsInAFileOrSpreadAcrossMu.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.Next' at Center.", repo.NewProtocolWizard.ProtocolWizard.NextInfo, new RecordItemIndex(4));
            repo.NewProtocolWizard.ProtocolWizard.Next.Click();
            Delay.Milliseconds(200);
            
            EnterPathToFile("Kaleido 20 8 Endpoint Matrices.xml");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.Next' at Center.", repo.NewProtocolWizard.ProtocolWizard.NextInfo, new RecordItemIndex(6));
            repo.NewProtocolWizard.ProtocolWizard.Next.Click();
            Delay.Milliseconds(0);
            
            try {
                checkImportedData(repo.NewProtocolWizard.PadValue, "ExpextedKaleido.txt");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.Next' at Center.", repo.NewProtocolWizard.ProtocolWizard.NextInfo, new RecordItemIndex(8));
            repo.NewProtocolWizard.ProtocolWizard.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(9));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.Next' at Center.", repo.NewProtocolWizard.ProtocolWizard.NextInfo, new RecordItemIndex(10));
            repo.NewProtocolWizard.ProtocolWizard.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(11));
            Delay.Duration(5000, false);
            
            try {
                selectMicroplate(ValueConverter.ArgumentFromString<int>("index", "0"));
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(12)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.Next' at Center.", repo.NewProtocolWizard.ProtocolWizard.NextInfo, new RecordItemIndex(13));
            repo.NewProtocolWizard.ProtocolWizard.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(14));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.Plate' at Center.", repo.NewProtocolWizard.ProtocolWizard.PlateInfo, new RecordItemIndex(15));
            repo.NewProtocolWizard.ProtocolWizard.Plate.Click();
            Delay.Milliseconds(200);
            
            try {
                checkGridPreview();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.Next' at Center.", repo.NewProtocolWizard.ProtocolWizard.NextInfo, new RecordItemIndex(17));
            repo.NewProtocolWizard.ProtocolWizard.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'NewProtocolWizard.ProtocolWizard.Description'.", repo.NewProtocolWizard.ProtocolWizard.DescriptionInfo, new RecordItemIndex(18));
            Validate.Attribute(repo.NewProtocolWizard.ProtocolWizard.DescriptionInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.Next' at Center.", repo.NewProtocolWizard.ProtocolWizard.NextInfo, new RecordItemIndex(19));
            repo.NewProtocolWizard.ProtocolWizard.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.IndeterminateMark' at Center.", repo.NewProtocolWizard.ProtocolWizard.IndeterminateMarkInfo, new RecordItemIndex(20));
            repo.NewProtocolWizard.ProtocolWizard.IndeterminateMark.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(21));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.Finish' at Center.", repo.NewProtocolWizard.ProtocolWizard.FinishInfo, new RecordItemIndex(22));
            repo.NewProtocolWizard.ProtocolWizard.Finish.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(23));
            Delay.Duration(10000, false);
            
            StartLauncher();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(25));
            Delay.Duration(10000, false);
            
            TypeProtocolPath("Kaleido 20 8 Endpoint Matrices (1).assay-protocol");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysAnalysisLauncher.ImportMeasurementsCheckbox' at Center.", repo.MyAssaysAnalysisLauncher.ImportMeasurementsCheckboxInfo, new RecordItemIndex(27));
            repo.MyAssaysAnalysisLauncher.ImportMeasurementsCheckbox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(28));
            Delay.Duration(3000, false);
            
            TypeMeasurementsPath("Kaleido 20 10 Endpoint Matrices.xml");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysAnalysisLauncher.LaunchButton' at Center.", repo.MyAssaysAnalysisLauncher.LaunchButtonInfo, new RecordItemIndex(30));
            repo.MyAssaysAnalysisLauncher.LaunchButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(31));
            Delay.Duration(30000, false);
            
            ValidateSAAMAppeared();
            Delay.Milliseconds(0);
            
            CheckSAAMMessage();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}