/*
 * Created by Ranorex
 * User: admin
 * Date: 6/28/2016
 * Time: 2:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using Microsoft.Win32;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using WinForms = System.Windows.Forms;

namespace MyAssays.Wizard.RanorexTests
{
    /// <summary>
    /// Description of AddUseAnalysisControlsToRegistry.
    /// </summary>
    [TestModule("939748E0-3C13-4A63-95BE-4B76D0BA6794", ModuleType.UserCode, 1)]
    public class AddUseAnalysisControlsToRegistry : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddUseAnalysisControlsToRegistry()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
           RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\MyAssays\MyAssays Desktop",true);
       
           key.SetValue("UseAnalysisControls", "1", RegistryValueKind.DWord);
        }
    }
}
