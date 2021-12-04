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
    /// Rank.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Rank : Window
    {
        public Rank()
        {
            InitializeComponent();
        }

        void BacktoMenu(object sender, RoutedEventArgs e)                           // 메뉴로 돌아가기
        {
            Window win = new Menu();
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Show();
            Close();
        }
    }
}
