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
    ///The ValidSingleLayoutTweak recording.
    /// </summary>
    [TestModule("d8f1edeb-981b-414f-aa5b-529d9d6c68cb", ModuleType.Recording, 1)]
    public partial class ValidSingleLayoutTweak : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static ValidSingleLayoutTweak instance = new ValidSingleLayoutTweak();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidSingleLayoutTweak()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidSingleLayoutTweak Instance
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

            StartLauncher();
            Delay.Milliseconds(0);
            
            TypeProtocolPath("12x8 Unknowns.assay-protocol");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysAnalysisLauncher.SomeContainer.IndeterminateMark2' at 6;3.", repo.MyAssaysAnalysisLauncher.SomeContainer.IndeterminateMark2Info, new RecordItemIndex(2));
            repo.MyAssaysAnalysisLauncher.SomeContainer.IndeterminateMark2.Click("6;3");
            Delay.Milliseconds(200);
            
            TypeTweakPath("valid_single_layout_protocol_tweaks.xml");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysAnalysisLauncher.Launch' at Center.", repo.MyAssaysAnalysisLauncher.LaunchInfo, new RecordItemIndex(4));
            repo.MyAssaysAnalysisLauncher.Launch.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(5));
            Delay.Duration(30000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.MicroplateTab' at Center.", repo.ProtocolAnalysisDesktop.MicroplateTabInfo, new RecordItemIndex(6));
            repo.ProtocolAnalysisDesktop.MicroplateTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(7));
            Delay.Duration(10000, false);
            
            CheckLayoutColors("2,2,5,5,5,5,1,1,1,1,1,1,2,2,5,5,5,5,1,1,1,1,1,1,2,2,5,5,5,5,1,1,1,1,1,1,2,2,5,5,5,5,1,1,1,1,1,1,2,2,5,5,5,5,1,1,1,1,1,1,2,2,5,5,5,5,1,1,1,1,1,1,2,2,5,5,5,5,1,1,1,1,1,1,2,2,5,5,5,5,1,1,1,1,1,1");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}