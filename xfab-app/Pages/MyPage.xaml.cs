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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jerry.wpf.Pages
{
    /// <summary>
    /// MyPage.xaml 的交互逻辑
    /// </summary>
    public partial class MyPage : Page
    {
        private string param;
        public MyPage()
        {
            InitializeComponent();
        }
        public MyPage(string _param):this()
        {
            this.param = _param;
            Console.WriteLine(this.param);
        }
    }
}
