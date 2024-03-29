﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using System.IO;
using System.Reflection;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyAssays.Wizard.RanorexTests
{
    public partial class VerifyIncompatibleImportIsDetected
    {
        private string _inputsPath;
        private string _myAssaysPath;
        
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            _myAssaysPath = StartAnalysisHelper.MadFolderPath;
        	_inputsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Inputs", "Kaleido");
        }

        public void checkGridPreview()
        {
        	var cellsControl = repo.NewProtocolWizard.GridPreview;
        	 var cells = (List<Tuple<object, Color, int, int, String, bool>>)cellsControl.Element.GetAttributeValue("Cells");  
        	 var values = GridInteractionHelper.GetCellsValue(cells);
	         
	         Validate.IsTrue(values.Count > 0, "Grid data is as imported.");
        }

        public void selectMicroplate(int index)
        {
        	repo.NewProtocolWizard.MicroplateList.Children[index].Click();
        }

        public void checkImportedData(Ranorex.Adapter adapter, string expFile)
        {
        	string actualPad = adapter.As<Ranorex.Text>().TextValue.Replace(" ", "").Replace("\r\n", "");
        	string pathToExpect = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ExpectedRunDetails\Measurements", expFile);
        	string expectedPad = File.ReadAllText(pathToExpect).Replace(" ", "").Replace("\r\n", "");
        	Report.Info("Actual pad Value:\r\n" + actualPad);
        	
        	if(actualPad.Equals(expectedPad))
        	{
        		Report.Info("Expected pad Value:\r\n" + expectedPad);
        		Report.Success("Data is as imported into Measurements section.");
        	}
        	else if(actualPad.Equals(expectedPad.Replace(".0000", "")))
        	{
        		Report.Info("Expected pad Value:\r\n" + expectedPad.Replace(".0000", ""));
        		Report.Success("Data is as imported into Measurements section.");
        	}
        	else 
        	{
        		Report.Info("Expected pad Value:\r\n" + expectedPad);
        		Report.Failure("Data is not as imported into Measurements section.");
        	}
        }

        public void EnterPathToFile(string fileName)
        {
        	repo.NewProtocolWizard.FieldForOneFile.Click();
        	Keyboard.Press(Path.Combine(_inputsPath ,fileName));
        }

        public void StartLauncher()
        {
        	Report.Log(ReportLevel.Info, "Application", String.Format("Run application '{0}\\MyAssays.Desktop.Analysis.Launcher.exe' with arguments '' in normal mode.", _myAssaysPath));
            Host.Local.RunApplication(_myAssaysPath + "\\MyAssays.Desktop.Analysis.Launcher.exe", "", _myAssaysPath, false);
        }

        public void TypeProtocolPath(string protocolName)
        {
        	var protocolPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyAssays", "Protocols", protocolName);
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysAnalysisLauncher.SomeElement' at 67;7.", repo.MyAssaysAnalysisLauncher.ProtocolPathInputInfo);
            repo.MyAssaysAnalysisLauncher.ProtocolPathInput.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", String.Format("Type protocol path: {0}", protocolPath));
            Keyboard.Press(protocolPath);
        }

        public void TypeMeasurementsPath(string fileName)
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysAnalysisLauncher.SomeElement' at 70;10.", repo.MyAssaysAnalysisLauncher.MeasurementsInputInfo);
            repo.MyAssaysAnalysisLauncher.MeasurementsInput.Click("70;10");
            
            Report.Log(ReportLevel.Info, String.Format("Type path of {0}", fileName));
            Keyboard.Press(Path.Combine(_inputsPath ,fileName));
        }

        public void CheckSAAMMessage()
        {
        	var maessage = repo.ProtocolAnalysisDesktop.SaamContainer.Children[3].Children[0].Element.GetAttributeValueText("Text");
        
        	var expectedText = "Measurements import operation failed. The import method does not support the given protocol's measurements";
        	Validate.AreEqual(maessage, expectedText, String.Format("Validate SAAM error contains text {0}", expectedText));	
        }

        public void ValidateSAAMAppeared()
        {
        	Validate.IsTrue(repo.ProtocolAnalysisDesktop.SaamContainerInfo.Exists() && 
        	                repo.ProtocolAnalysisDesktop.SaamContainer.Visible,
        	                "Validate SAAM appeared");
        }

        public void DeleteProtocols()
        {
        	CleanDataHelper.DeleteProtocols();
        }

    }
}