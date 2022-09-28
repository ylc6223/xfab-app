using System;
using  System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace xfab_app.Command
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            ShowCommand = new MyCommand(Show);
        }
        public MyCommand ShowCommand { get; set; }
        public void Show()
        {
            MessageBox.Show("点击了按钮");
        }
    }
}