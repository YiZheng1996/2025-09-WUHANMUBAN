using AntdUI;

namespace MainUI.Procedure.DSL
{
    public partial class ucItemManagerial : ucBaseManagerUI
    {
        int RowCount = 0;
        private readonly TestProcessBLL ProcessBll = new();
        private TestProcessModel _processModel = new();
        public ucItemManagerial() => InitializeComponent();

        // 初始化表单数据
        private void LoadData()
        {
            TableTestProcess.Columns = [
                new Column("ID","ID"){ Align = ColumnAlign.Center , Visible = false },
                new Column("ProcessName","项点名称"){ Align = ColumnAlign.Center, Width="390"},
                new ColumnSwitch("Enable","启用",ColumnAlign.Center){ Call = (value , record , i_row , i_col)=>
                {
                    Thread.Sleep(100);
                    return value;
                 }},
            ];
            var data = ProcessBll.GetTestProcess();
            RowCount = data.Count;
            data.ForEach(x => x.Enable = x.IsVisible);
            TableTestProcess.DataSource = data;
            TableTestProcessIndex(TableTestProcess.SelectedIndex);
        }

        // 选中行
        void TableTestProcessIndex(int index)
        {
            if (index > RowCount) index -= 1;
            if (index < 0) index = RowCount;
            TableTestProcess.ScrollLine(index);
            TableTestProcess.SelectedIndex = index;
        }

        private void LoadData(TestProcessModel model)
        {
            using frmTestProcess edit = new(model);
            edit.ShowDialog();
            LoadData();
        }

        // 添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadData(null);
        }

        // 删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageHelper.MessageYes("是否删除选中记录？", TType.Warn);
            if (DialogResult == DialogResult.OK)
            {
                if (ProcessBll.DelTestProcess(_processModel.ID))
                {
                    MessageHelper.MessageOK("删除成功！");
                }
                else
                {
                    MessageHelper.MessageOK("删除失败！");
                }
                LoadData();
            }
        }

        // 修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoadData(_processModel);
        }

        private void ucItemManagerial_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TableTestProcess_CellClick(object sender, TableClickEventArgs e)
        {
            if (e.Record is TestProcessModel model)
            {
                _processModel = model;
            }
        }
    }
}
