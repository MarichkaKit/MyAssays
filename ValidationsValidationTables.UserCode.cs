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
    public partial class ValidationsValidationTables
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

        public void SelectReportIem(int index)
        {
        	repo.ProtocolAnalysisDesktop.ReportsList.Children[index].Click();
        }
        
        public void SelectValidationItem(int index)
        {
        	repo.ProtocolAnalysisDesktop.ValidationsList.Children[index].Click();
        }
        
        public void ChangeIdProperty(string idStr)
        {
        	repo.ProtocolAnalysisDesktop.IdProperty.Click();
        	Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}'.");
            Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}");
        	Keyboard.Press(idStr + "{Return}");
			Delay.Seconds(1);
        }

        public void CheckValidationItem(int index, string expectedName)
        {
        	var actualName = repo.ProtocolAnalysisDesktop.ValidationsList.Children[index].Children[0].Children[1].Children[0].Element.GetAttributeValueText("Text");
        	Validate.AreEqual(actualName, expectedName, "Check changes (changed Id) on Validation Tab");
        }

        public void ChangeRawElement(string xml)
        {
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

        public void RevertChanges()
        {
        	repo.ProtocolAnalysisDesktop.xmlElement.Click();
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Zkey}{LControlKey up}'.");
            Keyboard.Press("{LControlKey down}{Zkey}{LControlKey up}");
            Delay.Seconds(1);
        }

        public void CheckWarning(Adapter adapter, string expectedStr)
        {
        	var message = adapter.Children;
        	string actualMessage = "";
        	
        	foreach(Unknown element in message  )
        	{
        		actualMessage += element.Element.GetAttributeValueText("Text");
//        		actualMessage += element.Element.GetAttributeValueText("NavigateUri");
        	}
        	Report.Info("Actual message: " + actualMessage);
        	Report.Info("Expected message: " + expectedStr);
        	Validate.AreEqual(actualMessage, expectedStr, "Message corresponds to expected. ");
        }

        public void OpenPropertyEditor()
        {
        	OpenProperties.OpenPropertiesInProtocolAnalysis();
        }
    }
}