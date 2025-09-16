namespace MainUI.BLL
{
    internal class TestProcessBLL
    {
        /// <summary>
        /// 获取测试流程
        /// </summary>
        /// <returns></returns>
        public List<TestProcessModel> GetTestProcess() => VarHelper.fsql
               .Select<TestProcessModel>()
               .ToList(item => new TestProcessModel
               {
                   ID = item.ID,
                   ProcessName = item.ProcessName,
                   IsVisible = item.IsVisible
               });

        /// <summary>
        /// 获取测试流程
        /// </summary>
        /// <param name="IsVisible">是否启用</param>
        /// <returns></returns>
        public List<TestProcessModel> GetTestProcess(bool IsVisible) => VarHelper.fsql
              .Select<TestProcessModel>()
              .Where(w => w.IsVisible == IsVisible)
              .ToList(item => new TestProcessModel
              {
                  ID = item.ID,
                  ProcessName = item.ProcessName,
                  IsVisible = item.IsVisible
              });

        /// <summary>
        /// 添加测试流程
        /// </summary>
        /// <returns></returns>
        public bool AddTestProcess(TestProcessModel model) =>
            VarHelper.fsql.Insert(model)
            .ExecuteAffrows() > 0;

        /// <summary>
        /// 删除测试流程
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public bool DelTestProcess(int ID) =>
            VarHelper.fsql.Delete<TestProcessModel>()
            .Where(a => a.ID == ID)
            .ExecuteAffrows() > 0;

        /// <summary>
        /// 保存测试流程
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SaveTestProcess(TestProcessModel model) =>
            VarHelper.fsql.Update<TestProcessModel>()
            .Set(s => s.ProcessName, model.ProcessName)
            .Set(s => s.IsVisible, model.IsVisible)
            .Where(w => w.ID == model.ID)
            .ExecuteAffrows() > 0;
    }
}
