namespace MainUI.Procedure.Test
{
    public class ExperimentalTest01 : BaseTest
    {
        public override async Task<bool> Execute(CancellationToken cancellationToken)
        {
            try
            {
                // 执行测试逻辑
                await Task.Delay(1000, cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error($"ExperimentalTest01：{ex.Message}");
                throw new($"ExperimentalTest01：{ex.Message}");
            }
            finally
            {
                // 试验结束后的清理操作
            }
        }
    }
}
