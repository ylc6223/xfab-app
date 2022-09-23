using System.Windows;
using System.Windows.Controls;

namespace xfab_app.WpfBinding
{
    public partial class Index : Window
    {
        public Index()
        {
            InitializeComponent();
        }

        private void OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            a.Text = slider.Value.ToString();
            b.Text = slider.Value.ToString();
            c.Text = slider.Value.ToString();
            // 实现数据双向绑定
        }

        private void A_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(a.Text, out double result))
                slider.Value = result;
        }
    }
}