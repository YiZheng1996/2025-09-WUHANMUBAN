using AntdUI;
using FreeSql.DataAnnotations;

namespace MainUI.Model
{
    /// <summary>
    /// 测试流程实体类
    /// </summary>
    [Table(Name = "TestProcess")]
    public class TestProcessModel : NotifyProperty
    {
        /// <summary>
        /// ID 主键，自增
        /// </summary>
        [Column(IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }

        /// <summary>
        /// 流程项点名称
        /// </summary>
        public string ProcessName { get; set; }

        /// <summary>
        /// 实体类名称，用于反射创建实例
        /// </summary>
        public string EntityClassName { get; set; }

        /// <summary>
        /// 是否在测试中可见
        /// </summary>
        public bool IsVisible { get; set; }

        private bool _enable;
        [Column(IsIgnore = true)]
        public bool Enable
        {
            get => _enable;
            set
            {
                if (_enable == value) return;
                _enable = value;
                OnPropertyChanged(nameof(Enable));
            }
        }

    }
}
