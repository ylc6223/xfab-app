using System.Windows;
using System.Windows.Input;

namespace xfab_app.ContentContrls
{
    public partial class ButtonDemo : Window
    {
        public ButtonDemo()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("click");
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("mousedown");
        }

        private void UIElement_OnMouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("mousemove");
        }
    }
}