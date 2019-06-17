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
    public partial class ValidateTemplateSection
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void selectProtocol(string name)
        {
        	HelperSelectProtocolResult.SelectProtocolItem(name);
        	Delay.Seconds(10);
        }

        public void addProtocol(string fileName)
        {
        	HelperLoadFileToFolder.addToFolderProtocol(fileName, null, "Protocols", null);
        	Delay.Seconds(2);
        }

        public void cleanHelper()
        {
        	CleanDataHelper.DeleteProtocols();
        	CleanDataHelper.DeleteResults();
        	CleanDataHelper.DeleteCustomLayouts();
        	Delay.Seconds(2);
        }

        public void checkTemplateSection()
        {	
        	var templateSection = repo.ResultsAnalysis.ReportRibbonTab.TemplateSection;
        	if (templateSection.Children.Count == 3)
        	{
        		if(templateSection.Children[0].Visible && !templateSection.Children[1].Visible && !templateSection.Children[2].Visible)
        			Report.Success("Only available button is New Template in Template section.");
        		else Report.Error("Requirement buttons are not available in Template section.");
        	}
        	else
        		Report.Error("Template section does not contain a requirement count of buttons.");
        }

        public void checkTemplateButtons()
        {
        	if(repo.ResultsAnalysis.NewTemplate.Visible && repo.ResultsAnalysis.EditTemplate.Visible
        	   && repo.ResultsAnalysis.DeleteTemplate.Visible)
        		Report.Success("Edit Template and Delete Template buttons were added in Template section in Report ribbon.");
        	else Report.Error("Edit Template and Delete Template buttons were not added in Template section in Report ribbon.");
        }

        public void checkSaamMessage()
        {	
        	var someText = repo.ResultsAnalysis.Saam2;

        	var saamTextPart1 = someText.Children[0].Element.GetAttributeValueText("Text").Replace(" ", "");
        	var saamTextPart2 = someText.Children[1].Children[0].Element.GetAttributeValueText("Text").Replace(" ", "");
        	var saamTextPart3 = someText.Children[2].Element.GetAttributeValueText("Text").Replace(" ", "");
        	
        	if (saamTextPart1.Equals("Press") &&
        	    saamTextPart2.Equals("Calculate") &&
        	    saamTextPart3.Equals("togeneratetheresultsforthenewsettings."))
        	{
        		Report.Success("Saam Message corresponds to demand.");
        	}
        	else 
        	{
        		Report.Error("Saam Message does not correspond to demand.");
        	}
        }

        public void saamMessageDisappears()
        {
        	Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasItems='False') on item 'ResultsAnalysis.SaamsListBox'.", repo.ResultsAnalysis.SaamsListBoxInfo, new RecordItemIndex(30));
            Validate.Attribute(repo.ResultsAnalysis.SaamsListBoxInfo, "HasItems", "False");
            Delay.Milliseconds(100);            
        }

        public void KillApp(string appName)
        {
        	Report.Screenshot();
        	KillProcessHelper.KillProcess(appName);
        }

        public void checkTemplateDocs(string name)
        {
        	ExtractProtocolHelper.DeleteTempFolder();
        	ExtractProtocolHelper.ExtractResultsTo(null, null, name + " (1).assay-results");

        	string pathTo1Template = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"temp\1");
        	string innerPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"temp\inner");
        	ExtractProtocolHelper.ExtractProtocolTo(pathTo1Template, innerPath, name + ".assay-protocol");
        	string innerPathFull = Path.Combine(innerPath, "Template.docx");
        	       	
        	if(File.Exists(innerPathFull))
        		Report.Error("Template.docx file have not to exists in the Version 1.");
        	else Report.Success("Template.docx file does not exist in the Version 1.");       	
        	Delay.Seconds(2);
        	
        	ExtractProtocolHelper.DeleteTempFolder();
        	ExtractProtocolHelper.ExtractResultsTo(null, null, name + " (1).assay-results");
        	
        	string pathTo2Template = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"temp\2");
        	ExtractProtocolHelper.ExtractProtocolTo(pathTo2Template, innerPath, name + ".assay-protocol");
        	
        	if(!File.Exists(innerPathFull))
        		Report.Error("Template.docx file have to exists in the Version 2.");
        	else Report.Success("Template.docx file does exist in the Version 2.");       	
        	Delay.Seconds(2);
        	        	
        	ExtractProtocolHelper.DeleteTempFolder();
        }

        public void setFocusRerults(Adapter adapter)
        {
        	adapter.Focus();
        	Delay.Seconds(2);
        }

        public void checkNewTemplateSaam()
        {
        	var saamNew = repo.ResultsAnalysis.Saam1.Children[0].Element.GetAttributeValueText("Text").Replace(" ", "");
        	Report.Info(saamNew);
        	if (saamNew.Equals("AnewTemplate.docxfilehasbeencreatedandopenedforeditinginWord/WordPad.Modifythistemplateasrequiredandsavethechangestocontinue."))
        	{
        		Report.Success("Saam Message corresponds to demand. Template.docx is edited.");
        	}
        	else 
        	{
        		Report.Failure("Saam Message does not correspond to demand. Template.docx is edited.");
        	}
        }

        public void checkInfoSaam()
        {
        	var ifTemplate = repo.ResultsAnalysis.SaamsListBox1.ifTemplate.Children[0].Element.GetAttributeValueText("Text").Replace(" ", "");
			if (ifTemplate.Equals("IftheTemplateisopeninanotherapplicationitmaynotrefertothelatestversion.PleaseclosetheapplicationeditingtheTemplateandpressEditagainifnecessary."))
        	{
        		Report.Success("Saam Message corresponds to demand.");
        	}
        	else 
        	{
        		Report.Failure("Saam Message does not correspond to demand.");
        	}
        }

        public void waitCalculation()
        {
        	Report.Log(ReportLevel.Info, "Delay", String.Format("Waiting for {0}s.", HelperConstants.WAIT_CALCULATION));
        	Delay.Seconds(HelperConstants.WAIT_CALCULATION);
        }

        public void RunAnalysis(string protocolName)
        {
        	StartAnalysisHelper.Protocol = protocolName;
            StartAnalysisHelper.StartAnalysis();
            Delay.Seconds(HelperConstants.TIME_TO_OPEN_PROTOCOL);
        }
    }
}