using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyAssays.Wizard.RanorexTests
{
    public partial class AfterImportMeasurementsMatrixNames
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        
        private string[] _expectedNames;
        
        private void Init()
        {
        	_expectedNames = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ExpectedRunDetails\MatrixTransform\Results\ImportedNames.txt"));
        }

        public void CheckMatrixNamesPad()
        {
        	string pathToExpected = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ExpectedRunDetails\MatrixTransform\ImportedMeasurementMatrixNamesFromRaw.txt");
        	var actualText = repo.ResultsAnalysis.PadValue.TextValue;

        	var expectedText = File.ReadAllText(pathToExpected);
        	
        	if(!actualText.Equals(expectedText))
        	{
	        	Report.Info("Actual pad value: " + actualText);
	        	Report.Info("Expected pad value: " + expectedText);
	        	Report.Failure("Check all matrix names in Measurements Pad.");
        	}
        	else Report.Success("Check all matrix names in Measurements Pad.");
        }

         public void CheckMatrixSelectionNames(Adapter adapter, int expCount, int loopCount)
        {
        	adapter.Click();
        	adapter.Click();
        	Delay.Seconds(1);
        	
        	var items = adapter.Children[3].Children[0].Children[0].Children;

        	if(items.Count == expCount) 
        	{
        		var actualItem = "";
        		string expectedName = "";
        		
        		for(int i = 0; i < loopCount; i++)
	        	{
        			actualItem = items[i].Element.GetAttributeValueText("Text");
        			expectedName = String.Format("Matrix {0}", (i+1));
        			if(!actualItem.Equals(expectedName))
        			{
        				Report.Info("Index: " + i);
        				Report.Failure(String.Format("Matrix combobox item with index: {0} does not equal to expected value. Actual: {1}, Expected: {2}",
        				                             i, actualItem, expectedName));
        			}
        			else
        				Report.Success(String.Format("Matrix combobox item with index: {0} equals to expected value. Actual: {1}, Expected: {2}",
        				                             i, actualItem, expectedName));       			
	        	}
        	} 
        	else
        		Report.Failure(String.Format("Matrix Selection combobox contains {0} items, expected: 26", items.Count));
        }
         
        public void CheckMatrixNamesAdapter(Ranorex.Adapter adapter, int expCount, int loopCount)
        {
        	adapter.Click();
        	adapter.Click();
        	Delay.Seconds(1);
        	
        	var items = adapter.Children[3].Children[0].Children[0].Children;

        	if(items.Count == expCount) 
        	{
        		var actualItem = "";
        		for(int i = 0; i < loopCount; i++)
	        	{
        			actualItem = items[i].Element.GetAttributeValueText("Text");
        			
        			if(!actualItem.Equals(_expectedNames[i]))
        			{
        				Report.Info("Index: " + i);
        				Report.Failure(String.Format("Matrix combobox item with index: {0} does not equal to expected value. Actual: {1}, Expected: {2}",
        				                             i, actualItem, _expectedNames[i]));
        			}
        			else
        				Report.Success(String.Format("Matrix combobox item with index: {0} equals to expected value. Actual: {1}, Expected: {2}",
        				                             i, actualItem, _expectedNames[i]));       			
	        	}
        	} 
        	else
        		Report.Failure(String.Format("Matrix Selection combobox contains {0} items, expected: 26", items.Count));
        }

        public void openProperties(Ranorex.Adapter adapter)
        {
        	if (!adapter.Visible)
        	{
        		repo.ResultsAnalysis.Property.Click();
        	}
        	else
        	{
        		Report.Screenshot();
        	}
        }

        public void CheckMatrixNamesMatrixTab()
        {        	
        	var rawItemsText = repo.ResultsAnalysis.RawItems;
        	
        	if(rawItemsText.Children.Count == 26) // 26 is an expected count of Matrix which are in pad area
        	{
        		var actualItem = "";
        		string expected = "";
        		
        		for(int i = 0; i < 26; i++)
	        	{
        			actualItem = rawItemsText.Children[i].Children[0].Children[0].Children[6].Children[0].Children[1].Children[0].Children[0].Element.GetAttributeValueText("Text");
        			expected = String.Format("{0}. {1}", (i+1), _expectedNames[i]);
        				
        			if(!actualItem.Equals(expected))
        			{
        				Report.Info("Index: " + i);
        				Report.Failure(String.Format("Matrix row item with index: {0} does not equal to expected value. Actual: {1}, Expected: {2}",
        				                             i, actualItem, expected));
        			}
        			else
        				Report.Success(String.Format("Matrix row item with index: {0} equals to expected value. Actual: {1}, Expected: {2}",
        				                             i, actualItem, expected));       			
	        	}
        	} 
        	else
        		Report.Failure(String.Format("There are Matrix rows on Matrices tab {0} items, expected: 26", rawItemsText.Children.Count));
        }

        public void CleanHelper()
        {
        	KillExcel.Start();
        	CleanDataHelper.DeleteReports();
        	Delay.Seconds(1);
        }

        public void WaitCalculation()
        {
        	Report.Log(ReportLevel.Info, "Delay", String.Format("Waiting for {0}s + 10.", HelperConstants.WAIT_CALCULATION));
        	Delay.Seconds(HelperConstants.WAIT_CALCULATION + 10);
        }

        public void CheckMatrixNamesXLSX()
        {
        	string pathToReport = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MyAssays\Reports");
        	string[] reports = Directory.GetFiles(pathToReport, "*.xlsx");
        	
//        	try{
        		var cellsActual = GetCells();
        		string pathToExpectedReport = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ExpectedRunDetails\MatrixTransform\Results\MatrixNamesInXLSX.txt");
	        	
	        	string cellsActualS = "";
	        	foreach(string cell in cellsActual)
	        		cellsActualS += cell;
	        	
	        	string cellsExpS = File.ReadAllText(pathToExpectedReport);
	        	
	        	Report.Info("cellsActual: " + cellsActualS);
	        	Report.Info("cellsExpected: " + cellsExpS);
	        	
	        	Validate.AreEqual(cellsActualS, cellsExpS, "Names are in column of generated table reports.");
	        	
//        	} catch(RanorexException e){        	
//        		Report.Screenshot();
//        		Report.Failure(e.StackTrace);
//        	}
        }
        
        private List<string> GetCells()
        {
        	var rows = repo.ExcelReport.SomeTable.Rows;
        	List<string> cellsValue = new List<string>();
        	for (int i=0; i < 1; i++)
        	{
        		var cells = rows[i].Cells;
        		for (int j = 2; j < cells.Count; j++)
        			cellsValue.Add(cells[j].Text);
        	}
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExcelReport.Close' at 12;12.", repo.ExcelReport.CloseInfo);
			if(repo.ExcelReport.CloseMSOfficeRusInfo.Exists() && repo.ExcelReport.CloseMSOfficeRus.Visible)
        		repo.ExcelReport.CloseMSOfficeRus.Click();
        	if(repo.ExcelReport.CloseInfo.Exists() && repo.ExcelReport.Close.Visible)
        		repo.ExcelReport.Close.Click();
        	Delay.Seconds(1);
        	return cellsValue;
        }

    }
}