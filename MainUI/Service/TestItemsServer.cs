namespace MainUI.Service
{
    /// <summary>
    /// 根据配置动态生成测试项实例的服务类
    /// </summary>
    public class TestItemsServer
    {
        /// <summary>
        /// 根据 TestProcessModel 自动生成 DicTestItems
        /// </summary>
        /// <returns>测试项字典</returns>
        public static Dictionary<TaskInfo, BaseTest> GenerateTestItemsFromConfig()
        {
            var dicTestItems = new Dictionary<TaskInfo, BaseTest>();

            try
            {
                // 获取启用的测试流程配置
                var testProcessList = GetEnabledTestProcessList();

                foreach (var process in testProcessList)
                {
                    // 根据实体类名称创建对应的实例
                    var testItem = CreateTestItemInstance(process.EntityClassName);

                    if (testItem != null)
                    {
                        //dicTestItems[process.ProcessName] = testItem;
                        //dicTestItems[process.ProcessName] = testItem;
                    }
                }

                return dicTestItems;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("自动生成 DicTestItems 失败", ex);
                return [];
            }
        }

        /// <summary>
        /// 根据实体类名称创建实例
        /// </summary>
        /// <param name="entityClassName">实体类名称</param>
        /// <returns>测试项实例</returns>
        private static BaseTest CreateTestItemInstance(string entityClassName)
        {
            if (string.IsNullOrEmpty(entityClassName))
                return null;

            try
            {
                // 根据类名创建对应的实例
                switch (entityClassName)
                {
                    case "PressureTestItem":
                        return new AirTightnessTest();

                    case "FlowTestItem":
                        return new DynamicWaterTightnessTest();

                    case "TemperatureTestItem":
                        return new StaticWaterTightnessTest();

                    // 可以继续添加其他测试项类型...

                    default:
                        NlogHelper.Default.Warn($"未知的实体类名称: {entityClassName}");
                        return null;
                }
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error($"创建实例失败: {entityClassName}", ex);
                return null;
            }
        }

        /// <summary>
        /// 获取启用的测试流程列表
        /// </summary>
        private static List<TestProcessModel> GetEnabledTestProcessList()
        {
            try
            {
                // 从数据库获取
                var bll = new TestProcessBLL();
                return bll.GetTestProcess(true);
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("获取测试流程配置失败", ex);
                return [];
            }
        }
    }
}
