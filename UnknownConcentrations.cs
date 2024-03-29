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
    ///The UnknownConcentrations recording.
    /// </summary>
    [TestModule("5eb96b27-51bf-4543-ba0b-d93bdff182be", ModuleType.Recording, 1)]
    public partial class UnknownConcentrations : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static UnknownConcentrations instance = new UnknownConcentrations();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UnknownConcentrations()
        {
            decimalSeparator = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UnknownConcentrations Instance
        {
            get { return instance; }
        }

#region Variables

        string _decimalSeparator;

        /// <summary>
        /// Gets or sets the value of variable decimalSeparator.
        /// </summary>
        [TestVariable("76aa4085-96d4-4d6e-b6d1-254799b6bdc3")]
        public string decimalSeparator
        {
            get { return _decimalSeparator; }
            set { _decimalSeparator = value; }
        }

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

            DeleteResults();
            Delay.Milliseconds(0);
            
            RunAnalysis("PlateProtocolWith4Unknown.assay-protocol");
            Delay.Milliseconds(0);
            
            openProperties(repo.ProtocolAnalysisDesktop.Transforms);
            Delay.Milliseconds(0);
            
            toWidescreen(ValueConverter.ArgumentFromString<int>("toLeft", "400"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.ButtonAdd' at 29;11.", repo.ProtocolAnalysisDesktop.ButtonAddInfo, new RecordItemIndex(4));
            repo.ProtocolAnalysisDesktop.ButtonAdd.Click("29;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(5));
            Delay.Duration(500, false);
            
            selectTransform(ValueConverter.ArgumentFromString<int>("num", "14"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.CreateTransform' at 26;6.", repo.ProtocolAnalysisDesktop.CreateTransformInfo, new RecordItemIndex(7));
            repo.ProtocolAnalysisDesktop.CreateTransform.Click("26;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(8));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.StandardTypeDropdown' at Center.", repo.ProtocolAnalysisDesktop.StandardTypeDropdownInfo, new RecordItemIndex(9));
            repo.ProtocolAnalysisDesktop.StandardTypeDropdown.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopAnalysis.Unknown' at 37;5.", repo.MyAssaysDesktopAnalysis.UnknownInfo, new RecordItemIndex(10));
            repo.MyAssaysDesktopAnalysis.Unknown.Click("37;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(11));
            Delay.Duration(5000, false);
            
            CheckConcentrationsInDescription();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.ConcentrationsDropdown' at 55;9.", repo.ProtocolAnalysisDesktop.ConcentrationsDropdownInfo, new RecordItemIndex(13));
            repo.ProtocolAnalysisDesktop.ConcentrationsDropdown.Click("55;9");
            Delay.Milliseconds(200);
            
            CheckConcentrations();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.ConcentrationsDropdown' at 55;9.", repo.ProtocolAnalysisDesktop.ConcentrationsDropdownInfo, new RecordItemIndex(15));
            repo.ProtocolAnalysisDesktop.ConcentrationsDropdown.Click("55;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.CalculateButton' at Center.", repo.ProtocolAnalysisDesktop.CalculateButtonInfo, new RecordItemIndex(16));
            repo.ProtocolAnalysisDesktop.CalculateButton.Click();
            Delay.Milliseconds(200);
            
            WaitForCalculation();
            Delay.Milliseconds(0);
            
            WaitForCalculation();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ResultsAnalysis'.", repo.ResultsAnalysis.SelfInfo, new RecordItemIndex(19));
            Validate.Exists(repo.ResultsAnalysis.SelfInfo);
            Delay.Milliseconds(0);
            
            ValidateSAAMsDoNotExist();
            Delay.Milliseconds(0);
            
            ValidateStandardCurveFitTabExists();
            Delay.Milliseconds(0);
            
            ExtractProtocol("PlateProtocolWith4Unknown (1).assay-results");
            Delay.Milliseconds(0);
            
            CheckReportConcentrations();
            Delay.Milliseconds(0);
            
            CheckGoodnessMeasure();
            Delay.Milliseconds(0);
            
            CheckReportXMLByPattern("SCFPlateProtocolUnknownConcentrations.txt");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
