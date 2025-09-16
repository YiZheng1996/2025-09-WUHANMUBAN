namespace MainUI
{
    public partial class FrmTestProcess : UIForm
    {
        public FrmTestProcess() => InitializeComponent();

        private readonly TestProcessBLL _processBLL = new();
        private readonly TestProcessModel _processModel;
        public FrmTestProcess(TestProcessModel model)
        {
            InitializeComponent();
            _processModel = model;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string ProcessName = txtProcessName.Text.Trim();
                string EntityClassName = txtEntityClassName.Text.Trim();
                bool IsVisible = RadioIsVisible.Checked;
                if (string.IsNullOrEmpty(ProcessName))
                {
                    MessageHelper.MessageOK(this, "未输入项点名称！");
                    txtProcessName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(EntityClassName))
                {
                    MessageHelper.MessageOK(this, "未输入关联实体类名称！");
                    txtProcessName.Focus();
                    return;
                }

                bool result = false;
                if (_processModel == null)
                {
                    var newModel = new TestProcessModel
                    {
                        ProcessName = txtProcessName.Text,
                        EntityClassName = txtEntityClassName.Text,
                        IsVisible = IsVisible,
                    };
                    result = _processBLL.AddTestProcess(newModel);
                }
                else
                {
                    _processModel.ProcessName = ProcessName;
                    EntityClassName = txtEntityClassName.Text;
                    _processModel.IsVisible = IsVisible;
                    result = _processBLL.SaveTestProcess(_processModel);
                }

                if (result)
                {
                    MessageHelper.MessageOK(this, "保存成功！");
                    Close();
                }
                else
                {
                    MessageHelper.MessageOK(this, "保存失败！");
                }
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("保存失败：", ex);
                MessageHelper.MessageOK(this, "保存失败：" + ex.Message);
            }
        }


        private void frmMeteringEdit_Load(object sender, EventArgs e)
        {
            if (_processModel != null)
            {
                txtProcessName.Text = _processModel.ProcessName;
                txtEntityClassName.Text = _processModel.EntityClassName;

                if (_processModel.IsVisible)
                {
                    RadioIsVisible.Checked = true;
                }
                else
                {
                    RadioIsVisible2.Checked = true;

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}