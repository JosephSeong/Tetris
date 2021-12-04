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

namespace Tetris
{
    /// <summary>
    /// Join.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Join : Window
    {
        public Join()
        {
            InitializeComponent();
        }
        AccManager accManager = new AccManager();

        accInfo newAcc = new accInfo();

        /// <summary>
        /// ID 사용 가능 여부 검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDCheck(object sender, RoutedEventArgs e)
        {
            accInfo? targetAcc = accManager.GetAccInfo(IDBox.Text);

            SolidColorBrush txtColor = new SolidColorBrush();

            if (targetAcc != null)
            {
                txtColor.Color = Colors.OrangeRed;
                IDCheckNotice.Foreground = txtColor;
                IDCheckNotice.Text = "이미 존재하는 아이디 입니다.";
            }
            else if (IsAnySpace(IDBox.Text))
            {
                txtColor.Color = Colors.OrangeRed;
                IDCheckNotice.Foreground = txtColor;
                IDCheckNotice.Text = "아이디에는 공백을 포함할 수 없습니다.";
            }
            else if (IDBox.Text.Length > 10)
            {
                txtColor.Color = Colors.OrangeRed;
                IDCheckNotice.Foreground = txtColor;
                IDCheckNotice.Text = "아이디는 10자를 넘을 수 없습니다.";
            }
            else if (!IsStringLetterOrDigit(IDBox.Text))
            {
                txtColor.Color = Colors.OrangeRed;
                IDCheckNotice.Foreground = txtColor;
                IDCheckNotice.Text = "아이디는 영문/숫자 조합으로만 가능합니다.";
            }
            else if (string.IsNullOrEmpty(IDBox.Text))
            {
                IDCheckNotice.Text = string.Empty;
            }
            else
            {
                txtColor.Color = Colors.LimeGreen;
                IDCheckNotice.Foreground = txtColor;
                IDCheckNotice.Text = "사용 가능한 아이디 입니다.";

                IDBox.IsReadOnly = true;

                IDCheckButton.Content = "ID 재입력";
                IDCheckButton.Click += new RoutedEventHandler(RetypeButtonClick);
                IDCheckButton.Click -= IDCheck;

                newAcc.ID = IDBox.Text;
            }
        }

        /// <summary>
        /// IDBox의 읽기 전용을 해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetypeButtonClick(object sender, RoutedEventArgs e)
        {
            IDBox.IsReadOnly = false;
            IDBox.Text = string.Empty;

            IDCheckNotice.Text = string.Empty;

            IDCheckButton.Content = "ID 사용 가능 여부 확인";
            IDCheckButton.Click -= RetypeButtonClick;
            IDCheckButton.Click += IDCheck;
        }

        /// <summary>
        /// 문자열이 영문이나 10진수로 이루어졌는지 확인
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private bool IsStringLetterOrDigit(string str)
        {
            foreach (char c in str)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
                        return false;
                }
                else
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 해당 문자열의 공백 문자 유무를 검사
        /// </summary>
        /// <returns></returns>
        private bool IsAnySpace(string str)
        {
            foreach (char c in str)
            {
                if (c == ' ')
                    return true;
            }

            return false;
        }

        /// <summary>
        /// PWBox.Password의 값이 변경될 때 마다
        /// PWBox.Password와 PWconfirmBox.Password가 동일한지 검사 후 결과를 PWMatchNotice.Text로 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PWconfirmBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            SolidColorBrush txtColor = new SolidColorBrush();

            if (PWBox.Password == string.Empty)
            {
                txtColor.Color = Colors.OrangeRed;
                PWMatchNotice.Foreground = txtColor;
                PWMatchNotice.Text = string.Empty;
            }
            else if (PWBox.Password.Equals(PWconfirmBox.Password, StringComparison.Ordinal))
            {
                txtColor.Color = Colors.LimeGreen;
                PWMatchNotice.Foreground = txtColor;
                PWMatchNotice.Text = "비밀번호가 일치합니다.";
                newAcc.PW = PWBox.Password;
            }
            else
            {
                txtColor.Color = Colors.OrangeRed;
                PWMatchNotice.Foreground = txtColor;
                PWMatchNotice.Text = "비밀번호가 일치하지 않습니다.";
            }
        }

