using System.Windows;

namespace xfab_app.WpfBinding
{
    public partial class Index4 : Window
    {
        public Index4()
        {
            InitializeComponent();
            this.DataContext = new Test()
            {
                Name = "jerry"
            };
        }
    }
}