namespace MainUI.Procedure.Test
{
    public class ExperimentalTest02 : BaseTest
    {
        public override async Task<bool> Execute(CancellationToken cancellationToken)
        {
            try
            {
                // 执行测试逻辑
                await Task.Delay(1000, cancellationToken);
                //Delay(90, 100, cancellationToken, 
                //    () => OPCHelper.TestCongrp[123].ToString() == "10");
                return true;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error($"ExperimentalTest02：{ex.Message}");
                throw new($"ExperimentalTest02：{ex.Message}");
            }
            finally
            {
                // 试验结束后的清理操作
            }
        }
    }
}
