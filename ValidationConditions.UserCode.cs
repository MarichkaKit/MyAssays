using System;
using System.IO;
using System.Linq;
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
    public partial class ValidationConditions
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void RunAnalysis(string protocolName)
        {
        	StartAnalysisHelper.Protocol = protocolName;
            StartAnalysisHelper.StartAnalysis();
            Delay.Seconds(HelperConstants.TIME_TO_OPEN_PROTOCOL);
        }

        public void selectValidationIem(int index)
        {
        	Report.Info("Select validation.");
        	repo.ProtocolAnalysisDesktop.ValidationsList.Children[index].Click();
        }

        public void checkCondition(int index, string expectedCondition)
        {
        	Report.Info("Check condition.");
        	var condition = repo.ProtocolAnalysisDesktop.ConditionsList.Children[index].Children[0].Children[1].Children[0].Element.GetAttributeValueText("Text");
        	Validate.AreEqual(condition, expectedCondition);
        }

        public void selectCondition(int index)
        {
        	Report.Info("Select condition.");
        	repo.ProtocolAnalysisDesktop.ConditionsList.Children[index].Click();
        }

        public void changeDescription(int index, string description)
        {
        	Report.Info("Change description.");
        	repo.ProtocolAnalysisDesktop.ConditionsList.Children[index].Children[0].Children[1].Children[0].Click();
        	Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}'.");
            Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}");
        	Keyboard.Press(description + "{Return}");
			Delay.Seconds(1);
        }

        public void changeTypes(int index, int typesCount)
        {
        	Report.Info("Change Types.");
        	
        	for(int i = 0; i < typesCount; i++)
        	{
        		repo.ProtocolAnalysisDesktop.TypesProperty.Click();
        	
        		if(i == index)
        		{
        			if(!repo.ProtocolAnalysisDesktop.TypesProperty.Children[0].Children[0].Children[1].Children[1].Children[i].Children[0].As<Ranorex.CheckBox>().Checked)
        			{
        				repo.ProtocolAnalysisDesktop.TypesProperty.Children[0].Children[0].Children[1].Children[1].Children[i].Children[0].As<Ranorex.CheckBox>().Click();
        			}
        		}   
        		else
        		{
        			if(repo.ProtocolAnalysisDesktop.TypesProperty.Children[0].Children[0].Children[1].Children[1].Children[i].Children[0].As<Ranorex.CheckBox>().Checked)
        				repo.ProtocolAnalysisDesktop.TypesProperty.Children[0].Children[0].Children[1].Children[1].Children[i].Children[0].Click();
        		}
        	}        	
        }

        public void changeMatrix(int indexToSet)
        {
        	Report.Info("Change matrix.");
        	repo.ProtocolAnalysisDesktop.ValidationMatrix.Click();
        	repo.ProtocolAnalysisDesktop.ValidationMatrix.Children[0].Children[3].Children[indexToSet].Click();
        }

        public void changeType(int expectedCount)
        {
        	Report.Info("Change type.");
        	repo.ProtocolAnalysisDesktop.TypeProperty.Click();	//steps are required for waiting when popup menu will add it's items
        	Delay.Seconds(1);        	
        	int actualCount = repo.ProtocolAnalysisDesktop.TypeProperty.Children[0].Children[0].Children[1].Children[1].Children.Count;
        	Validate.AreEqual(actualCount, expectedCount, "Property editor type should have 3 selections.");
        }

        public void changeName(string newName)
        {
        	Report.Info("Change name.");
        	repo.ProtocolAnalysisDesktop.Calc2Property.Click();
        	Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}'.");
            Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}");
        	Keyboard.Press(newName + "{Return}");
			Delay.Seconds(1);
        }

        public void checkMatrix(int index, string expectedStr)
        {
        	Report.Info("Check Matrix.");
        	var item = repo.ProtocolAnalysisDesktop.ValidationMatrixList.Children[index].Children[0].Children[1].Children[1].Children[0].Children[0].Children[1].Element.GetAttributeValueText("Text");
        	Validate.AreEqual(item, expectedStr, "Check change on Validation Tab.");
        }

        public void checkXmlChanges(string expectedXml)
        {
        	Report.Info("Check xml changes.");
        	string pathNewXML = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), String.Format(@"ExpectedRunDetails\MatrixTransform\{0}", expectedXml));
        	string expected = File.ReadAllText(pathNewXML);//BIT_NUM
        	var xmlText = repo.ProtocolAnalysisDesktop.xmlText.Element.GetAttributeValueText("XmlText");
        	Report.Info("Actual:\r\n" + xmlText);
        	Report.Info("Expected:\r\n" + expected);
        	
        	if(expected.Replace("BIT_NUM", "16").Equals(xmlText) || expected.Replace("BIT_NUM", "8").Equals(xmlText))
        		Report.Success("Changes made on Validation Tab are correct.");
        	else
        		Report.Failure("Changes made on Validation Tab are not correct.");
        }

        public void changeOutput(string output)
        {
        	Report.Info("Change output.");
        	repo.ProtocolAnalysisDesktop.Output.Click();
        	repo.ProtocolAnalysisDesktop.Output.TextValue = output;
        	Keyboard.Press("{Return}");
			Delay.Seconds(1);
        }

        public void changeType(string xml)
        {
        	Report.Info("Changing Type.");
        	string pathNewXML = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), String.Format(@"Inputs\MatrixTransform\{0}", xml));
        	Report.Log(ReportLevel.Info, "Clipboard", "Set file content to clipboard.");
            System.Windows.Forms.Clipboard.SetText(File.ReadAllText(pathNewXML));
        	
        	repo.ProtocolAnalysisDesktop.xmlElement.Click();
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}'.");
            Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Seconds(1);
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Vkey}{LControlKey up}'.");
            Keyboard.Press("{LControlKey down}{Vkey}{LControlKey up}");
            Delay.Seconds(1);
        }

        public void checkTypes(string indexes, int typesCount)
        {
        	Report.Info("Check types.");
        	var numbers = indexes.Split(',').Select(Int32.Parse).ToList();
        	
        	repo.ProtocolAnalysisDesktop.TypesProperty.Click();
        	for(int i = 0; i < typesCount; i++)
        	{
        		bool state = false;
        		var cb = repo.ProtocolAnalysisDesktop.TypesProperty.Children[0].Children[0].Children[1].Children[1].Children[i].Children[0].As<Ranorex.CheckBox>();
        		
        		foreach(int n in numbers)
        		{
        			if(i == n)
        				state = true;
        		}      		
        		
	        		if(state)
	        		{
	        			if(cb.Checked)
	        				Report.Success("Type was changed.");
	        			else
	        				Report.Failure("Type was not changed");
	        		}   
	        		else
	        		{
	        			if(cb.Checked)
	        				Report.Failure("Type was changed. It should not.");
	        		}
        	}        	
        }

        public void toDeleteTransform(int index)
        {
        	Report.Info("Delete transform.");
        	repo.ProtocolAnalysisDesktop.TransformsList.Children[index].Click();
        	repo.ProtocolAnalysisDesktop.ButtonRemove.Click();
        	Delay.Seconds(1);
        }

        public void validateWarning(string expectedMssg)
        {
        	var warningMessage = repo.ProtocolAnalysisDesktop.WarningMessageTextBlock.Children;
        	string message = "";
        	
        	foreach(Ranorex.Unknown element in warningMessage)
        	{
        		message += element.Element.GetAttributeValueText("Text");
        	}
        		
        	Report.Info("Actual message: " + message);
        	Report.Info("Expected message: " + expectedMssg);
        	
        	Validate.AreEqual(message, expectedMssg, "Check warning message should appears.");

        }
        
        public void checkComboboxForItemCount(Adapter combobox, int expectedCount)
        {        	
        	Report.Info("Check Combobox for item count.");
        	combobox.Click();
        	combobox.Click();
        	Delay.Seconds(1);
        	Validate.AreEqual(combobox.Children[0].Children[3].Children.Count, expectedCount,
        	                  String.Format("Combobox should contain {0} item(s)", (expectedCount - 1))); // -1 due to popup menu has always contained one additional container
        }

        public void checkComboboxForType(Adapter adapter, int expectedCount, string expType)
        {
        	Report.Info("Check Combobox for type.");
        	adapter.Click();
        	adapter.Click();
        	Delay.Seconds(1);
        	Validate.AreEqual(adapter.Children[0].Children[0].Children[1].Children.Count, expectedCount,
        	                  String.Format("Combobox should contain {0} items", (expectedCount - 1))); // -1 due to popup menu has always contained one additional container
        	
        	Validate.AreEqual(adapter.Children[2].Children[1].Element.GetAttributeValueText("Text"), expType, String.Format("Type should have {0} selection", expType));
        }

        public void checkNAMatrix(int index, string expectedStr)
        {
        	Report.Info("Check NA Matrix");
        	var item = repo.ProtocolAnalysisDesktop.ValidationMatrixList.Children[index].Children[0].Children[1].Children[1].Children[1].Element.GetAttributeValueText("Text");
        	Validate.AreEqual(item, expectedStr, "Check change on Validation Tab.");
        }

        public void MoveScroll(string attribute)
        {
        	Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Value to '' on item 'ProtocolAnalysisDesktop.SomeContainer3'.", repo.ProtocolAnalysisDesktop.ValidationScrollHorisontalInfo);
        	repo.ProtocolAnalysisDesktop.ValidationScrollHorisontal.Element.SetAttributeValue("Value", repo.ProtocolAnalysisDesktop.ValidationScrollHorisontal.Element.GetAttributeValueText(attribute));
            Delay.Milliseconds(0);
            repo.ProtocolAnalysisDesktop.Validation.Click();

        }

        public void OpenPropertyEditor()
        {
        	OpenProperties.OpenPropertiesInProtocolAnalysis();
        }
    }
}