using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace SEC.PowerPointPowerToy
{
    public partial class MainRibbon
    {
        private void MainRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void SetTimeLIMITButton_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.PowerPoint.Presentation PPT = Globals.ThisAddIn.Application.ActivePresentation;
            Microsoft.Office.Core.DocumentProperties oCusProps = PPT.CustomDocumentProperties;
            bool TimeSetted = false;
            foreach (Microsoft.Office.Core.DocumentProperty oCusProp in oCusProps)
            {
                if (oCusProp.Name == "TIMELIMIT")// MessageBox.Show( oCusProp.Name);
                {
                    TimeSetted = true;
                    MessageBox.Show(String.Format("{0:f}min",oCusProp.Value));      
                }
            }

            if (!TimeSetted)
            {
                oCusProps.Add("TIMELIMIT", false, Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeFloat, 5F, false);
            }
        }
    }
}
