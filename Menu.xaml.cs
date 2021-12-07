using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Media.Effects;
using System.Windows.Threading;

namespace Tetris
{
    /// <summary>
    /// Menu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Menu : Window
    {
        MediaElement media = new MediaElement();                                        // 배경음악

        public Menu()
        {
            InitializeComponent();

            media.Source = new Uri(@"C:\Users\USER\Desktop\C#\Training\Tetris\Sound\Tetris_main.mp3", UriKind.Absolute);
            LayoutRoot.Children.Add(media);
            media.LoadedBehavior = MediaState.Manual;
            media.Play();
        }

        private void Button_Rank(object sender, RoutedEventArgs e)                      // 랭킹
        {
            media.Play();
            Window win = new Rank();
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Show();
            Close();
        }

        private void Button_Play(object sender, RoutedEventArgs e)                      // 게임시작
        {
            media.Pause();
            Window win = new MainWindow();
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Show();
            Close();
        }

        private void Button_Howto(object sender, RoutedEventArgs e)                     // 게임하는 법
        {
            Window win = new HowTo();
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Show();
            Close();
            media.Play();
        }

        void BacktoLogin(object sender, RoutedEventArgs e)                              // 메뉴로 돌아가기
        {
            Window win = new Login();
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Show();
            Close();
        }
    }
}
