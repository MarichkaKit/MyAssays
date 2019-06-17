using System;
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
    public partial class AssayDataFolderRootHyperlink
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void CheckOpenedFolder()
        {
        	var linkElement = repo.MyAssaysExplorer.BackStage.AssayDataRootFolderPath.Children[0];
        	string expectedPath = linkElement.Element.GetAttributeValueText("NavigateUri").Replace("file:///", "Address: ").Replace("\u002f", "\u005c");
        	string actualPath = repo.MyAssays.PathField.Element.GetAttributeValueText("Name");
        	
        	Report.Info(expectedPath);
        	Report.Info(actualPath);
        	Validate.AreEqual(actualPath, expectedPath, "Expected folder was opened in Windows Explorer.");
        }

        public void IsHyperlink()
        {
        	var linkElement = repo.MyAssaysExplorer.BackStage.AssayDataRootFolderPath.Children[0];
        	string textType = linkElement.Element.GetAttributeValueText("Type");
        	
			Validate.AreEqual(textType, "Hyperlink", "Assay Data Root Folder Path is represented as Hyperlink.");
        }
    }
}