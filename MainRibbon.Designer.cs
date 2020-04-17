namespace SEC.PowerPointPowerToy
{
    partial class MainRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRibbon));
            this.SECTab = this.Factory.CreateRibbonTab();
            this.GroupA = this.Factory.CreateRibbonGroup();
            this.SetTimeLIMITButton = this.Factory.CreateRibbonButton();
            this.AddProgressButton = this.Factory.CreateRibbonButton();
            this.InsertLogoSplitButton = this.Factory.CreateRibbonSplitButton();
            this.BigLogoCheckBox = this.Factory.CreateRibbonCheckBox();
            this.SkipFirstPageCheckBox = this.Factory.CreateRibbonCheckBox();
            this.TopCheckBox = this.Factory.CreateRibbonCheckBox();
            this.SECTab.SuspendLayout();
            this.GroupA.SuspendLayout();
            this.SuspendLayout();
            // 
            // SECTab
            // 
            this.SECTab.Groups.Add(this.GroupA);
            this.SECTab.Label = "小小秘书";
            this.SECTab.Name = "SECTab";
            // 
            // GroupA
            // 
            this.GroupA.Items.Add(this.SetTimeLIMITButton);
            this.GroupA.Items.Add(this.AddProgressButton);
            this.GroupA.Items.Add(this.InsertLogoSplitButton);
            this.GroupA.Label = "功能";
            this.GroupA.Name = "GroupA";
            // 
            // SetTimeLIMITButton
            // 
            this.SetTimeLIMITButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SetTimeLIMITButton.Image = ((System.Drawing.Image)(resources.GetObject("SetTimeLIMITButton.Image")));
            this.SetTimeLIMITButton.Label = "设置播放时限";
            this.SetTimeLIMITButton.Name = "SetTimeLIMITButton";
            this.SetTimeLIMITButton.ShowImage = true;
            this.SetTimeLIMITButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SetTimeLIMITButton_Click);
            // 
            // AddProgressButton
            // 
            this.AddProgressButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.AddProgressButton.Image = ((System.Drawing.Image)(resources.GetObject("AddProgressButton.Image")));
            this.AddProgressButton.Label = "添加进度条";
            this.AddProgressButton.Name = "AddProgressButton";
            this.AddProgressButton.ShowImage = true;
            this.AddProgressButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AddProgressButton_Click);
            // 
            // InsertLogoSplitButton
            // 
            this.InsertLogoSplitButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.InsertLogoSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("InsertLogoSplitButton.Image")));
            this.InsertLogoSplitButton.Items.Add(this.BigLogoCheckBox);
            this.InsertLogoSplitButton.Items.Add(this.SkipFirstPageCheckBox);
            this.InsertLogoSplitButton.Items.Add(this.TopCheckBox);
            this.InsertLogoSplitButton.Label = "插入国网标";
            this.InsertLogoSplitButton.Name = "InsertLogoSplitButton";
            this.InsertLogoSplitButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.InsertLogoSplitButton_Click);
            // 
            // BigLogoCheckBox
            // 
            this.BigLogoCheckBox.Checked = true;
            this.BigLogoCheckBox.Label = "使用大图标";
            this.BigLogoCheckBox.Name = "BigLogoCheckBox";
            // 
            // SkipFirstPageCheckBox
            // 
            this.SkipFirstPageCheckBox.Checked = true;
            this.SkipFirstPageCheckBox.Label = "忽略第一页";
            this.SkipFirstPageCheckBox.Name = "SkipFirstPageCheckBox";
            // 
            // TopCheckBox
            // 
            this.TopCheckBox.Checked = true;
            this.TopCheckBox.Label = "位于上方";
            this.TopCheckBox.Name = "TopCheckBox";
            // 
            // MainRibbon
            // 
            this.Name = "MainRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.SECTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MainRibbon_Load);
            this.SECTab.ResumeLayout(false);
            this.SECTab.PerformLayout();
            this.GroupA.ResumeLayout(false);
            this.GroupA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab SECTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupA;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SetTimeLIMITButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AddProgressButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton InsertLogoSplitButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox BigLogoCheckBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox SkipFirstPageCheckBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox TopCheckBox;
    }

    partial class ThisRibbonCollection
    {
        internal MainRibbon MainRibbon
        {
            get { return this.GetRibbon<MainRibbon>(); }
        }
    }
}
