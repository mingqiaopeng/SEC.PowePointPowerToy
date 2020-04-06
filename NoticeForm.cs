using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SEC.PowerPointPowerToy
{
    public partial class NoticeForm : Form
    {

        /*
        * 下面这段代码主要用来调用Windows API实现窗体透明(鼠标可以穿透窗体)
        */
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern long GetWindowLong(IntPtr hwnd, int nIndex);
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern long SetWindowLong(IntPtr hwnd, int nIndex, long dwNewLong);
        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern int SetLayeredWindowAttributes(IntPtr Handle, int crKey, byte bAlpha, int dwFlags);

        const int GWL_EXSTYLE = -20;
        const int WS_EX_TRANSPARENT = 0x20;
        const int WS_EX_LAYERED = 0x80000;
        const int LWA_ALPHA = 2;

        public NoticeForm()
        {
            InitializeComponent();
        }

        public void SetOpacity(byte opacity)
        {
            SetLayeredWindowAttributes(this.Handle, 80, opacity, LWA_ALPHA);
        }

        private void NoticeForm_Load(object sender, EventArgs e)
        {
            // 取消窗体任务栏
            ShowInTaskbar = false;
            // 窗体位于Windows最顶部
            this.TopMost = true;
            // 去除窗体边框
            this.FormBorderStyle = FormBorderStyle.None;//5+1+a+s+p+x
                                                        // 设置窗体最大化大小(除底部任务栏部分)
                                                        //this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                                                        // 设置Windows窗口状态为最大化模式
                                                        //this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;
            this.Top = 0;
            this.Left = Screen.PrimaryScreen.Bounds.Width - 450;
            //this.BackColor = Color.White;
            // 设置Windows属性
            SetWindowLong(this.Handle, GWL_EXSTYLE, GetWindowLong(this.Handle, GWL_EXSTYLE) | WS_EX_TRANSPARENT | WS_EX_LAYERED);
            SetLayeredWindowAttributes(this.Handle, 80, 0, LWA_ALPHA);

            
            //this.BackColor = Color.Black;
        }
    }
}
