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
    ///The AssayDataFolderRootHyperlink recording.
    /// </summary>
    [TestModule("27c090f9-66c1-49d2-8849-2b2b89a68cbe", ModuleType.Recording, 1)]
    public partial class AssayDataFolderRootHyperlink : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static AssayDataFolderRootHyperlink instance = new AssayDataFolderRootHyperlink();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AssayDataFolderRootHyperlink()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AssayDataFolderRootHyperlink Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.Ribbon' at 13;32.", repo.MyAssaysExplorer.RibbonInfo, new RecordItemIndex(0));
            repo.MyAssaysExplorer.Ribbon.Click("13;32");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.BackStage.Data_backStage' at Center.", repo.MyAssaysExplorer.BackStage.Data_backStageInfo, new RecordItemIndex(1));
            repo.MyAssaysExplorer.BackStage.Data_backStage.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.BackStage.AssayDataRootFolderPath' at Center.", repo.MyAssaysExplorer.BackStage.AssayDataRootFolderPathInfo, new RecordItemIndex(2));
            repo.MyAssaysExplorer.BackStage.AssayDataRootFolderPath.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MyAssays'.", repo.MyAssays.SelfInfo, new RecordItemIndex(4));
            Validate.Exists(repo.MyAssays.SelfInfo);
            Delay.Milliseconds(0);
            
            try {
                IsHyperlink();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                CheckOpenedFolder();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssays.Close' at Center.", repo.MyAssays.CloseInfo, new RecordItemIndex(7));
            repo.MyAssays.Close.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
