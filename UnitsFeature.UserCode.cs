using System;
using System.IO;
using System.Linq;
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
    public partial class UnitsFeature
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void selectCreatedTransform(int num)
        {
        	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolAnalysisDesktop.TransformList item' at Center.");
            repo.ProtocolAnalysisDesktop.TransformsList.Children[num].Click();
            Delay.Seconds(1);
        }

        public void toWidescreen(int toLeft)
        {
        	if(repo.ProtocolAnalysisDesktop.PropertyEditorPanel.Element.ScreenRectangle.Width < (repo.ProtocolAnalysisDesktop.Self.ScreenRectangle.Width / 2))
        	{
//       start coordinates 	
        	var x = repo.ProtocolAnalysisDesktop.PropertyEditorPanel.Element.ScreenLocation.X - 5;
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

        public void CopyToClipboard(string addedPath)
        {
        	var pathToText = Path.Combine(HelperConstants.getExeAssemblyPath(), addedPath);
        	System.Windows.Clipboard.SetText(File.ReadAllText(pathToText));
        }

        public void CheckConcentrations(string expectedValues)
        {
        	var cells = (Dictionary<int, List<Tuple<string, bool, Color>>>)repo.MyAssaysDesktopAnalysis.MultiplexConcentrationsEditor.Element.GetAttributeValue("PlexCells");
        	var cellsValues = ParamTableHelper.GetCellsStringUnitsValue(cells);
        	
        	var actualValues = "";
        	foreach(var cell in cellsValues)
        		actualValues += cell;
        
        	Report.Info(actualValues);
        	Validate.AreEqual(actualValues, expectedValues, "Plex values are as expected.");
        }
        
        public void CheckPlexIsEditanble()
        {
        	var cells = (Dictionary<int, List<Tuple<string, bool, Color>>>)repo.MyAssaysDesktopAnalysis.MultiplexConcentrationsEditor.Element.GetAttributeValue("PlexCells");
        	var cellsIsReadOnly = ParamTableHelper.GetCellsIsReadOnlyProperty(cells);

        	try {
        		
        		foreach(var cell in cellsIsReadOnly)
        			Validate.IsFalse(cell, "Plex cell is editable.");
        	
        	} catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message); }
        		
        }

        public void CheckIsUnitsVisible()
        {
        	var cells = (Dictionary<int, List<Tuple<string, bool, Color>>>)repo.MyAssaysDesktopAnalysis.MultiplexConcentrationsEditor.Element.GetAttributeValue("PlexCells");
        	var units = GetCellsStringUnitsVisibleValue(cells);
        	
        	foreach(var unit in units)
        		Validate.AreEqual(unit.ToLower(), "false", "Unit is invisible.");
        }
        
        public List<string> GetCellsStringUnitsVisibleValue(Dictionary<int, List<Tuple<string, bool, Color>>> cells)
        {											   
			return (from t in cells.Values select t[2].Item2.ToString()).ToList();
        }

        public void SavingProtocol()
        {
        	SaveProtocol.Start();
        }

        public void ValidateUnitsInXML(string protocolName, string filename)
        {
        	ExtractProtocolHelper.DeleteTempFolder();
        	ExtractProtocolHelper.ExtractProtocolTo(null, null, protocolName);
        	
        	var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "temp");
        	
        	var actualXML = File.ReadAllText(Directory.GetFiles(path, "*.assay.xml").First()).Replace(" ", "").Replace("\r", "").Replace("\n", "");
        	Report.Info("Actual units in xml file:" + actualXML);
        	
        	var expectedXML = File.ReadAllText(Path.Combine(HelperConstants.getExeAssemblyPath(), @"ExpectedRunDetails\XMLs", filename)).Replace(" ", "")
        																																	.Replace("\r", "")
        																																	.Replace("\n", "");
        	Report.Info("Expected units in xml file:" + expectedXML);
        	
        	Validate.IsTrue(actualXML.Contains(expectedXML), "Actual *.assay.xml file contains expected units.");
        	
        	ExtractProtocolHelper.DeleteTempFolder();
        }

    }
}