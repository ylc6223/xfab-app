using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace xfab_app.DataTemplate
{
    public partial class DataBinding : Window
    {
        public DataBinding()
        {
            InitializeComponent();
            // List<int> test = new List<int>();
            List<MyColor> test = new List<MyColor>();
            // for (int i = 0; i < 10; i++)
            // {
            //     // test.Add(i);
            // }
            
            /*
             *
#41A85F#00A885#3D8EB9#553982#28324E#BB3626
#F7DA64#FBA026#EB6B56#EFEFEF#A8B8B9#A38F84
#FAC51C#F37934#D14841#D1D5D8#919FA0
             *
             */
            test.Add(new MyColor()
            {
                Code = "#61BD6D",
                Name = "黄绿色"
            });
            test.Add(new MyColor()
            {
                Code = "#1ABC9C",
                Name = "青灰色"
            });
            test.Add(new MyColor()
            {
                Code = "#54ACD2",
                Name = "浅蓝色"
            });
            test.Add(new MyColor()
            {
                Code = "#9365B8",
                Name = "紫色"
            });
            test.Add(new MyColor()
            {
                Code = "#475577",
                Name = "暗蓝色"
            });
            test.Add(new MyColor()
            {
                Code = "#DD4230",
                Name = "红色"
            });

            list.ItemsSource = test;
            // for (int i = 0; i < 10; i++)
            // {
            //     list.Items.Add(new ListBoxItem()
            //     {
            //         Content = new TextBlock()
            //         {
            //             Text = i.ToString()
            //         }
            //     });
            // }
        }
    }

    public class MyColor
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}