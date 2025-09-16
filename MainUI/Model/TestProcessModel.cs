using AntdUI;
using FreeSql.DataAnnotations;

namespace MainUI.Model
{
    [Table(Name = "TestProcess")]
    public class TestProcessModel : NotifyProperty
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }

        public string ProcessName { get; set; }

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
