using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace xfab_app.ContentContrls
{
    public partial class CheckBoxDemo : Window
    {
        public CheckBoxDemo()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            UIElementCollection childrens = wrap.Children;
            StringBuilder sbf = new StringBuilder("我的选课为:");  
            foreach (UIElement child in childrens)
            {
                if (child is CheckBox && (child as CheckBox).IsChecked.Value)
                {
                    sbf.Append((child as CheckBox).Content + ",");
                }
            }

            MessageBox.Show(sbf.ToString());
        }
    }
}