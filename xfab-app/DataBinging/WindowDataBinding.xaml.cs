using System.Windows;
using xfab_app.DataBinging.SDKSample;

namespace xfab_app.DataBinging
{
    public partial class WindowDataBinding : Window
    {
        public WindowDataBinding()
        {
            InitializeComponent();
        }

        private void WindowDataBinding_OnLoaded(object sender, RoutedEventArgs e)
        {
            myLabel.DataContext = new MyData()
            {
                Title = "我是个标题"
            };
        }
    }
}