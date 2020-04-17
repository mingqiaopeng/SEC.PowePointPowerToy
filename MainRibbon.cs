using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Tools.Ribbon;
using SEC.PowerPointPowerToy.Properties;

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
                    System.Windows.MessageBox.Show(String.Format("{0:f}min",oCusProp.Value));      
                }
            }

            if (!TimeSetted)
            {
                oCusProps.Add("TIMELIMIT", false, Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeFloat, 5F, false);
            }
        }

        private void AddProgressButton_Click(object sender, RibbonControlEventArgs e)
        {
            SolidColorBrush Fill = new SolidColorBrush(Color.FromArgb(0xff, 0xff, 0xff, 0xff));

            Window window = new Window();
            window.ShowInTaskbar = false;
            window.ResizeMode = ResizeMode.NoResize;
            window.Height = 100;
            window.Width = 300;
            window.Background = Fill;
            window.Background.Opacity = 0.4;
            window.AllowDrop = false;
            window.Topmost = true;
            window.AllowsTransparency = true;
            window.OpacityMask = Fill;
            window.Opacity = 10;


            window.Content = "您已经超时";
            window.FontSize = 68;
             
            //window.Background.Opacity = 0;
            window.WindowStyle = WindowStyle.None;

            window.Title = "我是WPF弹窗!!!!";
            new System.Windows.Interop.WindowInteropHelper(window) { Owner = new IntPtr(Globals.ThisAddIn.Application.HWND) };
            window.Show();

            Presentation P = Globals.ThisAddIn.Application.ActivePresentation;
            int count = P.Slides.Count;
            float margin = 0F;
            float width = P.PageSetup.SlideWidth - (margin * 2);// full width of PB设定进度条里两边的距离
            float height = 4;
            float top = P.PageSetup.SlideHeight - height;
            float curPos, curRatio;

            foreach (Slide S in P.Slides)
            {
                try
                {
                    S.Shapes["PB"].Delete();
                    S.Shapes["PBBack"].Delete();
                }
                catch (Exception ex)
                {

                }

                //把已有的shape都删掉，旧的
                if (S.SlideIndex != 1)//跳过第一章幻灯片，也就是第一张不加进度条
                {
                    curPos = (float) (S.SlideIndex * width / count); //获取当前幻灯片的进度条长度
                    curRatio = (float)(Math.Round((double ) S.SlideIndex / count, 4) * 100);
                    Shape BarBack = S.Shapes.AddShape(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRectangle, margin, top, width , height);
                    Shape Bar = S.Shapes.AddShape(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRectangle, margin, top, curPos, height);
                    //Bar.Shadow.Blur = 6;
                    //Bar.Shadow.OffsetX = 1;
                    //Bar.Shadow.OffsetY = 2;
                    //Bar.Shadow.ForeColor.RGB = System.Drawing.Color.FromArgb(100, 100, 100).ToArgb();
                    BarBack.Name = "PBBack";
                    Bar.Name = "PB";
                    BarBack.Fill.ForeColor.RGB = System.Drawing.Color.FromArgb(255,255, 255).ToArgb();
                    Bar.Fill.ForeColor.RGB = System.Drawing.Color.FromArgb(75, 76, 206).ToArgb();
                    BarBack.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;
                    Bar.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;
                    //XXXXXXXXXXXXXXXX
                    //Add PBTag Shape
                    //XXXXXXXXXXXXXXXX
                    // 数字显示的标记的对象bartag
                    /*
                    Shape barTag = S.Shapes.AddShape(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCloud, curPos + 9.89F, 3, 62.9F, 22.44F);
                    barTag.TextFrame.TextRange.Text = S.SlideIndex.ToString() + @"/" + count.ToString();
                    barTag.Name = "PBTag";

                    barTag.Fill.ForeColor.RGB = System.Drawing.Color.FromArgb(255, 255, 2).ToArgb();

                    barTag.TextFrame.TextRange.Font.Size = 13;
                    barTag.TextFrame.TextRange.Font.Name = "微软雅黑";
                    barTag.TextFrame.TextRange.Font.Bold = Microsoft.Office.Core.MsoTriState.msoTrue;
                    barTag.TextFrame.TextRange.Font.Color.RGB = System.Drawing.Color.FromArgb(100, 100, 100).ToArgb() ;
                    barTag.TextFrame.TextRange.ParagraphFormat.Alignment = PpParagraphAlignment.ppAlignCenter;

                    barTag.Shadow.Blur = 6;
                    barTag.Shadow.OffsetX = 1;
                    barTag.Shadow.OffsetY = 2;
                    barTag.Shadow.ForeColor.RGB = System.Drawing.Color.FromArgb(100, 100, 100).ToArgb();
                    barTag.Line.Weight= 0.5F;
                    barTag.Line.ForeColor.RGB = System.Drawing.Color.FromArgb(255, 255, 50).ToArgb();
                    */

                }
            }


        }

        private void InsertLogoSplitButton_Click(object sender, RibbonControlEventArgs e)
        {
            //Globals.ThisAddIn.Application

            string filenameSmall = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath) + @"\SGCCLogoSmall.png";
            string filenameBig = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath) + @"\SGCCLogoBig.png";

            if (!File.Exists(filenameSmall))
            {
                Resources.SGCCLogoSmall.Save(filenameSmall);
            }

            if (!File.Exists(filenameBig))
            {
                Resources.SGCCLogoBig.Save(filenameBig);
            }


            Presentation P = Globals.ThisAddIn.Application.ActivePresentation;
            float margin = 0F;
            float SlideWidth = P.PageSetup.SlideWidth ;// full width of PB设定进度条里两边的距离
            float SlideHeight = P.PageSetup.SlideHeight;


            foreach (Slide S in P.Slides)
            {
                if (S.SlideIndex == 1 && SkipFirstPageCheckBox.Checked)
                    continue;

                if (BigLogoCheckBox.Checked)//大版本
                {
                    Shape Logo =S.Shapes.AddPicture(filenameBig, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue,0, 0);
                    Logo.Name = "SGCCLOGO";
                    Logo.Height = 70;
                    
                    Logo.Left = SlideWidth - Logo.Width - 5;
                    if(TopCheckBox.Checked)
                    {
                        Logo.Top = 5;
                    }
                    else
                    {
                        Logo.Top = SlideHeight - 5 - Logo.Height;
                    }
                        
                }
                else//小版本
                {
                    Shape Logo = S.Shapes.AddPicture(filenameSmall, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, 0, 0);
                    Logo.Name = "SGCCLOGO";
                    Logo.Height = 60;

                    Logo.Left = SlideWidth - Logo.Width - 5;

                    if (TopCheckBox.Checked)
                    {
                        Logo.Top = 5;
                    }
                    else
                    {
                        Logo.Top = SlideHeight - 5 - Logo.Height;
                    }

                }

            }
        }
    }
}
