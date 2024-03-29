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
using System.Xml;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyAssays.Wizard.RanorexTests
{
    public partial class UnknownConcentrations
    {
    	private string _myAssaysPath;
    	Dictionary<System.Windows.Point,Tuple<System.Windows.Point,Boolean>> points;
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            _myAssaysPath = StartAnalysisHelper.MadFolderPath;
        }

        public void CheckGoodnessMeasure()
        {
        	string reportPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"temp\1");
        	string[] reports = Directory.GetFiles(reportPath, "*.analysiscontrol.xml");
        	
        	 XmlDocument doc = new XmlDocument();
        	 doc.LoadXml(File.ReadAllText(reports[0]));
		
		     XmlElement root = doc.DocumentElement;
		     
		     //first tab 
		     var node = root.SelectSingleNode("//GroupTable[@Id='DescriptionTransformContent4GoodnessTable1']/Row[1]/Col[2]");
		     Validate.AreEqual(node.InnerText, "1", "Check R²");
        }

        public void CheckReportConcentrations()
        {
        	string reportPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"temp\1");
        	string[] reports = Directory.GetFiles(reportPath, "*.analysiscontrol.xml");
        	
        	 XmlDocument doc = new XmlDocument();
        	 doc.LoadXml(File.ReadAllText(reports[0]));
		
		     XmlElement root = doc.DocumentElement;
		     
		     //first tab
		     var node = root.SelectSingleNode("//GroupTable[@Id='DescriptionTransformContent3CoefficientTable1']/Row[1]/Col[2]");
		     Validate.AreEqual(node.InnerText, "0.333369", "Check a");  
 
		     node = root.SelectSingleNode("//GroupTable[@Id='DescriptionTransformContent3CoefficientTable1']/Row[2]/Col[2]");
		     Validate.AreEqual(node.InnerText, "5.39086", "Check b");
		     
		     node = root.SelectSingleNode("//GroupTable[@Id='DescriptionTransformContent3CoefficientTable1']/Row[3]/Col[2]");
		     Validate.AreEqual(node.InnerText, "0.468582", "Check c");
		     
		     node = root.SelectSingleNode("//GroupTable[@Id='DescriptionTransformContent3CoefficientTable1']/Row[4]/Col[2]");
		     Validate.AreEqual(node.InnerText, "1.11694", "Check d");
        }

        public void ExtractProtocol(string resultFileName)
        {
        	var reportPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyAssays\\Results\\");
        	ExtractProtocolHelper.DeleteTempFolder();
        	ExtractProtocolHelper.ExtractResultsTo(null, null, Directory.GetFiles(reportPath, "*.assay-results")[0]);
        }
        
        public void InitializeFlaggablePointsDictionary()
        {
        	points = ((Dictionary<System.Windows.Point,Tuple<System.Windows.Point,Boolean>>)repo.ResultsAnalysis.ChartTopPanel.SelectedTab.Find<Ranorex.WpfElement>("./container[@type='AnalysisControl']")[0].Element.GetAttributeValue("FlaggablePoints"));			
        }
        
        public void ValidatePointExistOnChart(double pointX, double pointY)
        {
        	foreach(var key in points.Keys)
        	{
        		if(Math.Abs(key.X - pointX) < 0.0000001 && Math.Abs(key.Y - pointY) < 0.0000001)
        		{
        			Report.Log(ReportLevel.Info, "Info", "Point exists");
        			return;
        		}       			
        	}
        	
        	Report.Failure(String.Format("Point ({0};{1}) does not exist on the chart", pointX, pointY));
        }

        public void ValidateSAAMsDoNotExist()
        {
        	Validate.AreEqual(repo.ResultsAnalysis.SaamsListBox1.Self.Find<Ranorex.WpfElement>(".//listitem").Count,0, "Validate SAAMs did not appear");
        }

        public void waitForCalculation()
        {
        	HelperConstants.waitForCalculation();
        }

        public void CheckConcentrations()
        {
        	var cells = (Dictionary<int, List<Tuple<string, bool, Color>>>)repo.MyAssaysDesktopAnalysis.SeriesTableEditor.Element.GetAttributeValue("Cells");
        	
        	var cellsValues = ParamTableHelper.GetCellsStringValue(cells);
        	
        	var startValue = 0.125;
        	
        	foreach(var currentValue in cellsValues)
        	{
        		var expectedValue = startValue.ToString();
        		if(decimalSeparator.Equals(","))
        			expectedValue = expectedValue.Replace(".", ",");
        		else
        			expectedValue = expectedValue.Replace(",", ".");

        		Validate.AreEqual(currentValue, expectedValue, String.Format("Validate concentration value is {0}. Actual: {1}", expectedValue,  currentValue));
        		startValue = startValue * 2;
        	}
        }

        public void CheckConcentrationsInDescription()
        {
        	var expectedText = "(0,125;0,25;0,5;1)";
        	if(decimalSeparator.Equals("."))
        		expectedText = expectedText.Replace(",", ".").Replace(";", ",");
        	Validate.IsTrue(repo.ProtocolAnalysisDesktop.TransformIndex1Description.TextValue.Contains(expectedText), String.Format("Validate description contains text {0}", expectedText));
        }

        public void selectTransform(int num)
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.TransformList item' at Center.");
            repo.ProtocolAnalysisDesktop.Transforms1.Children[num].Click();
            Delay.Seconds(1);
        }

        public void toWidescreen(int toLeft)
        {
        	if(repo.ProtocolAnalysisDesktop.PropertyEditorPanel.Element.ScreenRectangle.Width < (repo.ProtocolAnalysisDesktop.Self.ScreenRectangle.Width / 2))
        	{
//       start coordinates 	
        	var x = repo.ProtocolAnalysisDesktop.PropertyEditorPanel.Element.ScreenLocation.X - 3;
			var y = repo.ProtocolAnalysisDesktop.PropertyEditorPanel.Element.ScreenLocation.Y + 30;
			
			Mouse.MoveTo(new Point(x, y));          			
        	Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
        	Delay.Seconds(1);
        	Mouse.MoveTo(new Point(x - toLeft, y), 2000);
        	Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
        	Delay.Seconds(1);
        	}
        }

        public void openProperties(Ranorex.Adapter adapter)
        {
        	if (!adapter.Visible)
        	{
        		repo.ProtocolAnalysisDesktop.Properties.Click();
        	}
        	else
        	{
        		Report.Screenshot();
        	}
        }

        public void PasteDataToPad(string fileName)
        {
        	var file = Path.Combine(HelperConstants.getExeAssemblyPath(), "Inputs", fileName);
        	
        	var fileContent = File.ReadAllText(file);
        	if(decimalSeparator.Equals("."))
        		fileContent = fileContent.Replace(",", ".");
        	
        	System.Windows.Clipboard.SetText(fileContent);
        	
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.TabPagePad.ClearButton' at 41;15.", repo.NewProtocolWizard.TabPagePad.ClearButtonInfo, new RecordItemIndex(33));
            repo.NewProtocolWizard.TabPagePad.ClearButton.Click("41;15");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.TabPagePad.SomeElement' at 86;52.", repo.NewProtocolWizard.TabPagePad.SomeElementInfo, new RecordItemIndex(34));
            repo.NewProtocolWizard.TabPagePad.SomeElement.Click("86;52");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.TabPagePad.PasteButton' at 44;13.", repo.NewProtocolWizard.TabPagePad.PasteButtonInfo, new RecordItemIndex(35));
            repo.NewProtocolWizard.TabPagePad.PasteButton.Click("44;13");
        }

        public void selectMicroplate(int index)
        {
        	repo.NewProtocolWizard.MicroplateList.Children[index].Click();
        }

        public void LaunchMyAssaysExplorer()
        {
        	Report.Log(ReportLevel.Info, "Application", String.Format("Run application '{0}\\MyAssays.Desktop.Explorer.exe' with arguments '' in normal mode.", _myAssaysPath));
            Host.Local.RunApplication(_myAssaysPath + "\\MyAssays.Desktop.Explorer.exe", "", _myAssaysPath, false);
        }

        public void DeleteResults()
        {
        	CleanDataHelper.DeleteResults();
        }

        public void CheckReportXMLByPattern(string fileName)
        {
        	var filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "TransformsTests", "ReportPatterns", fileName);

        	string reportPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"temp\1");
        	string[] reports = Directory.GetFiles(reportPath, "*.report.xml");
        	
        	var expected = File.ReadAllText(filePath).Replace("\n", String.Empty).Replace("\r", String.Empty);
        	var actual = File.ReadAllText(reports[0]).Replace(",", ".").Replace("\n", String.Empty).Replace("\r", String.Empty);
        	        	
        	Validate.IsTrue(actual.Contains(expected), "Validate report xml file");
        }

        public void ValidateStandardCurveFitTabExists()
        {
        	Validate.IsTrue(repo.ResultsAnalysis.StandardCurveFitTabInfo.Exists() && repo.ResultsAnalysis.StandardCurveFitTab.Visible, 
        	                "Validate Standard Curve Fit tab exists");
        }

        public void WaitForCalculation()
        {
        	HelperConstants.waitForCalculation();
        }

        public void TypeValidationExpression()
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.ValidationExpression'.", repo.ProtocolAnalysisDesktop.ValidationExpressionInfo, new RecordItemIndex(29));
            repo.ProtocolAnalysisDesktop.ValidationExpression.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", String.Format("Type expression: Standard1 * 2{0}01 < 0{1}01", decimalSeparator, decimalSeparator));
            Keyboard.Press(String.Format("Standard1 * 2{0}01 < 0{1}01", decimalSeparator, decimalSeparator));
        }

        public void TypeEvaluationExpression()
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.MatrixExpression' at 67;10.", repo.ProtocolAnalysisDesktop.MatrixExpressionInfo, new RecordItemIndex(8));
            repo.ProtocolAnalysisDesktop.EvaluationExpressionInput.Click("5;10");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", String.Format("Type expression: Standard1 * 2{0}01", decimalSeparator));
            Keyboard.Press(String.Format("Standard1 * 2{0}01", decimalSeparator));
        }

        public void AddLabel(string LabelName)
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.LabelEditor' at 37;1.", repo.ProtocolAnalysisDesktop.LabelEditorInfo, new RecordItemIndex(7));
            repo.ProtocolAnalysisDesktop.LabelEditor.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopAnalysis.AddButton' at 48;10.", repo.MyAssaysDesktopAnalysis.AddButtonInfo, new RecordItemIndex(8));
            repo.MyAssaysDesktopAnalysis.AddButton.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", String.Format("Type expression x > 1{0}9 * Standard1" ,decimalSeparator));
            Keyboard.Press(String.Format("x > 1{0}9 * Standard1", decimalSeparator));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysDesktopAnalysis.LabelInput' at 24;5.", repo.MyAssaysDesktopAnalysis.LabelInputInfo, new RecordItemIndex(10));
            repo.MyAssaysDesktopAnalysis.LabelInput.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.");
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", String.Format("Type label name: {0}",LabelName));
            Keyboard.Press(LabelName);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Calc' at 28;9.", repo.ProtocolAnalysisDesktop.CalcInfo, new RecordItemIndex(13));
             repo.ProtocolAnalysisDesktop.MyRawData.Click();
        }

        public void RunAnalysis(string protocolName)
        {
        	StartAnalysisHelper.Protocol = protocolName;
            StartAnalysisHelper.StartAnalysis();
            Delay.Seconds(HelperConstants.TIME_TO_OPEN_PROTOCOL);
        }

    }
}