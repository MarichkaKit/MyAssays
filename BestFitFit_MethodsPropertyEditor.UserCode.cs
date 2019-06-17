using System;
using System.IO;
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
    public partial class BestFitFit_MethodsPropertyEditor
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void selectTransform(int index)
        {
        	repo.ResultsAnalysis.TransformsList.Children[index].Click();
        }

        public void OpenPropertiesEditor()
        {
        	OpenProperties.OpenPropertiesInResultsAnalysis();
        }

        public void Set_Value_FitMethod_cb(string index)
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.FitMethod' at Center.", repo.ResultsAnalysis.FitMethodInfo);
            repo.ResultsAnalysis.FitMethod.Click();
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute SelectedItemIndex to '2' on item 'ResultsAnalysis.FitMethod_cb'.", repo.ResultsAnalysis.FitMethod_cbInfo);
            repo.ResultsAnalysis.FitMethod_cb.Element.SetAttributeValue("SelectedItemIndex", index);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsAnalysis.FitMethod' at Center.", repo.ResultsAnalysis.FitMethodInfo);
            repo.ResultsAnalysis.FitMethod.Click();
            repo.ResultsAnalysis.Self.Click();
        }

        public void UncheckAllItems(Adapter adapter)
        {
        	var checkboxes = adapter.Children;
        	foreach (var item in checkboxes)
        	{
        		if(item.Element.GetAttributeValueText("Checked").ToLower().Equals("true"))
        			item.Click();
        	}
        		
        }

        public void CheckDisableToCheckAtLeastLastCheckbox(Adapter adapter)
        {
        	int checkedItemsCount = 0;
        	var checkboxes = adapter.Children;
        	foreach (var item in checkboxes)
        	{
        		if(item.Element.GetAttributeValueText("Checked").ToLower().Equals("true"))
        			checkedItemsCount++;
        	}
        	
        	Report.Info("Checking that there must be at least 1 check-box ticked in each list-box");
        	Validate.AreEqual(checkedItemsCount, 1);
        }

        public void CheckAllItems(Adapter adapter)
        {
        	var checkboxes = adapter.Children;
        	foreach (var item in checkboxes)
        	{
        		if(item.Element.GetAttributeValueText("Checked").ToLower().Equals("false"))
        			item.Click();
        	}
        }

        public void CheckXML_Text(string expectedFile)
        {
        	var xmlText = repo.ResultsAnalysis.xmlText.Element.GetAttributeValueText("XmlText");
        	var expected = File.ReadAllText(Path.Combine(HelperConstants.getExeAssemblyPath(), @"ExpectedRunDetails\XMLs", expectedFile));
        	
        	Report.Info("The settings display/update the BestFitSearch WeightCSV attribute and the BestFitSearch Methods.");
        	Validate.IsTrue(xmlText.Contains(expected));
        }
    }
}