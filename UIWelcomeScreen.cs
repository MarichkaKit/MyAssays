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
    ///The UIWelcomeScreen recording.
    /// </summary>
    [TestModule("9eae4701-9f7d-41b8-a2ca-c8014ff31728", ModuleType.Recording, 1)]
    public partial class UIWelcomeScreen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssays_Wizard_RanorexTestsRepository repository.
        /// </summary>
        public static MyAssays_Wizard_RanorexTestsRepository repo = MyAssays_Wizard_RanorexTestsRepository.Instance;

        static UIWelcomeScreen instance = new UIWelcomeScreen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UIWelcomeScreen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UIWelcomeScreen Instance
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

            // Discover Section test
            Report.Log(ReportLevel.Info, "Section", "Discover Section test", new RecordItemIndex(0));
            
            checkSectionTitle(repo.MyAssaysExplorer.DiscoverSection, ValueConverter.ArgumentFromString<int>("index", "0"), "Discover MyAssays Desktop");
            Delay.Milliseconds(0);
            
            checkSectionTitle(repo.MyAssaysExplorer.DiscoverSection, ValueConverter.ArgumentFromString<int>("index", "1"), "You can find the latest information about MyAssays Desktop here:");
            Delay.Milliseconds(0);
            
            // later index can change cos next build will remove one link
            checkSectionContent(repo.MyAssaysExplorer.DiscoverSection, ValueConverter.ArgumentFromString<int>("index", "2"), "MyAssays Desktop Home Page");
            Delay.Milliseconds(0);
            
            checkURL(repo.MyAssaysExplorer.DiscoverSection, ValueConverter.ArgumentFromString<int>("index", "2"), "http://www.myassays.com/myassays-desktop.html");
            Delay.Milliseconds(0);
            
            checkSectionContent(repo.MyAssaysExplorer.DiscoverSection, ValueConverter.ArgumentFromString<int>("index", "3"), "What’s New in MyAssays Desktop?");
            Delay.Milliseconds(0);
            
            checkURL(repo.MyAssaysExplorer.DiscoverSection, ValueConverter.ArgumentFromString<int>("index", "3"), "http://www.myassays.com/myassays-desktop-whats-new.html");
            Delay.Milliseconds(0);
            
            // Product videos section test
            Report.Log(ReportLevel.Info, "Section", "Product videos section test", new RecordItemIndex(7));
            
            checkSectionTitle(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "0"), "Product Videos");
            Delay.Milliseconds(0);
            
            checkSectionTitle(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "1"), "We have lots of great content to help you get started:");
            Delay.Milliseconds(0);
            
            checkSectionContent(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "2"), "MyAssays Desktop Quick Start");
            Delay.Milliseconds(0);
            
            checkURL(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "2"), "http://www.myassays.com/myassays-desktop-quick-start.video");
            Delay.Milliseconds(0);
            
            checkSectionContent(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "3"), "MyAssays Desktop Fundamentals");
            Delay.Milliseconds(0);
            
            checkURL(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "3"), "http://www.myassays.com/myassays-desktop-fundamentals.video");
            Delay.Milliseconds(0);
            
            checkSectionContent(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "4"), "ELISA Data Analysis");
            Delay.Milliseconds(0);
            
            checkURL(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "4"), "http://www.myassays.com/elisa-data-analysis-with-myassays-desktop.video");
            Delay.Milliseconds(0);
            
            checkSectionContent(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "5"), "Excluding Outliers (Flagging)");
            Delay.Milliseconds(0);
            
            checkURL(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "5"), "https://www.myassays.com/myassays-desktop-flagging-outliers.video");
            Delay.Milliseconds(0);
            
            checkSectionContent(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "6"), "Download and Use Preconfigured Protocols from MyAssays.com");
            Delay.Milliseconds(0);
            
            checkURL(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "6"), "http://www.myassays.com/download-and-use-protocols-from-myassays.video");
            Delay.Milliseconds(0);
            
            checkSectionContent(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "7"), "Automate Your Workflow with Folder Poll");
            Delay.Milliseconds(0);
            
            checkURL(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "7"), "http://www.myassays.com/folder-poll-with-myassays-desktop.video");
            Delay.Milliseconds(0);
            
            checkSectionContent(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "8"), "MyAssays Desktop Report Templates");
            Delay.Milliseconds(0);
            
            checkURL(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "8"), "http://www.myassays.com/myassays-desktop-report-templates.video");
            Delay.Milliseconds(0);
            
            checkSectionContent(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "9"), "Inter-Assay Quality Control");
            Delay.Milliseconds(0);
            
            checkURL(repo.MyAssaysExplorer.ProductVideos, ValueConverter.ArgumentFromString<int>("index", "9"), "https://www.myassays.com/myassays-desktop-inter-assay-quality-control.video");
            Delay.Milliseconds(0);
            
            // Support section test
            Report.Log(ReportLevel.Info, "Section", "Support section test", new RecordItemIndex(26));
            
            checkSectionTitle(repo.MyAssaysExplorer.SupportSection, ValueConverter.ArgumentFromString<int>("index", "0"), "Support");
            Delay.Milliseconds(0);
            
            // later index can change cos next build will remove one link
            checkSectionContent(repo.MyAssaysExplorer.SupportSection, ValueConverter.ArgumentFromString<int>("index", "1"), "Contacting Support");
            Delay.Milliseconds(0);
            
            checkURL(repo.MyAssaysExplorer.SupportSection, ValueConverter.ArgumentFromString<int>("index", "1"), "http://www.myassays.com/contact.aspx");
            Delay.Milliseconds(0);
            
            checkSectionContent(repo.MyAssaysExplorer.SupportSection, ValueConverter.ArgumentFromString<int>("index", "2"), "Request an Assay Protocol");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
