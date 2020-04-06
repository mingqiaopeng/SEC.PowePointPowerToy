using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace SEC.PowerPointPowerToy
{
    public partial class ThisAddIn
    {
        private NoticeForm NoticeForm = new NoticeForm();
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //NoticeForm.Show();
            Globals.ThisAddIn.Application.PresentationOpen += Application_PresentationOpen;
            Globals.ThisAddIn.Application.SlideShowBegin += Application_SlideShowBegin;
            Globals.ThisAddIn.Application.SlideShowEnd += Application_SlideShowEnd;
        }

        private void Application_PresentationOpen(PowerPoint.Presentation Pres)
        {
            //NoticeForm.Show();
            NoticeForm.SetOpacity(0);
        }

        private void Application_SlideShowEnd(PowerPoint.Presentation Pres)
        {
            
            NoticeForm.Hide();
        }

        private void Application_SlideShowBegin(PowerPoint.SlideShowWindow Wn)
        {
            NoticeForm.Show();
            NoticeForm.SetOpacity(80);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
