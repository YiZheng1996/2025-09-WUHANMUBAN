using System.Text;

namespace MainUI.CurrencyHelper
{
    /// <summary>
    /// 测试类文件管理器
    /// </summary>
    public class TestClassFileManager
    {
        private readonly string _testClassPath;

        public TestClassFileManager()
        {
            _testClassPath = GetProjectSourceTestPath();
            EnsureDirectoryExists();
        }

        /// <summary>
        /// 获取项目源码中的Test目录路径
        /// </summary>
        private string GetProjectSourceTestPath()
        {
            try
            {
                // 从当前程序集位置开始查找
                string currentPath = AppDomain.CurrentDomain.BaseDirectory;
                DirectoryInfo dir = new(currentPath);

                // 向上查找，直到找到解决方案目录（包含.sln文件）
                while (dir != null)
                {
                    if (dir.GetFiles("*.sln").Length > 0)
                    {
                        // 找到解决方案根目录，定位MainUI项目
                        string mainUIPath = Path.Combine(dir.FullName, "MainUI", "Procedure", "Test");
                        if (Directory.Exists(Path.Combine(dir.FullName, "MainUI")))
                        {
                            return mainUIPath;
                        }
                    }
                    dir = dir.Parent;
                }

                // 相对路径
                return Path.GetFullPath(Path.Combine(currentPath, "..", "..", "..", "Procedure", "Test"));
            }
            catch
            {
                return Path.Combine(Directory.GetCurrentDirectory(), "Procedure", "Test");
            }
        }

        /// <summary>
        /// 检测并创建目录
        /// </summary>
        private void EnsureDirectoryExists()
        {
            if (!Directory.Exists(_testClassPath))
            {
                Directory.CreateDirectory(_testClassPath);
            }
        }

        /// <summary>
        /// 根据EntityClassName创建测试类文件
        /// </summary>
        public bool CreateTestClassByEntityClassName(string entityClassName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(entityClassName))
                    return false;

                string fileName = $"{entityClassName}.cs";
                string filePath = Path.Combine(_testClassPath, fileName);

                if (File.Exists(filePath))
                    return true;

                string classContent = GenerateTestClassContent(entityClassName);
                File.WriteAllText(filePath, classContent, Encoding.UTF8);

                NlogHelper.Default.Info($"成功创建测试类文件：{fileName}");
                return true;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error($"创建测试类文件失败：{entityClassName}", ex);
                return false;
            }
        }

        /// <summary>
        /// 根据EntityClassName删除测试类文件
        /// </summary>
        public bool DeleteTestClassByEntityClassName(string entityClassName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(entityClassName))
                    return false;

                string filePath = Path.Combine(_testClassPath, $"{entityClassName}.cs");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    NlogHelper.Default.Info($"成功删除测试类文件：{entityClassName}.cs");
                }
                return true;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error($"删除测试类文件失败：{entityClassName}", ex);
                return false;
            }
        }

        /// <summary>
        /// 根据EntityClassName重命名测试类文件
        /// </summary>
        public bool RenameTestClassByEntityClassName(string oldEntityClassName, string newEntityClassName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(oldEntityClassName) || string.IsNullOrWhiteSpace(newEntityClassName))
                    return false;

                if (oldEntityClassName == newEntityClassName)
                    return true;

                string oldFilePath = Path.Combine(_testClassPath, $"{oldEntityClassName}.cs");
                string newFilePath = Path.Combine(_testClassPath, $"{newEntityClassName}.cs");

                if (File.Exists(oldFilePath))
                {
                    string content = File.ReadAllText(oldFilePath, Encoding.UTF8);
                    content = content.Replace($"class {oldEntityClassName}", $"class {newEntityClassName}");

                    File.WriteAllText(newFilePath, content, Encoding.UTF8);
                    File.Delete(oldFilePath);

                    NlogHelper.Default.Info($"成功重命名测试类文件：{oldEntityClassName} -> {newEntityClassName}");
                }
                else
                {
                    CreateTestClassByEntityClassName(newEntityClassName);
                }

                return true;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error($"重命名测试类文件失败：{oldEntityClassName} -> {newEntityClassName}", ex);
                return false;
            }
        }

        /// <summary>
        /// 实体类模板
        /// </summary>
        /// <param name="entityClassName"></param>
        /// <returns></returns>
        private static string GenerateTestClassContent(string entityClassName)
        {
            return $@"namespace MainUI.Procedure.Test
{{
    public class {entityClassName} : BaseTest
    {{
        public override async Task<bool> Execute(CancellationToken cancellationToken)
        {{
            
            try
            {{
                // 执行测试逻辑
                await Task.Delay(1000, cancellationToken);
                return true;
            }}
            catch (Exception ex)
            {{
                NlogHelper.Default.Error($""{entityClassName}：{{ex.Message}}"");
                throw new($""{entityClassName}：{{ex.Message}}"");
            }}
            finally
            {{
                // 试验结束后的清理操作
            }}
        }}
    }}
}}
";
        }
    }
}