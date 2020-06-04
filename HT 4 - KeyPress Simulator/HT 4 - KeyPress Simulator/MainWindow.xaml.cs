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
using System.Threading;

namespace HT_4___KeyPress_Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string alphabet = "qwertyuiopasdfghjklzxcvbnm";
        string gen;
        public MainWindow()
        {
            InitializeComponent();
            gen = GetRandomString(alphabet, 70);
            lblStatic.Content = gen;
        }

        private string GetRandomString(string alphabet, int length)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder(length - 1);
            int position = 0;

            for (int i = 0; i < length; i++)
            {
                position = random.Next(0, alphabet.Length - 1);
                sb.Append(alphabet[position]);
            }

            return sb.ToString();
        }
        


        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            Thread.Sleep(1000);

        }

        private void Mouse_Up(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            ChangeToDefaultColor(button);
        }

        private void Mouse_Down(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            lblUserPress.Content += button.Content.ToString();
        }

        private void ChangeToPinkColor(Button button)=>
            button.Background = Brushes.HotPink;
        private void ChangeToYellowColor(Button button)=>
            button.Background = Brushes.LightGoldenrodYellow;
        private void ChangeToGreenColor(Button button) =>
           button.Background = Brushes.LightGreen;
        private void ChangeToBlueColor(Button button) =>
           button.Background = Brushes.SkyBlue;
        private void ChangeToVioletColor(Button button) =>
           button.Background = Brushes.Violet;
        private void ChangeToOrangeColor(Button button) =>
           button.Background = Brushes.Orange;
        private void ChangeToGrayColor(Button button) =>
           button.Background = Brushes.Gray;
        private void ChangeToDefaultColor(Button button)=>
            button.Background = Brushes.LightGray;

        int counter = 1;
        string currentText;
        private void CharPress(Button button)
        {
            if (counter == gen.Length+1)
                return;

            currentText = gen.Substring(0, counter);
            lblUserPress.Content += button.Content.ToString();
            lblDynamic.Content = currentText;
            lblUserPress.Background = Brushes.LightGreen;
            counter++;
        }
        private void Key_Down(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.OemTilde:
                    ChangeToPinkColor(btnTilde);
                    CharPress(btnTilde);
                    break;
                case Key.D1:
                    ChangeToPinkColor(btn1);
                    CharPress(btn1);
                    break;
                case Key.D2:
                    ChangeToPinkColor(btn2);
                    CharPress(btn2);
                    break;
                case Key.D3:
                    ChangeToYellowColor(btn3);
                    CharPress(btn3);
                    break;
                case Key.D4:
                    ChangeToGreenColor(btn4);
                    CharPress(btn4);
                    break;
                case Key.D5:
                    ChangeToBlueColor(btn5);
                    CharPress(btn5);
                    break;
                case Key.D6:
                    ChangeToBlueColor(btn6);
                    CharPress(btn6);
                    break;
                case Key.D7:
                    ChangeToVioletColor(btn7);
                    CharPress(btn7);
                    break;
                case Key.D8:
                    ChangeToVioletColor(btn8);
                    CharPress(btn8);
                    break;
                case Key.D9:
                    ChangeToPinkColor(btn9);
                    CharPress(btn9);
                    break;
                case Key.D0:
                    ChangeToYellowColor(btn0);
                    CharPress(btn0);
                    break;
                case Key.OemMinus:
                    ChangeToGreenColor(btnMinus);
                    CharPress(btnMinus);
                    break;
                case Key.OemPlus:
                    ChangeToGreenColor(btnEqual);
                    CharPress(btnEqual);
                    break;
                case Key.Back:
                    ChangeToGrayColor(btnBackSpace);
                    break;
                case Key.Tab:
                    ChangeToGrayColor(btnTab);
                    break;
                case Key.Q:
                    ChangeToPinkColor(btnQ);
                    CharPress(btnQ);
                    break;
                case Key.W:
                    ChangeToYellowColor(btnW);
                    CharPress(btnW);
                    break;
                case Key.E:
                    ChangeToGreenColor(btnE);
                    CharPress(btnE);
                    break;
                case Key.R:
                    ChangeToBlueColor(btnR);
                    CharPress(btnR);
                    break;
                case Key.T:
                    ChangeToBlueColor(btnT);
                    CharPress(btnT);
                    break;
                case Key.Y:
                    ChangeToVioletColor(btnY);
                    CharPress(btnY);
                    break;
                case Key.U:
                    ChangeToVioletColor(btnU);
                    CharPress(btnU);
                    break;
                case Key.I:
                    ChangeToYellowColor(btnI);
                    CharPress(btnI);
                    break;
                case Key.O:
                    ChangeToYellowColor(btnO);
                    CharPress(btnO);
                    break;
                case Key.P:
                    ChangeToGreenColor(btnP);
                    CharPress(btnP);
                    break;
                case Key.OemOpenBrackets:
                    ChangeToGreenColor(btnLGap);
                    CharPress(btnLGap);
                    break;
                case Key.OemCloseBrackets:
                    ChangeToGreenColor(btnRGap);
                    CharPress(btnRGap);
                    break;
                case Key.Oem5:
                    ChangeToGreenColor(btnSlash);
                    CharPress(btnSlash);
                    break;
                case Key.CapsLock:
                    ChangeToGrayColor(btnCapsLock);
                    break;
                case Key.A:
                    ChangeToPinkColor(btnA);
                    CharPress(btnA);
                    break;
                case Key.S:
                    ChangeToYellowColor(btnS);
                    CharPress(btnS);
                    break;
                case Key.D:
                    ChangeToGreenColor(btnD);
                    CharPress(btnD);
                    break;
                case Key.F:
                    ChangeToBlueColor(btnF);
                    CharPress(btnF);
                    break;
                case Key.G:
                    ChangeToBlueColor(btnG);
                    CharPress(btnG);
                    break;
                case Key.H:
                    ChangeToVioletColor(btnH);
                    CharPress(btnH);
                    break;
                case Key.J:
                    ChangeToVioletColor(btnJ);
                    CharPress(btnJ);
                    break;
                case Key.K:
                    ChangeToPinkColor(btnK);
                    CharPress(btnK);
                    break;
                case Key.L:
                    ChangeToYellowColor(btnL);
                    CharPress(btnL);
                    break;
                case Key.Oem1:
                    ChangeToGreenColor(btnPointComa);
                    CharPress(btnPointComa);
                    break;
                case Key.Oem7:
                    ChangeToGreenColor(btnUpComa);
                    CharPress(btnUpComa);
                    break;
                case Key.Return:
                    ChangeToGrayColor(btnEnter);
                    break;
                case Key.LeftShift:
                    ChangeToGrayColor(btnLShift);
                    break;
                case Key.Z:
                    ChangeToPinkColor(btnZ);
                    CharPress(btnZ);
                    break;
                case Key.X:
                    ChangeToYellowColor(btnX);
                    CharPress(btnX);
                    break;
                case Key.C:
                    ChangeToGreenColor(btnC);
                    CharPress(btnC);
                    break;
                case Key.V:
                    ChangeToBlueColor(btnV);
                    CharPress(btnV);
                    break;
                case Key.B:
                    ChangeToBlueColor(btnB);
                    CharPress(btnB);
                    break;
                case Key.N:
                    ChangeToVioletColor(btnN);
                    CharPress(btnN);
                    break;
                case Key.M:
                    ChangeToVioletColor(btnM);
                    CharPress(btnM);
                    break;
                case Key.OemComma:
                    ChangeToPinkColor(btnComma);
                    CharPress(btnComma);
                    break;
                case Key.OemEnlw:
                    ChangeToYellowColor(btnPoint);
                    CharPress(btnPoint);
                    break;
                case Key.Oem2:
                    ChangeToGreenColor(btnBackSlash);
                    CharPress(btnBackSlash);
                    break;
                case Key.RightShift:
                    ChangeToGrayColor(btnRShift);
                    break;
                case Key.LeftCtrl:
                    ChangeToGrayColor(btnLCtrl);
                    break;
                case Key.LWin:
                    ChangeToGrayColor(btnLWin);
                    break;
                case Key.LeftAlt:
                    ChangeToGrayColor(btnLAlt);
                    break;
                case Key.Space:
                    ChangeToOrangeColor(btnSpace);
                    //CharPress(btnSpace);
                    break;
                default:
                    break;
            }
        }

        private void Key_Up(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.OemTilde:
                    ChangeToDefaultColor(btnTilde);
                    break;
                case Key.D1:
                    ChangeToDefaultColor(btn1);
                    break;
                case Key.D2:
                    ChangeToDefaultColor(btn2);
                    break;
                case Key.D3:
                    ChangeToDefaultColor(btn3);
                    break;
                case Key.D4:
                    ChangeToDefaultColor(btn4);
                    break;
                case Key.D5:
                    ChangeToDefaultColor(btn5);
                    break;
                case Key.D6:
                    ChangeToDefaultColor(btn6);
                    break;
                case Key.D7:
                    ChangeToDefaultColor(btn7);
                    break;
                case Key.D8:
                    ChangeToDefaultColor(btn8);
                    break;
                case Key.D9:
                    ChangeToDefaultColor(btn9);
                    break;
                case Key.D0:
                    ChangeToDefaultColor(btn0);
                    break;
                case Key.OemMinus:
                    ChangeToDefaultColor(btnMinus);
                    break;
                case Key.OemPlus:
                    ChangeToDefaultColor(btnEqual);
                    break;
                case Key.Back:
                    ChangeToDefaultColor(btnBackSpace);
                    break;
                case Key.Tab:
                    ChangeToDefaultColor(btnTab);
                    break;
                case Key.Q:
                    ChangeToDefaultColor(btnQ);
                    break;
                case Key.W:
                    ChangeToDefaultColor(btnW);
                    break;
                case Key.E:
                    ChangeToDefaultColor(btnE);
                    break;
                case Key.R:
                    ChangeToDefaultColor(btnR);
                    break;
                case Key.T:
                    ChangeToDefaultColor(btnT);
                    break;
                case Key.Y:
                    ChangeToDefaultColor(btnY);
                    break;
                case Key.U:
                    ChangeToDefaultColor(btnU);
                    break;
                case Key.I:
                    ChangeToDefaultColor(btnI);
                    break;
                case Key.O:
                    ChangeToDefaultColor(btnO);
                    break;
                case Key.P:
                    ChangeToDefaultColor(btnP);
                    break;
                case Key.OemOpenBrackets:
                    ChangeToDefaultColor(btnLGap);
                    break;
                case Key.OemCloseBrackets:
                    ChangeToDefaultColor(btnRGap);
                    break;
                case Key.Oem5:
                    ChangeToDefaultColor(btnSlash);
                    break;
                case Key.CapsLock:
                    ChangeToDefaultColor(btnCapsLock);
                    break;
                case Key.A:
                    ChangeToDefaultColor(btnA);
                    break;
                case Key.S:
                    ChangeToDefaultColor(btnS);
                    break;
                case Key.D:
                    ChangeToDefaultColor(btnD);
                    break;
                case Key.F:
                    ChangeToDefaultColor(btnF);
                    break;
                case Key.G:
                    ChangeToDefaultColor(btnG);
                    break;
                case Key.H:
                    ChangeToDefaultColor(btnH);
                    break;
                case Key.J:
                    ChangeToDefaultColor(btnJ);
                    break;
                case Key.K:
                    ChangeToDefaultColor(btnK);
                    break;
                case Key.L:
                    ChangeToDefaultColor(btnL);
                    break;
                case Key.Oem1:
                    ChangeToDefaultColor(btnPointComa);
                    break;
                case Key.Oem7:
                    ChangeToDefaultColor(btnUpComa);
                    break;
                case Key.Return:
                    ChangeToDefaultColor(btnEnter);
                    break;
                case Key.LeftShift:
                    ChangeToDefaultColor(btnLShift);
                    break;
                case Key.Z:
                    ChangeToDefaultColor(btnZ);
                    break;
                case Key.X:
                    ChangeToDefaultColor(btnX);
                    break;
                case Key.C:
                    ChangeToDefaultColor(btnC);
                    break;
                case Key.V:
                    ChangeToDefaultColor(btnV);
                    break;
                case Key.B:
                    ChangeToDefaultColor(btnB);
                    break;
                case Key.N:
                    ChangeToDefaultColor(btnN);
                    break;
                case Key.M:
                    ChangeToDefaultColor(btnM);
                    break;
                case Key.OemComma:
                    ChangeToDefaultColor(btnComma);
                    break;
                case Key.OemEnlw:
                    ChangeToDefaultColor(btnPoint);
                    break;
                case Key.Oem2:
                    ChangeToDefaultColor(btnBackSlash);
                    break;
                case Key.RightShift:
                    ChangeToDefaultColor(btnRShift);
                    break;
                default:
                    break;
            }
        }

    }
}
