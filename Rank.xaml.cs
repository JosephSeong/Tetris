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
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Tetris
{
    /// <summary>
    /// Rank.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Rank : Window
    {
        int i = 0;
        string _xmlFile = "Score\\Score.xml";
        //ProductsFactory info = new ProductsFactory();

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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        //    dataGridView.ItemsSource = info.FindProducts(textBox.Text);
        }

        private void Btn_Refresh(object sender, RoutedEventArgs e)                  // 점수 새로고침
        {
            i++;
            XDocument doc = XDocument.Load(_xmlFile);
           
            //read
            var result = doc.Descendants("Contactiks").Select(x => new
            {
                Name = x.Element("Name").Value,
                Score = x.Element("Score").Value,
                Time = x.Element("Time").Value
            });
            dataGridView.ItemsSource = result;
        }
    }
}
