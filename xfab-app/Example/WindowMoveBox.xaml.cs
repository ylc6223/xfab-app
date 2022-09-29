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

namespace jerry.wpf.Example
{
    /// <summary>
    /// WindowMoveBox.xaml 的交互逻辑
    /// </summary>
    public partial class WindowMoveBox : Window
    {
        public WindowMoveBox()
        {
            InitializeComponent();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            //首先判断按键的方位，比如上下左右
            //向上移动每次减3 向下移动每次加3 向左移动每次减1 向右移动每次加1
            //获取白色的border元素
            Border curborder = null;
            UIElementCollection children = gridContent.Children;

            //foreach (UIElement child in children)
            //{
            //    if(child is Border)
            //        {
            //        if (((child as Border).Background as SolidColorBrush).Color.Equals(Colors.White))
            //        {
            //            curborder = child as Border;
            //        }
            //        (child as Border).Background = new SolidColorBrush(Colors.Transparent);
            //        }
            //}
            //    string name = curborder.Name;
            //    int index = Convert.ToInt32(name.Replace("b", ""));
            //if (e.Key.Equals(Key.Up))
            //{
            //        index = index-3>=1?index-3:index;
            //}
            //else if (e.Key.Equals(Key.Down))
            //{
            //        index = index + 3 <= 9 ? index + 3 : index;
            //}

            //else if (e.Key.Equals(Key.Left))
            // {
            //        index = index -1 >= 1 ? index -1 : index;
            // }
            //else if(e.Key.Equals(Key.Right))
            //{
            //        index = index + 1 <= 1 ? index + 1 : index;
            //}
            //object control = gridContent.FindName("b" + index);
            //if (control != null)
            //{
            //    (control as Border).Background = new SolidColorBrush(Colors.White);
            //}
            for(int i = 0; i < children.Count; i++)
            {
                if (children[i] is Border)
                {
                    if(((children[i] as Border).Background as SolidColorBrush).Color.Equals(Colors.White))
                    {
                        curborder = children[i] as Border;
                    }
                    (children[i] as Border).Background = new SolidColorBrush(Colors.Transparent);
                }
            }
            string name = curborder.Name;
            int index = Convert.ToInt32(name.Replace("b", ""));
            if (e.Key.Equals(Key.Up))
            {
                index = index - 3 >= 1 ? index - 3 : index;
            }
            else if (e.Key.Equals(Key.Down))
            {
                index= index + 3 <= 9 ? index + 3 : index;
            }
            else if (e.Key.Equals(Key.Left))
            {
                index = index - 1 >= 1 ? index - 1 : index;
            }
            else if (e.Key.Equals(Key.Right))
            {
                index = index + 1 <= 9 ? index + 1 : index;
            }
            object control = gridContent.FindName("b" + index);
            if (control != null)
            {
                (control as Border).Background = new SolidColorBrush(Colors.White);
            }
        }
    }
}
