using System;
using System.Windows;

namespace xfab_app.ContentContrls
{
    public partial class TextBoxDemo : Window
    {
        public TextBoxDemo()
        {
            InitializeComponent();
            tbSettingText.Text = "Initial text contents of the TextBox.";
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            // this.tbSettingText.Text = "hello world";
            string selectedText = this.tbSettingText.SelectedText;
            int selectedIndex = this.tbSettingText.SelectionStart;
            Console.WriteLine(selectedText);
            Console.WriteLine(selectedIndex);
        }
    }
}