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

namespace Tetris
{
    /// <summary>
    /// Login.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text) || string.IsNullOrEmpty(PwTextBox.Text))
            {
                MessageBox.Show("아이디와 비밀번호를 정확히 입력해주세요", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string IdCheck = string.Format("당신은 {0} 님이 맞습니까?", IdTextBox.Text);
            MessageBoxResult nameMessageBoxResult = MessageBox.Show(IdCheck, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            if (nameMessageBoxResult == MessageBoxResult.No)
            {
                return;
            }
            this.DialogResult = true;
        }

        private void Join_Btn_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/Join.xaml", UriKind.Relative));
            Window win = new Join();
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Show();
            Close();
        }
    }
}
