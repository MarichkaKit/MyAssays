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
    ///The ValidateRackSAMMNotDisplaying recording.
    /// </summary>
    [TestModule("777cd008-195d-4767-bad6-59fe1b4fd669", ModuleType.Recording, 1)]
    public partial class ValidateRackSAMMNotDisplaying : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static ValidateRackSAMMNotDisplaying instance = new ValidateRackSAMMNotDisplaying();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateRackSAMMNotDisplaying()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateRackSAMMNotDisplaying Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.MyDataIsInAFileOrSpreadAcrossMu' at Center.", repo.NewProtocolWizard.ProtocolWizard.MyDataIsInAFileOrSpreadAcrossMuInfo, new RecordItemIndex(0));
            repo.NewProtocolWizard.ProtocolWizard.MyDataIsInAFileOrSpreadAcrossMu.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.Next' at Center.", repo.NewProtocolWizard.ProtocolWizard.NextInfo, new RecordItemIndex(1));
            repo.NewProtocolWizard.ProtocolWizard.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.DataInOneFile' at Center.", repo.NewProtocolWizard.DataInOneFileInfo, new RecordItemIndex(2));
            repo.NewProtocolWizard.DataInOneFile.Click();
            Delay.Milliseconds(200);
            
            EnterFileToImport(repo.NewProtocolWizard.FieldForOneFile);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'NewProtocolWizard.AutomaticallyImportMeasurementData'.", repo.NewProtocolWizard.AutomaticallyImportMeasurementDataInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.NewProtocolWizard.AutomaticallyImportMeasurementDataInfo, "Checked", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ProtocolWizard.Next' at Center.", repo.NewProtocolWizard.ProtocolWizard.NextInfo, new RecordItemIndex(5));
            repo.NewProtocolWizard.ProtocolWizard.Next.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='False') on item 'NewProtocolWizard.ProtocolWizard.NotificationSAAMContainer'.", repo.NewProtocolWizard.ProtocolWizard.NotificationSAAMContainerInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.NewProtocolWizard.ProtocolWizard.NotificationSAAMContainerInfo, "Visible", "False");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'NewProtocolWizard.ProtocolWizard.NotificationSAAMContainer'.", repo.NewProtocolWizard.ProtocolWizard.NotificationSAAMContainerInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.NewProtocolWizard.ProtocolWizard.NotificationSAAMContainerInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.NewProtocolWizard.Self, false, new RecordItemIndex(9));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}