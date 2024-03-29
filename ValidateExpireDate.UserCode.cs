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

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyAssays.Wizard.RanorexTests
{
    public partial class ValidateExpireDate
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
         public void ValidateExpireDateMessageVisisble()
        {
        	Validate.IsTrue(repo.MyAssaysExplorer.BackStage.ProductSupportPackageExpiredInfo.Exists() &&
        	                repo.MyAssaysExplorer.BackStage.ProductSupportPackageExpired.Visible, "Validate expire date message exist");
        }

        public void ValidateExpireDateText()
        {
        	var expiredDateMessage = repo.MyAssaysExplorer.BackStage.ProductSupportPackageExpired.TextValue;
        	Validate.AreEqual(expiredDateMessage, "Product support package expired on 08 March 2016.", "Validate message: \"Product support package expired on Tuesday, March 8, 2016.\"");
        }

    }
}