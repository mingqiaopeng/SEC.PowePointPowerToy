namespace SEC.PowerPointPowerToy
{
    partial class NoticeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NoticLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoticLabel
            // 
            this.NoticLabel.AutoSize = true;
            this.NoticLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.NoticLabel.Font = new System.Drawing.Font("华康俪金黑W8(P)", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NoticLabel.ForeColor = System.Drawing.Color.Maroon;
            this.NoticLabel.Location = new System.Drawing.Point(30, 0);
            this.NoticLabel.Name = "NoticLabel";
            this.NoticLabel.Size = new System.Drawing.Size(404, 48);
            this.NoticLabel.TabIndex = 0;
            this.NoticLabel.Text = "您的发言已超时！";
            this.NoticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 61);
            this.Controls.Add(this.NoticLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "NoticeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NoticeForm";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.NoticeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoticLabel;
    }
}