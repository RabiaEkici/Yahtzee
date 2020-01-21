using System;
using System.Collections.Generic;
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
        public int totalnumber;
        public int number1;
        public int number2;
        public int number3;
        public int number4;
        public int number5;
        public bool lock1active = false;
        public bool lock2active = false;
        public bool lock3active = false;
        public bool lock4active = false;
        public bool lock5active = false;


        public void Throw_click(object sender, RoutedEventArgs e)
        {
            //een random number generator voor de dobbelstenen 1-5. dit geeft de dobbelstenen een nummer tussen 1-6
            Random rnd = new Random();
            
            if (lock1active == false)
            {
                number1 = rnd.Next(1, 7);
            }
            if (lock2active == false)
            {
                number2 = rnd.Next(1, 7);
            }
            if (lock3active == false)
            {
                number3 = rnd.Next(1, 7);
            }
            if (lock4active == false)
            {
                number4 = rnd.Next(1, 7);
            }
            if (lock5active == false)
            {
                number5 = rnd.Next(1, 7);
            }

            //verbergt de zwarte dobbelstenen voordat er gegooid is.
            column1dice1.Visibility = Visibility.Collapsed;
            column1dice2.Visibility = Visibility.Collapsed;
            column1dice3.Visibility = Visibility.Collapsed;
            column1dice4.Visibility = Visibility.Collapsed;
            column1dice5.Visibility = Visibility.Collapsed;
            column1dice6.Visibility = Visibility.Collapsed;
            column2dice1.Visibility = Visibility.Collapsed;
            column2dice2.Visibility = Visibility.Collapsed;
            column2dice3.Visibility = Visibility.Collapsed;
            column2dice4.Visibility = Visibility.Collapsed;
            column2dice5.Visibility = Visibility.Collapsed;
            column2dice6.Visibility = Visibility.Collapsed;
            column3dice1.Visibility = Visibility.Collapsed;
            column3dice2.Visibility = Visibility.Collapsed;
            column3dice3.Visibility = Visibility.Collapsed;
            column3dice4.Visibility = Visibility.Collapsed;
            column3dice5.Visibility = Visibility.Collapsed;
            column3dice6.Visibility = Visibility.Collapsed;
            column4dice1.Visibility = Visibility.Collapsed;
            column4dice2.Visibility = Visibility.Collapsed;
            column4dice3.Visibility = Visibility.Collapsed;
            column4dice4.Visibility = Visibility.Collapsed;
            column4dice5.Visibility = Visibility.Collapsed;
            column4dice6.Visibility = Visibility.Collapsed;
            column5dice1.Visibility = Visibility.Collapsed;
            column5dice2.Visibility = Visibility.Collapsed;
            column5dice3.Visibility = Visibility.Collapsed;
            column5dice4.Visibility = Visibility.Collapsed;
            column5dice5.Visibility = Visibility.Collapsed;
            column5dice6.Visibility = Visibility.Collapsed;

            //verbergt de rode dobbelstenen tenzij ze gelockt zijn.
            if (lock1active == false)
            {
                column1roodDice1.Visibility = Visibility.Collapsed;
                column1roodDice2.Visibility = Visibility.Collapsed;
                column1roodDice3.Visibility = Visibility.Collapsed;
                column1roodDice4.Visibility = Visibility.Collapsed;
                column1roodDice5.Visibility = Visibility.Collapsed;
                column1roodDice6.Visibility = Visibility.Collapsed;
            }

            if (lock2active == false)
            {
                column2roodDice1.Visibility = Visibility.Collapsed;
                column2roodDice2.Visibility = Visibility.Collapsed;
                column2roodDice3.Visibility = Visibility.Collapsed;
                column2roodDice4.Visibility = Visibility.Collapsed;
                column2roodDice5.Visibility = Visibility.Collapsed;
                column2roodDice6.Visibility = Visibility.Collapsed;
            }

            if (lock3active == false)
            {
                column3roodDice1.Visibility = Visibility.Collapsed;
                column3roodDice2.Visibility = Visibility.Collapsed;
                column3roodDice3.Visibility = Visibility.Collapsed;
                column3roodDice4.Visibility = Visibility.Collapsed;
                column3roodDice5.Visibility = Visibility.Collapsed;
                column3roodDice6.Visibility = Visibility.Collapsed;
            }

            if (lock4active == false)
            {
                column4roodDice1.Visibility = Visibility.Collapsed;
                column4roodDice2.Visibility = Visibility.Collapsed;
                column4roodDice3.Visibility = Visibility.Collapsed;
                column4roodDice4.Visibility = Visibility.Collapsed;
                column4roodDice5.Visibility = Visibility.Collapsed;
                column4roodDice6.Visibility = Visibility.Collapsed;
            }

            if (lock5active == false)
            {

                column5roodDice1.Visibility = Visibility.Collapsed;
                column5roodDice2.Visibility = Visibility.Collapsed;
                column5roodDice3.Visibility = Visibility.Collapsed;
                column5roodDice4.Visibility = Visibility.Collapsed;
                column5roodDice5.Visibility = Visibility.Collapsed;
                column5roodDice6.Visibility = Visibility.Collapsed;
            }

            // dobbelsteen 1 word gegooit en je krijgt de uitkomst te zien.
            if (lock1active == false)
            {
                if (number1 == 1)
                {
                    column1dice1.Visibility = Visibility.Visible;
                }
                if (number1 == 2)
                {
                    column1dice2.Visibility = Visibility.Visible;
                }
                if (number1 == 3)
                {
                    column1dice3.Visibility = Visibility.Visible;
                }
                if (number1 == 4)
                {
                    column1dice4.Visibility = Visibility.Visible;
                }
                if (number1 == 5)
                {
                    column1dice5.Visibility = Visibility.Visible;
                }
                if (number1 == 6)
                {
                    column1dice6.Visibility = Visibility.Visible;
                }
            }

            // dobbelsteen 2 word gegooit en je krijgt de uitkomst te zien.
            if (number2 == 1)
            {
                column2dice1.Visibility = Visibility.Visible;
            }
            if (number2 == 2)
            {
                column2dice2.Visibility = Visibility.Visible;
            }
            if (number2 == 3)
            {
                column2dice3.Visibility = Visibility.Visible;
            }
            if (number2 == 4)
            {
                column2dice4.Visibility = Visibility.Visible;
            }
            if (number2 == 5)
            {
                column2dice5.Visibility = Visibility.Visible;
            }
            if (number2 == 6)
            {
                column2dice6.Visibility = Visibility.Visible;
            }

            // dobbelsteen 3 word gegooit en je krijgt de uitkomst te zien.
            if (number3 == 1)
            {
                column3dice1.Visibility = Visibility.Visible;
            }
            if (number3 == 2)
            {
                column3dice2.Visibility = Visibility.Visible;
            }
            if (number3 == 3)
            {
                column3dice3.Visibility = Visibility.Visible;
            }
            if (number3 == 4)
            {
                column3dice4.Visibility = Visibility.Visible;
            }
            if (number3 == 5)
            {
                column3dice5.Visibility = Visibility.Visible;
            }
            if (number3 == 6)
            {
                column3dice6.Visibility = Visibility.Visible;
            }

            // dobbelsteen 4 word gegooit en je krijgt de uitkomst te zien.
            
            if (number4 == 1)
            {
                column4dice1.Visibility = Visibility.Visible;
            }
            if (number4 == 2)
            {
                column4dice2.Visibility = Visibility.Visible;
            }
            if (number4 == 3)
            {
                column4dice3.Visibility = Visibility.Visible;
            }
            if (number4 == 4)
            {
                column4dice4.Visibility = Visibility.Visible;
            }
            if (number4 == 5)
            {
                column4dice5.Visibility = Visibility.Visible;
            }
            if (number4 == 6)
            {
                column4dice6.Visibility = Visibility.Visible;
            }

            // dobbelsteen 5 word gegooit en je krijgt de uitkomst te zien.
            if (number5 == 1)
            {
                column5dice1.Visibility = Visibility.Visible;
            }
            if (number5 == 2)
            {
                column5dice2.Visibility = Visibility.Visible;
            }
            if (number5 == 3)
            {
                column5dice3.Visibility = Visibility.Visible;
            }
            if (number5 == 4)
            {
                column5dice4.Visibility = Visibility.Visible;
            }
            if (number5 == 5)
            {
                column5dice5.Visibility = Visibility.Visible;
            }
            if (number5 == 6)
            {
                column5dice6.Visibility = Visibility.Visible;
            }

            int Sum = 0;

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
                Sum = 25;
            }

            textboxFullHouseScore.Text = Sum.ToString();

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

            else if ((number1 == 1 && number2 == 1 && number3 == 1 && number4 == 1) ||
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
                textboxThreeOfAKindScore.Text = totalnumber.ToString();
            }

            //kleine straat
            else if (number1 == 1 || number2 == 1 || number3 == 1 || number4 == 1 || number5 == 1 && number1 == 2 ||
                number2 == 2 || number3 == 2 || number4 == 2 || number5 == 2 && number1 == 3 || number2 == 3 ||
                number3 == 3 || number4 == 3 || number5 == 3 && number1 == 4 || number2 == 4 || number3 == 4 ||
                number4 == 4 || number5 == 4 || number1 == 2 || number2 == 2 || number3 == 2 || number4 == 2 ||
                number5 == 2 && number1 == 3 || number2 == 3 || number3 == 3 || number4 == 3 || number5 == 3 && number1 == 4 ||
                number2 == 4 || number3 == 4 || number4 == 4 || number5 == 4 && number1 == 5 || number2 == 5 || number3 == 5 ||
                number4 == 5 || number5 == 5 || number1 == 3 || number2 == 3 || number3 == 3 || number4 == 3 || number5 == 3 && (number1 == 4 ||
                number2 == 4 || number3 == 4 || number4 == 4 || number5 == 4) && number1 == 5 || number2 == 5 || number3 == 5 || number4 == 5 || number5 == 5 &&
                number1 == 6 || number2 == 6 || number3 == 6 || number4 == 6 || number5 == 6)
            {
                totalnumber = number1 + number2 + number3 + number4 + number5;
                textboxKleineStraatScore.Text = totalnumber.ToString();
            }

            //grote straat
            else if (number1 == 1 || number2 == 1 || number3 == 1 || number4 == 1 || number5 == 1 &&
                number1 == 2 || number2 == 2 || number3 == 2 || number4 == 2 || number5 == 2 &&
                number1 == 3 || number2 == 3 || number3 == 3 || number4 == 3 || number5 == 3 &&
                number1 == 4 || number2 == 4 || number3 == 4 || number4 == 4 || number5 == 4 &&
                number1 == 5 || number2 == 5 || number3 == 5 || number4 == 5 || number5 == 5 || number1 == 2 || number2 == 2 || number3 == 2 || number4 == 2 || number5 == 2 &&
                number1 == 3 || number2 == 3 || number3 == 3 || number4 == 3 || number5 == 3 && number1 == 4 || number2 == 4 || number3 == 4 || number4 == 4 || number5 == 4 &&
                number1 == 5 || number2 == 5 || number3 == 5 || number4 == 5 || number5 == 5 && number1 == 6 || number2 == 6 || number3 == 6 || number4 == 6 || number5 == 6)
            {
                totalnumber = number1 + number2 + number3 + number4 + number5;
                textboxGroteStraatScore.Text = totalnumber.ToString();
            }
        }


        private void Rules_click(object sender, RoutedEventArgs e)
        {
            
        }

        public void Lock1_click(object sender, RoutedEventArgs e)
        {
            lock1active = true;
            if (number1 == 1)
            {
                column1roodDice1.Visibility = Visibility.Visible;
            }
            if (number1 == 2)
            {
                column1roodDice2.Visibility = Visibility.Visible;
            }
            if (number1 == 3)
            {
                column1roodDice3.Visibility = Visibility.Visible;
            }
            if (number1 == 4)
            {
                column1roodDice4.Visibility = Visibility.Visible;
            }
            if (number1 == 5)
            {
                column1roodDice5.Visibility = Visibility.Visible;
            }
            if (number1 == 6)
            {
                column1roodDice6.Visibility = Visibility.Visible;
            }

        }

        private void Lock2_click(object sender, RoutedEventArgs e)
        {
            lock2active = true;
            if (number2 == 1)
            {
                column2roodDice1.Visibility = Visibility.Visible;
            }
            if (number2 == 2)
            {
                column2roodDice2.Visibility = Visibility.Visible;
            }
            if (number2 == 3)
            {
                column2roodDice3.Visibility = Visibility.Visible;
            }
            if (number2 == 4)
            {
                column2roodDice4.Visibility = Visibility.Visible;
            }
            if (number2 == 5)
            {
                column2roodDice5.Visibility = Visibility.Visible;
            }
            if (number2 == 6)
            {
                column2roodDice6.Visibility = Visibility.Visible;
            }
        }

        private void Lock3_click(object sender, RoutedEventArgs e)
        {
            lock3active = true;
            if (number3 == 1)
            {
                column3roodDice1.Visibility = Visibility.Visible;
            }
            if (number3 == 2)
            {
                column3roodDice2.Visibility = Visibility.Visible;
            }
            if (number3 == 3)
            {
                column3roodDice3.Visibility = Visibility.Visible;
            }
            if (number3 == 4)
            {
                column3roodDice4.Visibility = Visibility.Visible;
            }
            if (number3 == 5)
            {
                column3roodDice5.Visibility = Visibility.Visible;
            }
            if (number3 == 6)
            {
                column3roodDice6.Visibility = Visibility.Visible;
            }
        }

        private void Lock4_click(object sender, RoutedEventArgs e)
        {
            lock4active = true;
            if (number4 == 1)
            {
                column4roodDice1.Visibility = Visibility.Visible;
            }
            if (number4 == 2)
            {
                column4roodDice2.Visibility = Visibility.Visible;
            }
            if (number4 == 3)
            {
                column4roodDice3.Visibility = Visibility.Visible;
            }
            if (number4 == 4)
            {
                column4roodDice4.Visibility = Visibility.Visible;
            }
            if (number4 == 5)
            {
                column4roodDice5.Visibility = Visibility.Visible;
            }
            if (number4 == 6)
            {
                column4roodDice6.Visibility = Visibility.Visible;
            }
        }

        private void Lock5_click(object sender, RoutedEventArgs e)
        {
            lock5active = true;
            if (number5 == 1)
            {
                column5roodDice1.Visibility = Visibility.Visible;
            }
            if (number5 == 2)
            {
                column5roodDice2.Visibility = Visibility.Visible;
            }
            if (number5 == 3)
            {
                column5roodDice3.Visibility = Visibility.Visible;
            }
            if (number5 == 4)
            {
                column5roodDice4.Visibility = Visibility.Visible;
            }
            if (number5 == 5)
            {
                column5roodDice5.Visibility = Visibility.Visible;
            }
            if (number5 == 6)
            {
                column5roodDice6.Visibility = Visibility.Visible;
            }
        }
    }
}