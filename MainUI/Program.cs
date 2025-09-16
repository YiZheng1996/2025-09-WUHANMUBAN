﻿using System.Configuration;

namespace MainUI
{
    static class Program
    {
        /// <summary>  
        /// 应用程序的主入口点
        /// </summary>  
        [STAThread]
        static void Main()
        {
            try
            {
                // 1. 初始化数据库
                InitializeDatabase();

                // 2. 检查单例运行
                EnsureSingleInstance();

                // 3. 配置应用程序
                ConfigureApplication();

                // 4. 显示登录界面并启动主程序
                RunApplication();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"应用程序启动失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        #region 初始化方法

        /// <summary>
        /// 初始化数据库连接
        /// </summary>
        private static void InitializeDatabase()
        {
            VarHelper.fsql = new FreeSql.FreeSqlBuilder()
                //.UseMonitorCommand(cmd => Trace.WriteLine($"Sql：{cmd.CommandText}"))
                .UseConnectionString(FreeSql.DataType.Sqlite,
                    ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString)
                .Build();

            if (!VarHelper.fsql.Ado.ExecuteConnectTest())
                throw new Exception("Sqlite数据库连接失败");
        }

        /// <summary>
        /// 确保只运行一个应用程序实例
        /// </summary>
        private static void EnsureSingleInstance()
        {
            string softname = Application.ProductName;
            VarHelper.SoftName = softname;

            using var mutex = new Mutex(true, softname, out bool createdNew);

            if (!createdNew)
            {
                MessageBox.Show("只能运行一个程序！", "请确定",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// 配置应用程序基本设置
        /// </summary>
        private static void ConfigureApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        /// <summary>
        /// 运行应用程序主逻辑
        /// </summary>
        private static void RunApplication()
        {
            // 创建并配置登录窗体
            var login = CreateLoginForm();

            DialogResult loginResult = login.ShowDialog();
            if (loginResult == DialogResult.OK)
            {
                StartMainApplication();
            }
        }

        /// <summary>
        /// 创建登录窗体
        /// </summary>
        private static frmLogin CreateLoginForm()
        {
            var login = new frmLogin
            {
                lblSoftName = { Text = "武汉软件通用模板" },
                Icon = new Icon("ico.ico")
            };

            // 设置登录界面图片
            SetLoginImage(login);
            return login;
        }

        /// <summary>
        /// 设置登录界面图片
        /// </summary>
        private static void SetLoginImage(frmLogin login)
        {
            try
            {
                var files = Directory.GetFiles(Application.StartupPath, "ico.*");
                var imageFile = files.FirstOrDefault(x => !x.Contains("ico.ico"));

                if (imageFile != null)
                {
                    using var image = Image.FromFile(imageFile);
                    login.Logo.Image = new Bitmap(image); // 创建副本避免文件锁定
                }
            }
            catch (Exception ex)
            {
                // 图片加载失败不应该中断程序启动
                NlogHelper.Default.Warn($"加载登录界面图片失败：{ex.Message}");
            }
        }

        /// <summary>
        /// 启动主应用程序
        /// </summary>
        private static void StartMainApplication()
        {
            try
            {
                // 连接OPC
                OPCHelper.Connect();

                // 获取主窗体
                frmMainMenu mainForm = new();

                // 运行主程序
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("主应用程序启动失败：", ex);
                MessageBox.Show($"主应用程序启动失败：{ex.Message}", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}