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
    ///The ValidationsValidationTables recording.
    /// </summary>
    [TestModule("bf0f7ef8-b3b6-49b3-a5eb-56a3f0182993", ModuleType.Recording, 1)]
    public partial class ValidationsValidationTables : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static ValidationsValidationTables instance = new ValidationsValidationTables();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidationsValidationTables()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidationsValidationTables Instance
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

            RunAnalysis("Matrix Transform Kinetics 12x8.assay-protocol");
            Delay.Milliseconds(0);
            
            OpenPropertyEditor();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Report' at Center.", repo.ProtocolAnalysisDesktop.ReportInfo, new RecordItemIndex(2));
            repo.ProtocolAnalysisDesktop.Report.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.AddElement' at Center.", repo.ProtocolAnalysisDesktop.AddElementInfo, new RecordItemIndex(3));
            repo.ProtocolAnalysisDesktop.AddElement.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopAnalysis.ValidationsTable' at Center.", repo.MyAssaysDesktopAnalysis.ValidationsTableInfo, new RecordItemIndex(4));
            repo.MyAssaysDesktopAnalysis.ValidationsTable.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Validation' at Center.", repo.ProtocolAnalysisDesktop.ValidationInfo, new RecordItemIndex(5));
            repo.ProtocolAnalysisDesktop.Validation.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.AddValidation' at Center.", repo.ProtocolAnalysisDesktop.AddValidationInfo, new RecordItemIndex(6));
            repo.ProtocolAnalysisDesktop.AddValidation.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.AddValidation' at Center.", repo.ProtocolAnalysisDesktop.AddValidationInfo, new RecordItemIndex(8));
            repo.ProtocolAnalysisDesktop.AddValidation.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Report' at Center.", repo.ProtocolAnalysisDesktop.ReportInfo, new RecordItemIndex(9));
            repo.ProtocolAnalysisDesktop.Report.Click();
            Delay.Milliseconds(200);
            
            // 2
            Report.Log(ReportLevel.Info, "Validation", "2\r\nValidating AttributeEqual (Visible='True') on item 'ProtocolAnalysisDesktop.ThirdReportItem'.", repo.ProtocolAnalysisDesktop.ThirdReportItemInfo, new RecordItemIndex(10));
            Validate.Attribute(repo.ProtocolAnalysisDesktop.ThirdReportItemInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            // 2
            Report.Log(ReportLevel.Info, "Validation", "2\r\nValidating AttributeEqual (Text='ValidationsTable2') on item 'ProtocolAnalysisDesktop.ThirdReportItem'.", repo.ProtocolAnalysisDesktop.ThirdReportItemInfo, new RecordItemIndex(11));
            Validate.Attribute(repo.ProtocolAnalysisDesktop.ThirdReportItemInfo, "Text", "ValidationsTable2");
            Delay.Milliseconds(0);
            
            SelectReportIem(ValueConverter.ArgumentFromString<int>("index", "1"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Remove' at Center.", repo.ProtocolAnalysisDesktop.RemoveInfo, new RecordItemIndex(13));
            repo.ProtocolAnalysisDesktop.Remove.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ProtocolAnalysisDesktop.ValidationsWarnig'.", repo.ProtocolAnalysisDesktop.ValidationsWarnigInfo, new RecordItemIndex(14));
            Validate.Attribute(repo.ProtocolAnalysisDesktop.ValidationsWarnigInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            try {
                CheckWarning(repo.ProtocolAnalysisDesktop.ValidationsWarnig, "The ValidationsTable1 report element contains validation content. To exclude the element from the report uncheck the Include option. Alternatively, you can delete the content from the Validation tab.");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            // Popup error message should appear
            Report.Log(ReportLevel.Info, "Section", "Popup error message should appear", new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Validation' at Center.", repo.ProtocolAnalysisDesktop.ValidationInfo, new RecordItemIndex(17));
            repo.ProtocolAnalysisDesktop.Validation.Click();
            Delay.Milliseconds(200);
            
            SelectValidationItem(ValueConverter.ArgumentFromString<int>("index", "0"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Report' at Center.", repo.ProtocolAnalysisDesktop.ReportInfo, new RecordItemIndex(19));
            repo.ProtocolAnalysisDesktop.Report.Click();
            Delay.Milliseconds(200);
            
            SelectReportIem(ValueConverter.ArgumentFromString<int>("index", "1"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Remove' at Center.", repo.ProtocolAnalysisDesktop.RemoveInfo, new RecordItemIndex(21));
            repo.ProtocolAnalysisDesktop.Remove.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.RemoveValidation' at Center.", repo.ProtocolAnalysisDesktop.RemoveValidationInfo, new RecordItemIndex(22));
            repo.ProtocolAnalysisDesktop.RemoveValidation.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.AddElement' at Center.", repo.ProtocolAnalysisDesktop.AddElementInfo, new RecordItemIndex(23));
            repo.ProtocolAnalysisDesktop.AddElement.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopAnalysis.ValidationsTable' at Center.", repo.MyAssaysDesktopAnalysis.ValidationsTableInfo, new RecordItemIndex(24));
            repo.MyAssaysDesktopAnalysis.ValidationsTable.Click();
            Delay.Milliseconds(200);
            
            // 1
            Report.Log(ReportLevel.Info, "Validation", "1\r\nValidating AttributeEqual (Text='ValidationsTable1') on item 'ProtocolAnalysisDesktop.ThirdReportItem'.", repo.ProtocolAnalysisDesktop.ThirdReportItemInfo, new RecordItemIndex(25));
            Validate.Attribute(repo.ProtocolAnalysisDesktop.ThirdReportItemInfo, "Text", "ValidationsTable1");
            Delay.Milliseconds(0);
            
            SelectReportIem(ValueConverter.ArgumentFromString<int>("index", "1"));
            Delay.Milliseconds(0);
            
            ChangeIdProperty("VT2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='VT2') on item 'ProtocolAnalysisDesktop.SecondReportItem'.", repo.ProtocolAnalysisDesktop.SecondReportItemInfo, new RecordItemIndex(28));
            Validate.Attribute(repo.ProtocolAnalysisDesktop.SecondReportItemInfo, "Text", "VT2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Validation' at Center.", repo.ProtocolAnalysisDesktop.ValidationInfo, new RecordItemIndex(29));
            repo.ProtocolAnalysisDesktop.Validation.Click();
            Delay.Milliseconds(200);
            
            CheckValidationItem(ValueConverter.ArgumentFromString<int>("index", "0"), "VT2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.TabPageXML' at Center.", repo.ProtocolAnalysisDesktop.TabPageXMLInfo, new RecordItemIndex(31));
            repo.ProtocolAnalysisDesktop.TabPageXML.Click();
            Delay.Milliseconds(200);
            
            ChangeRawElement("ValidationSameIDs.txt");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(33));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Apply' at Center.", repo.ProtocolAnalysisDesktop.ApplyInfo, new RecordItemIndex(34));
            repo.ProtocolAnalysisDesktop.Apply.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(35));
            Delay.Duration(1000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='ValidationsTable ID must be unique for each Validation configuration.') on item 'ProtocolAnalysisDesktop.ErrorText'.", repo.ProtocolAnalysisDesktop.ErrorTextInfo, new RecordItemIndex(36));
                Validate.Attribute(repo.ProtocolAnalysisDesktop.ErrorTextInfo, "Text", "ValidationsTable ID must be unique for each Validation configuration.", Validate.DefaultMessage, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(36)); }
            
            RevertChanges();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Apply' at Center.", repo.ProtocolAnalysisDesktop.ApplyInfo, new RecordItemIndex(38));
            repo.ProtocolAnalysisDesktop.Apply.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(39));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Caption='') on item 'ProtocolAnalysisDesktop.ErrorText'.", repo.ProtocolAnalysisDesktop.ErrorTextInfo, new RecordItemIndex(40));
            Validate.Attribute(repo.ProtocolAnalysisDesktop.ErrorTextInfo, "Caption", "");
            Delay.Milliseconds(0);
            
            ChangeRawElement("ValidationSameIDs2.txt");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(42));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Apply' at Center.", repo.ProtocolAnalysisDesktop.ApplyInfo, new RecordItemIndex(43));
            repo.ProtocolAnalysisDesktop.Apply.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(44));
            Delay.Duration(1000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='ValidationsTable ID must be unique for each Validation configuration.') on item 'ProtocolAnalysisDesktop.ErrorText'.", repo.ProtocolAnalysisDesktop.ErrorTextInfo, new RecordItemIndex(45));
                Validate.Attribute(repo.ProtocolAnalysisDesktop.ErrorTextInfo, "Text", "ValidationsTable ID must be unique for each Validation configuration.", Validate.DefaultMessage, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(45)); }
            
            RevertChanges();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Apply' at Center.", repo.ProtocolAnalysisDesktop.ApplyInfo, new RecordItemIndex(47));
            repo.ProtocolAnalysisDesktop.Apply.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(48));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Caption='') on item 'ProtocolAnalysisDesktop.ErrorText'.", repo.ProtocolAnalysisDesktop.ErrorTextInfo, new RecordItemIndex(49));
            Validate.Attribute(repo.ProtocolAnalysisDesktop.ErrorTextInfo, "Caption", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Properties' at Center.", repo.ProtocolAnalysisDesktop.PropertiesInfo, new RecordItemIndex(50));
            repo.ProtocolAnalysisDesktop.Properties.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
