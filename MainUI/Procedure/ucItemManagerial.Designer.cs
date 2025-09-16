using Padding = System.Windows.Forms.Padding;

namespace MainUI.Procedure
{
    partial class ucItemManagerial
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
            grpTestProcess = new UIGroupBox();
            TableTestProcess = new AntdUI.Table();
            btnEdit = new UIButton();
            btnDelete = new UIButton();
            btnAdd = new UIButton();
            grpTestProcess.SuspendLayout();
            SuspendLayout();
            // 
            // grpTestProcess
            // 
            grpTestProcess.BackColor = Color.FromArgb(236, 236, 237);
            grpTestProcess.Controls.Add(TableTestProcess);
            grpTestProcess.Controls.Add(btnEdit);
            grpTestProcess.Controls.Add(btnDelete);
            grpTestProcess.Controls.Add(btnAdd);
            grpTestProcess.FillColor = Color.FromArgb(236, 236, 237);
            grpTestProcess.FillColor2 = Color.FromArgb(236, 236, 237);
            grpTestProcess.FillDisableColor = Color.FromArgb(236, 236, 237);
            grpTestProcess.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
            grpTestProcess.ForeColor = Color.Black;
            grpTestProcess.ForeDisableColor = Color.Black;
            grpTestProcess.Location = new Point(0, 0);
            grpTestProcess.Margin = new Padding(4, 5, 4, 5);
            grpTestProcess.MinimumSize = new Size(1, 1);
            grpTestProcess.Name = "grpTestProcess";
            grpTestProcess.Padding = new Padding(0, 32, 0, 0);
            grpTestProcess.RectColor = Color.FromArgb(236, 236, 237);
            grpTestProcess.RectDisableColor = Color.FromArgb(236, 236, 237);
            grpTestProcess.Size = new Size(665, 655);
            grpTestProcess.TabIndex = 403;
            grpTestProcess.Text = "试验项点";
            grpTestProcess.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // TableTestProcess
            // 
            TableTestProcess.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            TableTestProcess.BackColor = Color.White;
            TableTestProcess.BackgroundImageLayout = ImageLayout.None;
            TableTestProcess.BorderColor = Color.Black;
            TableTestProcess.Bordered = true;
            TableTestProcess.CheckSize = 20;
            TableTestProcess.ClipboardCopy = false;
            TableTestProcess.ColumnBack = Color.FromArgb(44, 62, 80);
            TableTestProcess.ColumnFont = new Font("微软雅黑", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            TableTestProcess.ColumnFore = Color.White;
            TableTestProcess.DefaultExpand = true;
            TableTestProcess.Dock = DockStyle.Top;
            TableTestProcess.Font = new Font("微软雅黑", 14.25F);
            TableTestProcess.Gap = 12;
            TableTestProcess.ImeMode = ImeMode.NoControl;
            TableTestProcess.Location = new Point(0, 32);
            TableTestProcess.Name = "TableTestProcess";
            TableTestProcess.RightToLeft = RightToLeft.No;
            TableTestProcess.RowHeight = 50;
            TableTestProcess.RowHeightHeader = 40;
            TableTestProcess.Size = new Size(665, 570);
            TableTestProcess.SwitchSize = 25;
            TableTestProcess.TabIndex = 407;
            TableTestProcess.CellClick += TableTestProcess_CellClick;
            TableTestProcess.CellDoubleClick += TableTestProcess_CellDoubleClick;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
            btnEdit.ForeDisableColor = Color.White;
            btnEdit.Location = new Point(364, 615);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.RectDisableColor = Color.FromArgb(80, 160, 255);
            btnEdit.Size = new Size(147, 37);
            btnEdit.TabIndex = 395;
            btnEdit.Text = "更改";
            btnEdit.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnEdit.TipsText = "1";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
            btnDelete.ForeDisableColor = Color.White;
            btnDelete.Location = new Point(183, 615);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.RectDisableColor = Color.FromArgb(80, 160, 255);
            btnDelete.Size = new Size(147, 37);
            btnDelete.TabIndex = 394;
            btnDelete.Text = "删除";
            btnDelete.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDelete.TipsText = "1";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
            btnAdd.ForeDisableColor = Color.White;
            btnAdd.Location = new Point(2, 615);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.RectDisableColor = Color.FromArgb(80, 160, 255);
            btnAdd.Size = new Size(147, 37);
            btnAdd.TabIndex = 393;
            btnAdd.Text = "添加";
            btnAdd.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAdd.TipsText = "1";
            btnAdd.Click += btnAdd_Click;
            // 
            // ucItemManagerial
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 236, 236);
            Controls.Add(grpTestProcess);
            Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(3, 6, 3, 6);
            Name = "ucItemManagerial";
            Size = new Size(665, 655);
            Load += ucItemManagerial_Load;
            grpTestProcess.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private UIGroupBox grpTestProcess;
        private UIButton btnEdit;
        private UIButton btnDelete;
        private UIButton btnAdd;
        private AntdUI.Table TableTestProcess;
    }
}
