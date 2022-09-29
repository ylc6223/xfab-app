using jerry.wpf.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace xfab_app.ContentContrls
{
    /// <summary>
    /// WindowFrame.xaml 的交互逻辑
    /// </summary>
    public partial class WindowFrame : Window
    {
        public WindowFrame()
        {
            InitializeComponent();
        }

        private void gotoBaidu(object sender, RoutedEventArgs e)
        {
            //使用source属性进行跳转
            //this.islandFrame.Source = new Uri("https://www.bilibili.com/",UriKind.Absolute);

            //使用api编程式跳转
            //this.islandFrame.Navigate(@"..\Pages\Mypage.xaml");
            MyPage mp = new MyPage("参数");
            this.islandFrame.Navigate(mp);

            //使用uri跳转
            //this.islandFrame.Navigate(new Uri("https://www.bilibili.com/", UriKind.Absolute));

            //携带参数进行跳转
            //this.islandFrame.Navigate(new Uri("https://www.bilibili.com/", UriKind.Absolute),"我是个参数");
        }

        private void islandFrame_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            object extraData= e.ExtraData;
            Console.WriteLine(extraData);
        }
    }
}
