namespace MainUI.BLL
{
    internal class TestProcessBLL
    {
        private readonly TestClassFileManager _fileManager = new();

        public List<TestProcessModel> GetTestProcess() => VarHelper.fsql
               .Select<TestProcessModel>()
               .ToList(item => new TestProcessModel
               {
                   ID = item.ID,
                   ProcessName = item.ProcessName,
                   EntityClassName = item.EntityClassName,
                   IsVisible = item.IsVisible
               });

        public List<TestProcessModel> GetTestProcess(bool IsVisible) => VarHelper.fsql
              .Select<TestProcessModel>()
              .Where(w => w.IsVisible == IsVisible)
              .ToList(item => new TestProcessModel
              {
                  ID = item.ID,
                  ProcessName = item.ProcessName,
                  EntityClassName = item.EntityClassName,
                  IsVisible = item.IsVisible
              });

        public bool AddTestProcess(TestProcessModel model)
        {
            try
            {
                // 使用EntityClassName创建文件
                bool result = VarHelper.fsql.Insert(model).ExecuteAffrows() > 0;

                if (result && !string.IsNullOrEmpty(model.EntityClassName))
                {
                    _fileManager.CreateTestClassByEntityClassName(model.EntityClassName);
                }
                return result;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("添加测试流程失败：", ex);
                return false;
            }
        }

        public bool DelTestProcess(int ID)
        {
            try
            {
                var model = VarHelper.fsql.Select<TestProcessModel>()
                    .Where(a => a.ID == ID)
                    .First();

                if (model == null) return false;

                bool result = VarHelper.fsql.Delete<TestProcessModel>()
                    .Where(a => a.ID == ID)
                    .ExecuteAffrows() > 0;

                if (result && !string.IsNullOrEmpty(model.EntityClassName))
                {
                    _fileManager.DeleteTestClassByEntityClassName(model.EntityClassName);
                }
                return result;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("删除测试流程失败：", ex);
                return false;
            }
        }

        public bool SaveTestProcess(TestProcessModel model)
        {
            try
            {
                // 获取原始记录
                var originalModel = VarHelper.fsql.Select<TestProcessModel>()
                    .Where(w => w.ID == model.ID)
                    .First();

                if (originalModel == null)
                    return false;

                string oldEntityClassName = originalModel.EntityClassName;

                // 更新数据库
                bool result = VarHelper.fsql.Update<TestProcessModel>()
                    .Set(s => s.ProcessName, model.ProcessName)
                    .Set(s => s.IsVisible, model.IsVisible)
                    .Set(s => s.EntityClassName, model.EntityClassName)
                    .Where(w => w.ID == model.ID)
                    .ExecuteAffrows() > 0;

                if (result)
                {
                    // 如果EntityClassName发生变化，重命名CS文件
                    if (!string.IsNullOrEmpty(oldEntityClassName) &&
                        !string.IsNullOrEmpty(model.EntityClassName) &&
                        oldEntityClassName != model.EntityClassName)
                    {
                        _fileManager.RenameTestClassByEntityClassName(oldEntityClassName, model.EntityClassName);
                        NlogHelper.Default.Info($"成功更新测试流程并重命名文件：{oldEntityClassName} -> {model.EntityClassName}");
                    }
                    else if (!string.IsNullOrEmpty(model.EntityClassName))
                    {
                        // 确保CS文件存在
                        _fileManager.CreateTestClassByEntityClassName(model.EntityClassName);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("保存测试流程失败：", ex);
                return false;
            }
        }
    }
}