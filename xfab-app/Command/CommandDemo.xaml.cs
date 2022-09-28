using System.Windows;

namespace xfab_app.Command
{
    public partial class CommandDemo : Window
    {
        public CommandDemo()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("点击了按钮");
        }
    }
}