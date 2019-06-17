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
    ///The UsingIScriptFromProtocol recording.
    /// </summary>
    [TestModule("2ca1eb58-7ce9-4bde-b6b4-be1ca1686f57", ModuleType.Recording, 1)]
    public partial class UsingIScriptFromProtocol : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static UsingIScriptFromProtocol instance = new UsingIScriptFromProtocol();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UsingIScriptFromProtocol()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UsingIScriptFromProtocol Instance
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

            Prepare();
            Delay.Milliseconds(0);
            
            renameIScriptFolder(ValueConverter.ArgumentFromString<bool>("invert", "False"));
            Delay.Milliseconds(0);
            
            CommandLineImport("ELISA Absorbance 405nm (1).assay-protocol", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(3));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'ELISA Absorbance 405nm (1) *') on item 'ProtocolAnalysisDesktop.Rectangle'.", repo.ProtocolAnalysisDesktop.RectangleInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.ProtocolAnalysisDesktop.RectangleInfo, "Text", new Regex(Regex.Escape("ELISA Absorbance 405nm (1) *")));
            Delay.Milliseconds(0);
            
            try {
                renameIScriptFolder(ValueConverter.ArgumentFromString<bool>("invert", "True"));
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            KillApp("MyAssays.Desktop.Analysis");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
