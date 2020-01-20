using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Yahtzee
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
     

        public MainPage()
        {
            this.InitializeComponent();
            
        }

        int totalnumber;
        int number1;
        int number2;
        int number3;
        int number4;
        int number5;

        public void Throw_click(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            number1 = rnd.Next(1, 7);
            number2 = rnd.Next(1, 7);
            number3 = rnd.Next(1, 7);
            number4 = rnd.Next(1, 7);
            number5 = rnd.Next(1, 7);
            dice1.Text = "";
            dice2.Text = "";
            dice3.Text = "";
            dice4.Text = "";
            dice5.Text = "";
            string diceroll1 = string.Empty;
            string diceroll2 = string.Empty;
            string diceroll3 = string.Empty;
            string diceroll4 = string.Empty;
            string diceroll5 = string.Empty;
            diceroll1 += number1;
            diceroll2 += number2;
            diceroll3 += number3;
            diceroll4 += number4;
            diceroll5 += number5;
            dice1.Text += diceroll1;
            dice2.Text += diceroll2;
            dice3.Text += diceroll3;
            dice4.Text += diceroll4;
            dice5.Text += diceroll5;

            string section1 = dice1.Text;
            string section2 = dice2.Text;
            string section3 = dice3.Text;
            string section4 = dice4.Text;
            string section5 = dice5.Text;

            //yahtzee
            if (number1 == 1 && number2 == 1 && number3 == 1 && number4 == 1 && number5 == 1 ||
                number1 == 2 && number2 == 2 && number3 == 2 && number4 == 2 && number5 == 2 ||
                number1 == 3 && number2 == 3 && number3 == 3 && number4 == 3 && number5 == 3 ||
                number1 == 4 && number2 == 4 && number3 == 4 && number4 == 4 && number5 == 4 ||
                number1 == 5 && number2 == 5 && number3 == 5 && number4 == 5 && number5 == 5 ||
                number1 == 6 && number2 == 6 && number3 == 6 && number4 == 6 && number5 == 6)
            {
                textboxYahtzeeScore.Text = 50.ToString();
            }
            
            //full house
            int[] i = new int[5];

            i[0] = number1;
            i[1] = number2;
            i[2] = number3;
            i[3] = number4;
            i[4] = number5;

            Array.Sort(i);

            if ((((i[0] == i[1]) && (i[1] == i[2])) && 
                 (i[3] == i[4]) && 
                 (i[2] != i[3])) ||
                ((i[0] == i[1]) && 
                 ((i[2] == i[3]) && (i[3] == i[4])) &&
                 (i[1] != i[2])))
            {
                textboxFullHouseScore.Text = 25.ToString();
            }

            

            //three-of-a-kind
            if (number1 == 1 && number2 == 1 && number3 == 1 && number4 != 1 && number5 != 1 ||
                number1 == 2 && number2 == 2 && number3 == 2 && number4 != 2 && number5 != 2 ||
                number1 == 3 && number2 == 3 && number3 == 3 && number4 != 3 && number5 != 3 ||
                number1 == 4 && number2 == 4 && number3 == 4 && number4 != 4 && number5 != 4 ||
                number1 == 5 && number2 == 5 && number3 == 5 && number4 != 5 && number5 != 5 ||
                number1 != 1 && number2 != 1 && number3 == 1 && number4 == 1 && number5 == 1 ||
                number1 != 2 && number2 != 2 && number3 == 2 && number4 == 2 && number5 == 2 ||
                number1 != 3 && number2 != 3 && number3 == 3 && number4 == 3 && number5 == 3 ||
                number1 != 4 && number2 != 4 && number3 == 4 && number4 == 4 && number5 == 4 ||
                number1 != 5 && number2 != 5 && number3 == 5 && number4 == 5 && number5 == 5 ||
                number1 != 1 && number2 == 1 && number3 == 1 && number4 == 1 && number5 != 1 ||
                number1 != 2 && number2 == 2 && number3 == 2 && number4 == 2 && number5 != 2 ||
                number1 != 3 && number2 == 3 && number3 == 3 && number4 == 3 && number5 != 3 ||
                number1 != 4 && number2 == 4 && number3 == 4 && number4 == 4 && number5 != 4 ||
                number1 != 5 && number2 == 5 && number3 == 5 && number4 == 5 && number5 != 5 ||
                number1 == 1 && number2 == 1 && number3 != 1 && number4 != 1 && number5 == 1 ||
                number1 == 2 && number2 == 2 && number3 != 2 && number4 != 2 && number5 == 2 ||
                number1 == 3 && number2 == 3 && number3 != 3 && number4 != 3 && number5 == 3 ||
                number1 == 4 && number2 == 4 && number3 != 4 && number4 != 4 && number5 == 4 ||
                number1 == 5 && number2 == 5 && number3 != 5 && number4 != 5 && number5 == 5 ||
                number1 != 1 && number2 == 1 && number3 != 1 && number4 == 1 && number5 == 1 ||
                number1 != 2 && number2 == 2 && number3 != 2 && number4 == 2 && number5 == 2 ||
                number1 != 3 && number2 == 3 && number3 != 3 && number4 == 3 && number5 == 3 ||
                number1 != 4 && number2 == 4 && number3 != 4 && number4 == 4 && number5 == 4 ||
                number1 != 5 && number2 == 5 && number3 != 5 && number4 == 5 && number5 == 5 ||
                number1 == 1 && number2 != 1 && number3 == 1 && number4 != 1 && number5 == 1 ||
                number1 == 2 && number2 != 2 && number3 == 2 && number4 != 2 && number5 == 2 ||
                number1 == 3 && number2 != 3 && number3 == 3 && number4 != 3 && number5 == 3 ||
                number1 == 4 && number2 != 4 && number3 == 4 && number4 != 4 && number5 == 4 ||
                number1 == 5 && number2 != 5 && number3 == 5 && number4 != 5 && number5 == 5 ||
                number1 == 1 && number2 == 1 && number3 != 1 && number4 == 1 && number5 != 1 ||
                number1 == 2 && number2 == 2 && number3 != 2 && number4 == 2 && number5 != 2 ||
                number1 == 3 && number2 == 3 && number3 != 3 && number4 == 3 && number5 != 3 ||
                number1 == 4 && number2 == 4 && number3 != 4 && number4 == 4 && number5 != 4 ||
                number1 == 5 && number2 == 5 && number3 != 5 && number4 == 5 && number5 != 5)

            {
                totalnumber = number1 + number2 + number3 + number4 + number5;
                textboxThreeOfAKindScore.Text = totalnumber.ToString();

                
            }
            //four-of-a-kind(Carré)
            if ((number1 == 1 && number2 == 1 && number3 == 1 && number4 == 1) ||
                (number1 == 2 && number2 == 2 && number3 == 2 && number4 == 2) ||
                (number1 == 3 && number2 == 3 && number3 == 3 && number4 == 3) ||
                (number1 == 4 && number2 == 4 && number3 == 4 && number4 == 4) ||
                (number1 == 5 && number2 == 5 && number3 == 5 && number4 == 5) ||
                (number1 == 6 && number2 == 6 && number3 == 6 && number4 == 6) ||
                (number2 == 1 && number3 == 1 && number4 == 1 && number5 == 1) ||
                (number2 == 2 && number3 == 2 && number4 == 2 && number5 == 2) ||
                (number2 == 3 && number3 == 3 && number4 == 3 && number5 == 3) ||
                (number2 == 4 && number3 == 4 && number4 == 4 && number5 == 4) ||
                (number2 == 5 && number3 == 5 && number4 == 5 && number5 == 5) ||
                (number2 == 6 && number3 == 6 && number4 == 6 && number5 == 6))
            {
                totalnumber = number1 + number2 + number3 + number4 + number5;
                textboxCarreScore.Text = totalnumber.ToString();
            }


            //grote straat

            i[0] = number1;
            i[1] = number2;
            i[2] = number3;
            i[3] = number4;
            i[4] = number5;

            Array.Sort(i);

            if (((i[0] == 1) &&
                 (i[1] == 2) &&
                 (i[2] == 3) &&
                 (i[3] == 4) &&
                 (i[4] == 5)) ||
                ((i[0] == 2) &&
                 (i[1] == 3) &&
                 (i[2] == 4) &&
                 (i[3] == 5) &&
                 (i[4] == 6)))
            {
                textboxGroteStraatScore.Text = 40.ToString();
            }





            //Kleine straat

            i[0] = number1;
            i[1] = number2;
            i[2] = number3;
            i[3] = number4;
            i[4] = number5;

            Array.Sort(i);

            for (int j = 0; j < 4; j++)
            {
                int temp = 0;
                if (i[j] == i[j + 1])
                {
                    temp = i[j];

                    for (int k = j; k < 4; k++)
                    {
                        i[k] = i[k + 1];
                    }

                    i[4] = temp;
                }
            }

            if (((i[0] == 1) && (i[1] == 2) && (i[2] == 3) && (i[3] == 4)) ||
                ((i[0] == 2) && (i[1] == 3) && (i[2] == 4) && (i[3] == 5)) ||
                ((i[0] == 3) && (i[1] == 4) && (i[2] == 5) && (i[3] == 6)) ||
                ((i[1] == 1) && (i[2] == 2) && (i[3] == 3) && (i[4] == 4)) ||
                ((i[1] == 2) && (i[2] == 3) && (i[3] == 4) && (i[4] == 5)) ||
                ((i[1] == 3) && (i[2] == 4) && (i[3] == 5) && (i[4] == 6)))
            {
                textboxKleineStraatScore.Text = 30.ToString();
            }

            /*verandert nummer in dice, je kan section1 veranderen naar number1 enz. maar anders moet ik dat aanpassen wat weer veel tijd gaat kosten.
              Dus doe ik dat nu niet*/
            
            if (section1 == 1.ToString())
            {
             dice1.Text = "⚀";
            }

                else if (section1 == 2.ToString())
                {
                    dice1.Text = "⚁";
                }
                else if (section1 == 3.ToString())
                {
                    dice1.Text = "⚂";
                }
                else if (section1 == 4.ToString())
                {
                    dice1.Text = "⚃";
                }
                else if (section1 == 5.ToString())
                {
                    dice1.Text = "⚄";
                }
                else
                {
                    dice1.Text = "⚅";
                }

           if (section2 == 1.ToString())
           {
             dice2.Text = "⚀";
           }

                else if (section2 == 2.ToString())
                {
                    dice2.Text = "⚁";
                }
                else if (section2 == 3.ToString())
                {
                    dice2.Text = "⚂";
                }
                else if (section2 == 4.ToString())
                {
                    dice2.Text = "⚃";
                }
                else if (section2 == 5.ToString())
                {
                    dice2.Text = "⚄";
                }
                else
                {
                    dice2.Text = "⚅";
                }

            if (section3 == 1.ToString())
            {
                dice3.Text = "⚀";
            }

                else if (section3 == 2.ToString())
                {
                    dice3.Text = "⚁";
                }
                else if (section3 == 3.ToString())
                {
                    dice3.Text = "⚂";
                }
                else if (section3 == 4.ToString())
                {
                    dice3.Text = "⚃";
                }
                else if (section3 == 5.ToString())
                {
                    dice3.Text = "⚄";
                }
                else
                {
                    dice3.Text = "⚅";
                }

            if (section4 == 1.ToString())
            {
                dice4.Text = "⚀";
            }

                else if (section4 == 2.ToString())
                {
                    dice4.Text = "⚁";
                }
                else if (section4 == 3.ToString())
                {
                    dice4.Text = "⚂";
                }
                else if (section4 == 4.ToString())
                {
                    dice4.Text = "⚃";
                }
                else if (section4 == 5.ToString())
                {
                    dice4.Text = "⚄";
                }
                else
                {
                    dice4.Text = "⚅";
                }

            if (section5 == 1.ToString())
            {
                dice5.Text = "⚀";
            }

                else if (section5 == 2.ToString())
                {
                    dice5.Text = "⚁";
                }
                else if (section5 == 3.ToString())
                {
                dice5.Text = "⚂";
                }
                else if (section5 == 4.ToString())
                {
                dice5.Text = "⚃";
                }
                else if (section5 == 5.ToString())
                {
                dice5.Text = "⚄";
                }
                else
                {
                dice5.Text = "⚅";
                }

            
            if (keuzeKleineStraat.Visibility == Visibility.Collapsed)
            {
                keuzeKleineStraat.Visibility = Visibility.Visible;
            }

            if (keuzeGroteStraat.Visibility == Visibility.Collapsed)
            {
                keuzeGroteStraat.Visibility = Visibility.Visible;
            }


        }

        private void Rules_click(object sender, RoutedEventArgs e)
        {
            GameRules page1 = new GameRules();
            this.Content = page1;
        }

        private void Lock1_click(object sender, RoutedEventArgs e)
        { 
            
        }

        private void Lock2_click(object sender, RoutedEventArgs e)
        {

        }

        private void Lock3_click(object sender, RoutedEventArgs e)
        {

        }

        private void Lock4_click(object sender, RoutedEventArgs e)
        {

        }

        private void Lock5_click(object sender, RoutedEventArgs e)
        {
           
        }

        private void KeuzeGroteStraat_click(object sender, RoutedEventArgs e)
        {

            if (textboxKleineStraatScore.Text.Length > 0.3)
            {
                try
                {
                    textboxKleineStraatScore.Text = textboxKleineStraatScore.Text.Remove(textboxKleineStraatScore.Text.Length - 2);
                }
                catch
                {
                    textboxKleineStraatScore.Text += "";
                }

                if (keuzeGroteStraat.Visibility == Visibility.Visible)
                {
                    keuzeGroteStraat.Visibility = Visibility.Collapsed;
                }

                if (keuzeKleineStraat.Visibility == Visibility.Visible)
                {
                    keuzeKleineStraat.Visibility = Visibility.Collapsed;
                }
            }
        }
        

        private void KeuzeKleineStraat_click(object sender, RoutedEventArgs e)
        {
            if (textboxGroteStraatScore.Text.Length > 1)
            {
                try
                {
                    textboxGroteStraatScore.Text = textboxGroteStraatScore.Text.Remove(textboxGroteStraatScore.Text.Length - 2);
                }
                catch
                {
                    textboxGroteStraatScore.Text += "";   
                }

            if (keuzeKleineStraat.Visibility == Visibility.Visible)
            {
              keuzeKleineStraat.Visibility = Visibility.Collapsed;
            }

            if (keuzeGroteStraat.Visibility == Visibility.Visible)
            {
              keuzeGroteStraat.Visibility = Visibility.Collapsed;
            }

            }
        }
    }
}
