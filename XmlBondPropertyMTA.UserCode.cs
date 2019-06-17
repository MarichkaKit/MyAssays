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
    public partial class XmlBondPropertyMTA
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void selectTransform(int num)
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.Transforms1' at Center.");
            repo.ProtocolAnalysisDesktop.Transforms1.Children[num].Click();
        }

        public void inputText(Adapter adapter, string imputStr)
        {
        	adapter.Click();
        	Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'TemplateDocx'.");
            Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}");
        	Keyboard.Press(imputStr + "{Return}");
        }

        public void checkLabelSummury(string expectedStr)
        {
        	var labelingProperty = repo.ProtocolAnalysisDesktop.LabelingProperty.Children[0].Children[2].Element.GetAttributeValueText("Text");
        	Validate.AreEqual(labelingProperty, expectedStr, "Summary should be 'Label1, Label'");
        }

        public void selectReportIem(int index)
        {
        	repo.ProtocolAnalysisDesktop.ReportsList.Children[index].Click();
        }

        public void checkXmlChanges(string expectedXml)
        {
        	string pathNewXML = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), String.Format(@"ExpectedRunDetails\MatrixTransform\{0}", expectedXml));
        	string expected = File.ReadAllText(pathNewXML).Replace("UNICODE", "\u00b2");
        	var xmlText = repo.ProtocolAnalysisDesktop.xmlText.Element.GetAttributeValueText("XmlText");
        	Report.Info("Actual:\r\n" + xmlText);
        	Report.Info("Expected:\r\n" + expected);
        	if(expected.Replace("BIT_NUM", "16").Equals(xmlText) || expected.Replace("BIT_NUM", "8").Equals(xmlText))
        		Report.Success(String.Format("Changes made on {0} Tab are correct.", expectedXml.Substring(0, expectedXml.Length-4)));
        	else
        		Report.Failure(String.Format("Changes made on {0} Tab are noy correct.", expectedXml.Substring(0, expectedXml.Length-4)));
        }

        public void OpenPropertyEditor()
        {
        	OpenProperties.OpenPropertiesInProtocolAnalysis();
        }

    }
}