        /// <summary>
        /// birthdayBox.Text의 값이 변경될 때 마다 값의 확인 후 결과를 birthdayBoxNotice.Text로 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void birthdayBox_KeyUp(object sender, KeyEventArgs e)
        {
            SolidColorBrush txtColor = new SolidColorBrush();

            foreach (char c in birthdayBox.Text)
            {
                if (char.IsDigit(c) && birthdayBox.Text.Length == 8)
                {
                    txtColor.Color = Colors.LimeGreen;
                    birthdayBoxNotice.Foreground = txtColor;
                }
                else
                {
                    txtColor.Color = Colors.OrangeRed;
                    birthdayBoxNotice.Foreground = txtColor;
                    return;
                }
            }
        }

        /// <summary>
        /// phoneNumBox.Text의 값이 변경될 때 마다 값의 확인 후 결과를 phoneNumBoxNotice.Text로 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phoneNumBox_KeyUp(object sender, KeyEventArgs e)
        {
            SolidColorBrush txtColor = new SolidColorBrush();

            foreach (char c in phoneNumBox.Text)
            {
                if (char.IsDigit(c) && phoneNumBox.Text.Length == 11)
                {
                    txtColor.Color = Colors.LimeGreen;
                    phoneNumBoxNotice.Foreground = txtColor;
                }
                else
                {
                    txtColor.Color = Colors.OrangeRed;
                    phoneNumBoxNotice.Foreground = txtColor;
                    return;
                }
            }
        }

        /// <summary>
        /// 최종적으로 각 textbox의 값을 확인 한 뒤 해당 되는 오류 메세지 출력
        /// 확인이 정상적으로 끝나면 각 값을 저장하고 창 닫음.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text) ||
                string.IsNullOrEmpty(birthdayBox.Text) ||
                string.IsNullOrEmpty(phoneNumBox.Text))
            {
                MessageBox.Show("모든 필수 항목을 작성해주십시오.");
                return;
            }
            else if (IDBox.IsReadOnly == false)
            {
                IDCheckNotice.Text = string.Empty;
                MessageBox.Show("ID를 확인을 해주세요.");
                return;
            }
            else if (((SolidColorBrush)PWMatchNotice.Foreground).Color.Equals(Colors.OrangeRed))
            {
                MessageBox.Show("비밀번호를 확인해주세요.");
                return;
            }
            else if (!NameCheck())
            {
                MessageBox.Show("성명을 확인해주세요");
                return;
            }
            else if (((SolidColorBrush)birthdayBoxNotice.Foreground).Color.Equals(Colors.OrangeRed))
            {
                MessageBox.Show("생년월일을 확인해주세요.");
                return;
            }
            else if (((SolidColorBrush)phoneNumBoxNotice.Foreground).Color.Equals(Colors.OrangeRed))
            {
                MessageBox.Show("전화번호를 확인해주세요.");
                return;
            }
            else
            {
                newAcc.name = nameBox.Text;
                newAcc.birthday = int.Parse(birthdayBox.Text);
                newAcc.phoneNum = int.Parse(phoneNumBox.Text);
                newAcc.address = addressBox.Text;
            }
            
            if (MessageBox.Show(this, "가입이 완료되었습니다.") == MessageBoxResult.OK);
            Window win = new Login();
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Show();
            Close();
        }

        /// <summary>
        /// nameBox.Text의 문자열이 한글/영어만 포함하는지를 확인
        /// </summary>
        /// <returns></returns>
        private bool NameCheck()
        {
            foreach (char c in nameBox.Text)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Window win = new Login();
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Show();
            this.Close();
        }
    }
}