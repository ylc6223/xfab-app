using System.Windows;

namespace xfab_app.Codes
{
    public partial class Tutorial : Window
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            // 1.判断文本框内容是否为空
            // 2.判断列表中是否已存在同名
            // 3.将名称添加到列表框中  
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                // 清空输入框
                txtName.Clear();
            }
        }
    }
}