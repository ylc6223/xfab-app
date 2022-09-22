using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace xfab_app.DataTemplate
{
    public partial class DataBinding1 : Window
    {
        public DataBinding1()
        {
            InitializeComponent();
            List<MyColor1> test = new List<MyColor1>();
            test.Add(new MyColor1()
            {
                Code = "#61BD6D",
                Name = "黄绿色"
            });
            test.Add(new MyColor1()
            {
                Code = "#1ABC9C",
                Name = "青灰色"
            });
            test.Add(new MyColor1()
            {
                Code = "#54ACD2",
                Name = "浅蓝色"
            });
            test.Add(new MyColor1()
            {
                Code = "#9365B8",
                Name = "紫色"
            });
            test.Add(new MyColor1()
            {
                Code = "#475577",
                Name = "暗蓝色"
            });
            test.Add(new MyColor1()
            {
                Code = "#DD4230",
                Name = "红色"
            });
            Grid.ItemsSource = test;
        }
    }
    public class MyColor1
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}