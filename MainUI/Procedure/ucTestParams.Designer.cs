namespace MainUI.Procedure
{
    partial class UcTestParams
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            AntdUI.Tabs.StyleCard2 styleCard21 = new AntdUI.Tabs.StyleCard2();
            openFileDialog1 = new OpenFileDialog();
            uiGroupBox1 = new UIGroupBox();
            txtType = new UITextBox();
            uiLabel9 = new UILabel();
            btnGet = new UIButton();
            uiLabel2 = new UILabel();
            txtModel = new UITextBox();
            btnBrowse = new UIButton();
            btnDelete = new UIButton();
            txtRpt = new UITextBox();
            tabs1 = new AntdUI.Tabs();
            tabPage1 = new AntdUI.TabPage();
            tabPage2 = new AntdUI.TabPage();
            uiLabel3 = new UILabel();
            btnReport = new AntdUI.Button();
            btnParameter = new AntdUI.Button();
            uiGroupBox1.SuspendLayout();
            tabs1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.BackColor = Color.Transparent;
            uiGroupBox1.Controls.Add(txtType);
            uiGroupBox1.Controls.Add(uiLabel9);
            uiGroupBox1.Controls.Add(btnGet);
            uiGroupBox1.Controls.Add(uiLabel2);
            uiGroupBox1.Controls.Add(txtModel);
            uiGroupBox1.FillColor = Color.White;
            uiGroupBox1.FillColor2 = Color.White;
            uiGroupBox1.FillDisableColor = Color.FromArgb(42, 47, 55);
            uiGroupBox1.Font = new Font("思源黑体 CN Bold", 14F, FontStyle.Bold);
            uiGroupBox1.ForeColor = Color.FromArgb(46, 46, 46);
            uiGroupBox1.ForeDisableColor = Color.FromArgb(235, 227, 221);
            uiGroupBox1.Location = new Point(0, 0);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Radius = 15;
            uiGroupBox1.RectColor = Color.White;
            uiGroupBox1.RectDisableColor = Color.White;
            uiGroupBox1.Size = new Size(665, 93);
            uiGroupBox1.TabIndex = 400;
            uiGroupBox1.Text = "参数设置";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtType
            // 
            txtType.Enabled = false;
            txtType.FillColor = Color.FromArgb(218, 220, 230);
            txtType.FillColor2 = Color.FromArgb(218, 220, 230);
            txtType.FillDisableColor = Color.FromArgb(218, 220, 230);
            txtType.FillReadOnlyColor = Color.FromArgb(218, 220, 230);
            txtType.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            txtType.ForeColor = Color.FromArgb(46, 46, 46);
            txtType.ForeDisableColor = Color.FromArgb(235, 227, 221);
            txtType.ForeReadOnlyColor = Color.FromArgb(235, 227, 221);
            txtType.Location = new Point(97, 44);
            txtType.Margin = new Padding(4, 5, 4, 5);
            txtType.MinimumSize = new Size(1, 16);
            txtType.Name = "txtType";
            txtType.Padding = new Padding(5);
            txtType.Radius = 10;
            txtType.ReadOnly = true;
            txtType.RectColor = Color.Gray;
            txtType.RectDisableColor = Color.Gray;
            txtType.RectReadOnlyColor = Color.FromArgb(218, 220, 230);
            txtType.ShowText = false;
            txtType.Size = new Size(147, 29);
            txtType.TabIndex = 397;
            txtType.TextAlignment = ContentAlignment.MiddleLeft;
            txtType.Watermark = "请选择";
            // 
            // uiLabel9
            // 
            uiLabel9.AutoSize = true;
            uiLabel9.BackColor = Color.Transparent;
            uiLabel9.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel9.ForeColor = Color.FromArgb(46, 46, 46);
            uiLabel9.Location = new Point(14, 46);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new Size(90, 23);
            uiLabel9.TabIndex = 396;
            uiLabel9.Text = "产品类型：";
            uiLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGet
            // 
            btnGet.Cursor = Cursors.Hand;
            btnGet.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnGet.Font = new Font("思源黑体 CN Bold", 11F, FontStyle.Bold);
            btnGet.ForeDisableColor = Color.White;
            btnGet.Location = new Point(542, 38);
            btnGet.MinimumSize = new Size(1, 1);
            btnGet.Name = "btnGet";
            btnGet.RectDisableColor = Color.FromArgb(80, 160, 255);
            btnGet.Size = new Size(105, 40);
            btnGet.TabIndex = 389;
            btnGet.Text = "产品选择";
            btnGet.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnGet.TipsText = "1";
            btnGet.Click += btnProductSelection_Click;
            // 
            // uiLabel2
            // 
            uiLabel2.AutoSize = true;
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel2.ForeColor = Color.FromArgb(46, 46, 46);
            uiLabel2.Location = new Point(286, 46);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(79, 23);
            uiLabel2.TabIndex = 82;
            uiLabel2.Text = "产品型号:";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtModel
            // 
            txtModel.Enabled = false;
            txtModel.FillColor = Color.FromArgb(218, 220, 230);
            txtModel.FillColor2 = Color.FromArgb(218, 220, 230);
            txtModel.FillDisableColor = Color.FromArgb(218, 220, 230);
            txtModel.FillReadOnlyColor = Color.FromArgb(218, 220, 230);
            txtModel.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            txtModel.ForeColor = Color.FromArgb(46, 46, 46);
            txtModel.ForeDisableColor = Color.FromArgb(235, 227, 221);
            txtModel.ForeReadOnlyColor = Color.FromArgb(235, 227, 221);
            txtModel.Location = new Point(371, 44);
            txtModel.Margin = new Padding(4, 5, 4, 5);
            txtModel.MinimumSize = new Size(1, 16);
            txtModel.Name = "txtModel";
            txtModel.Padding = new Padding(5);
            txtModel.ReadOnly = true;
            txtModel.RectColor = Color.FromArgb(218, 220, 230);
            txtModel.RectDisableColor = Color.FromArgb(218, 220, 230);
            txtModel.RectReadOnlyColor = Color.FromArgb(218, 220, 230);
            txtModel.ShowText = false;
            txtModel.Size = new Size(147, 29);
            txtModel.TabIndex = 390;
            txtModel.TextAlignment = ContentAlignment.MiddleLeft;
            txtModel.Watermark = "请选择";
            // 
            // btnBrowse
            // 
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnBrowse.Font = new Font("思源黑体 CN Bold", 11F, FontStyle.Bold);
            btnBrowse.ForeDisableColor = Color.White;
            btnBrowse.Location = new Point(480, 126);
            btnBrowse.MinimumSize = new Size(1, 1);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.RectDisableColor = Color.FromArgb(80, 160, 255);
            btnBrowse.Size = new Size(82, 29);
            btnBrowse.TabIndex = 394;
            btnBrowse.Text = "浏览";
            btnBrowse.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBrowse.TipsText = "1";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnDelete.Font = new Font("思源黑体 CN Bold", 11F, FontStyle.Bold);
            btnDelete.ForeDisableColor = Color.White;
            btnDelete.Location = new Point(467, 614);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.RectDisableColor = Color.FromArgb(80, 160, 255);
            btnDelete.Size = new Size(183, 40);
            btnDelete.TabIndex = 396;
            btnDelete.Text = "保存";
            btnDelete.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDelete.TipsText = "1";
            btnDelete.Click += btnOK_Click;
            // 
            // txtRpt
            // 
            txtRpt.Enabled = false;
            txtRpt.FillColor = Color.FromArgb(218, 220, 230);
            txtRpt.FillColor2 = Color.FromArgb(218, 220, 230);
            txtRpt.FillDisableColor = Color.FromArgb(218, 220, 230);
            txtRpt.FillReadOnlyColor = Color.FromArgb(218, 220, 230);
            txtRpt.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            txtRpt.ForeColor = Color.FromArgb(46, 46, 46);
            txtRpt.ForeDisableColor = Color.FromArgb(235, 227, 221);
            txtRpt.ForeReadOnlyColor = Color.FromArgb(235, 227, 221);
            txtRpt.Location = new Point(165, 126);
            txtRpt.Margin = new Padding(4, 5, 4, 5);
            txtRpt.MinimumSize = new Size(1, 16);
            txtRpt.Name = "txtRpt";
            txtRpt.Padding = new Padding(5);
            txtRpt.ReadOnly = true;
            txtRpt.RectColor = Color.FromArgb(218, 220, 230);
            txtRpt.RectDisableColor = Color.FromArgb(218, 220, 230);
            txtRpt.RectReadOnlyColor = Color.FromArgb(218, 220, 230);
            txtRpt.ShowText = false;
            txtRpt.Size = new Size(298, 29);
            txtRpt.TabIndex = 393;
            txtRpt.TextAlignment = ContentAlignment.MiddleLeft;
            txtRpt.Watermark = "请选择";
            // 
            // tabs1
            // 
            tabs1.BackColor = Color.White;
            tabs1.Controls.Add(tabPage1);
            tabs1.Controls.Add(tabPage2);
            tabs1.Location = new Point(0, 136);
            tabs1.Name = "tabs1";
            tabs1.Pages.Add(tabPage1);
            tabs1.Pages.Add(tabPage2);
            tabs1.Size = new Size(665, 470);
            styleCard21.Closable = AntdUI.Tabs.StyleCard2.CloseType.none;
            tabs1.Style = styleCard21;
            tabs1.TabIndex = 401;
            tabs1.TabMenuVisible = false;
            tabs1.Text = "tabs1";
            tabs1.Type = AntdUI.TabType.Card2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Location = new Point(3, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(659, 464);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "试验参数";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(uiLabel3);
            tabPage2.Controls.Add(btnBrowse);
            tabPage2.Controls.Add(txtRpt);
            tabPage2.Location = new Point(-659, -464);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(659, 464);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "报表模板";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel3.ForeColor = Color.FromArgb(46, 46, 46);
            uiLabel3.Location = new Point(83, 126);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(75, 23);
            uiLabel3.TabIndex = 397;
            uiLabel3.Text = "产品类型";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnReport
            // 
            btnReport.BackActive = Color.FromArgb(196, 199, 204);
            btnReport.BackColor = Color.FromArgb(196, 199, 204);
            btnReport.BorderWidth = 1F;
            btnReport.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
            btnReport.ForeColor = Color.White;
            btnReport.JoinMode = AntdUI.TJoinMode.Right;
            btnReport.Location = new Point(120, 102);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(124, 35);
            btnReport.TabIndex = 496;
            btnReport.Text = "报表模板";
            btnReport.Type = AntdUI.TTypeMini.Primary;
            btnReport.WaveSize = 1;
            btnReport.Click += btnReport_Click;
            // 
            // btnParameter
            // 
            btnParameter.BackActive = Color.FromArgb(49, 54, 64);
            btnParameter.BackColor = Color.White;
            btnParameter.BorderWidth = 1F;
            btnParameter.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
            btnParameter.ForeColor = Color.Black;
            btnParameter.JoinMode = AntdUI.TJoinMode.Left;
            btnParameter.Location = new Point(0, 102);
            btnParameter.Name = "btnParameter";
            btnParameter.Size = new Size(119, 35);
            btnParameter.TabIndex = 495;
            btnParameter.Text = "参数界面";
            btnParameter.Type = AntdUI.TTypeMini.Primary;
            btnParameter.WaveSize = 1;
            btnParameter.Click += btnParameter_Click;
            // 
            // UcTestParams
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(btnReport);
            Controls.Add(btnParameter);
            Controls.Add(tabs1);
            Controls.Add(btnDelete);
            Controls.Add(uiGroupBox1);
            Name = "UcTestParams";
            Size = new Size(665, 660);
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox1.PerformLayout();
            tabs1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btnGet;
        private Sunny.UI.UITextBox txtModel;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnBrowse;
        private Sunny.UI.UITextBox txtRpt;
        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage tabPage1;
        private AntdUI.TabPage tabPage2;
        private UILabel uiLabel3;
        private UILabel uiLabel9;
        private UITextBox txtType;
        private AntdUI.Button btnReport;
        private AntdUI.Button btnParameter;
    }
}
