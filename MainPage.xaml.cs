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

        //de comments zijn gemaakt door Emre en Sten
        //variabelen die in dit programma worden gebruikt
        public int totalscorenumber;
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
        public bool chooseYahtzeeVisibility;
        public bool chooseFullHouseVisibility;
        public bool chooseCarreVisibility;
        public bool chooseGroteStraatVisibility;
        public bool chooseKleineStraatVisibility;
        public bool chooseThreeOfAKindVisibility;
        public bool chooseChanceVisibility;
        int[] i = new int[5];
        int y = 0;
        int x = 0;
        int timesThrownEnen;
        int timesThrownZessen;
        int timesThrownYahtzee;
        int timesThrownFullHouse;
        int timesThrownCarre;
        int timesThrownGroteStraat;
        int timesThrownKleineStraat;
        int timesThrownThreeOfAKind;
        int timesThrownChance;




        //method: zet de bools op false
        public void ButtonsVisibilityFalse()
        {
            chooseYahtzeeVisibility = false;
            chooseFullHouseVisibility = false;
            chooseCarreVisibility = false;
            chooseGroteStraatVisibility = false;
            chooseKleineStraatVisibility = false;
            chooseThreeOfAKindVisibility = false;
            chooseChanceVisibility = false;
        }


        //method: zet de bools op true
        public void ButtonsVisibilityTrue()
        {
            chooseYahtzeeVisibility = true;
            chooseFullHouseVisibility = true;
            chooseCarreVisibility = true;
            chooseGroteStraatVisibility = true;
            chooseKleineStraatVisibility = true;
            chooseThreeOfAKindVisibility = true;
            chooseChanceVisibility = true;
        }

        //method: als een conditie overeenkomt dan maakt hij alle "Choose" knoppen niet klikbaar en onzichtbaar
        public void CalculateVisibility()
        {
            if (chooseChanceVisibility)
            {
                chooseEnen.Visibility = Visibility.Collapsed;
                chooseTweeen.Visibility = Visibility.Collapsed;
                chooseDrien.Visibility = Visibility.Collapsed;
                chooseVieren.Visibility = Visibility.Collapsed;
                chooseVijfen.Visibility = Visibility.Collapsed;
                chooseZessen.Visibility = Visibility.Collapsed;
                chooseYahtzee.Visibility = Visibility.Collapsed;
                chooseFullHouse.Visibility = Visibility.Collapsed;
                chooseCarre.Visibility = Visibility.Collapsed;
                chooseGroteStraat.Visibility = Visibility.Collapsed;
                chooseKleineStraat.Visibility = Visibility.Collapsed;
                chooseThreeOfAKind.Visibility = Visibility.Collapsed;
                chooseChance.Visibility = Visibility.Collapsed;

            }
        }
      
       
        //throw click gemaakt door sten en Emre 
        //sten alles gedaan aan de dobbelstenen met locken, unlocken en totale score gedaan door Emre en michiel (de eerste if statement is gemaakt door Emre)
        public void Throw_click(object sender, RoutedEventArgs e)
        {
            if (x <= 3)
            {
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
                x += 1;
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

           //maakt alle "Choose" knoppen zichtbaar (Gemaakt  door Emre)
           chooseEnen.Visibility = Visibility.Visible;
           chooseTweeen.Visibility = Visibility.Visible;
           chooseDrien.Visibility = Visibility.Visible;
           chooseVieren.Visibility = Visibility.Visible;
           chooseVijfen.Visibility = Visibility.Visible;
           chooseZessen.Visibility = Visibility.Visible;
           chooseYahtzee.Visibility = Visibility.Visible;
           chooseFullHouse.Visibility = Visibility.Visible;
           chooseCarre.Visibility = Visibility.Visible;
           chooseGroteStraat.Visibility = Visibility.Visible;
           chooseKleineStraat.Visibility = Visibility.Visible;
           chooseThreeOfAKind.Visibility = Visibility.Visible;
           chooseChance.Visibility = Visibility.Visible;

            //berekent de totale score van het hele scorebord.
             int totalScoreNumber = Convert.ToInt32(textboxEnenScore.Text) + Convert.ToInt32(textboxTweeenScore.Text) + Convert.ToInt32(textboxDrienScore.Text) + Convert.ToInt32(textboxVierenScore.Text) +
                                    Convert.ToInt32(textboxVijfenScore.Text) + Convert.ToInt32(textboxZessenScore.Text) + Convert.ToInt32(textboxYahtzeeScore.Text) + Convert.ToInt32(textboxFullHouseScore.Text) +
                                    Convert.ToInt32(textboxCarreScore.Text) + Convert.ToInt32(textboxGroteStraatScore.Text) + Convert.ToInt32(textboxKleineStraatScore.Text) + Convert.ToInt32(textboxThreeOfAKindScore.Text) +
                                    Convert.ToInt32(textboxChanceScore.Text);
             textboxTotalScore.Text = totalScoreNumber.ToString();

            //na 3 keer klikken, unlocked het alle dice
           
            if (y >= 3)
            {
                lock1active = false;
                lock2active = false;
                lock3active = false;
                lock4active = false;
                lock5active = false;
                y = 0;
            }
            y += 1;
           decimal totalnumberdecimal = number1 + number2 + number3 + number4 + number5;
           totalnumberdecimal /= 5;
            textboxAverageScore.Text = totalnumberdecimal.ToString();
        }


        //Stuurt je naar een andere pagina op een klik event (Gemaakt door Emre)
        private void Rules_click(object sender, RoutedEventArgs e)
        {
            GameRules page1 = new GameRules();
            this.Content = page1;
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
            //alles hieronder is gemaakt door Emre
        
            //code voor Enen, kijkt of er een conditie overeenkomt.
            //zet een cijfer in een textbox
            private void ChooseEnen_Click(object sender, RoutedEventArgs e)
            {
                i[0] = number1;
                i[1] = number2;
                i[2] = number3;
                i[3] = number4;
                i[4] = number5;

                Array.Sort(i);

                if (i[0] == 1 && i[1] != 1 && i[2] != 1 && i[3] != 1 && i[4] != 1)
                {
                    textboxEnenScore.Text = 1.ToString();
                    ButtonsVisibilityTrue();
                }
                else if (i[0] == 1 && i[1] == 1 && i[2] != 1 && i[3] != 1 && i[4] != 1)
                {
                    textboxEnenScore.Text = 2.ToString();
                    ButtonsVisibilityTrue();
                }
                else if (i[0] == 1 && i[1] == 1 && i[2] == 1 && i[3] != 1 && i[4] != 1)
                {
                    textboxEnenScore.Text = 3.ToString();
                    ButtonsVisibilityTrue();
                }
                else if (i[0] == 1 && i[1] == 1 && i[2] == 1 && i[3] == 1 && i[4] != 1)
                {
                    textboxEnenScore.Text = 4.ToString();
                    ButtonsVisibilityTrue();
                }
                else if (i[0] == 1 && i[1] == 1 && i[2] == 1 && i[3] == 1 && i[4] == 1)
                {
                    textboxEnenScore.Text = 5.ToString();
                    ButtonsVisibilityTrue();
                }

                CalculateVisibility();

            timesThrownEnen += 1;
            timesEnen.Text = timesThrownEnen.ToString();

        }



        private void ChooseTweeen_click(object sender, RoutedEventArgs e)
        { 
            CalculateVisibility();
        }



        private void ChooseDrien_click(object sender, RoutedEventArgs e)
        {
            CalculateVisibility();
        }



        private void ChooseVieren_click(object sender, RoutedEventArgs e)
        {
            CalculateVisibility();
        }



        private void ChooseVijfen_click(object sender, RoutedEventArgs e)
        {
            CalculateVisibility();
        }


        //code voor Zessen, kijkt of er een conditie overeenkomt.
        //zet een cijfer in een textbox
        private void ChooseZessen_click(object sender, RoutedEventArgs e)
        {
            i[0] = number1;
            i[1] = number2;
            i[2] = number3;
            i[3] = number4;
            i[4] = number5;

            Array.Sort(i);

            if (i[0] != 6 && i[1] != 6 && i[2] != 6 && i[3] != 6 && i[4] == 6)
            {
                textboxZessenScore.Text = 6.ToString();
                ButtonsVisibilityTrue();
            }
            else if (i[0] != 1 && i[1] != 6 && i[2] != 6 && i[3] == 6 && i[4] == 6)
            {
                textboxZessenScore.Text = 12.ToString();
                ButtonsVisibilityTrue();
            }
            else if (i[0] != 6 && i[1] != 6 && i[2] == 6 && i[3] == 6 && i[4] == 6)
            {
                textboxZessenScore.Text = 18.ToString();
                ButtonsVisibilityTrue();
            }
            else if (i[0] != 6 && i[1] == 6 && i[2] == 6 && i[3] == 6 && i[4] == 6)
            {
                textboxZessenScore.Text = 24.ToString();
                ButtonsVisibilityTrue();
            }
            else if (i[0] == 6 && i[1] == 6 && i[2] == 6 && i[3] == 6 && i[4] == 6)
            {
                textboxZessenScore.Text = 30.ToString();
                ButtonsVisibilityTrue();
            }

            timesThrownZessen += 1;
            timesZessen.Text = timesThrownZessen.ToString();

            CalculateVisibility();
        }


        //code voor Yahtzee, kijkt of er een conditie overeenkomt.
        //telt alle dobbelstenen bij eklaar op
        public void ChooseYahtzee_click(object sender, RoutedEventArgs e)
        {
            if (number1 == 1 && number2 == 1 && number3 == 1 && number4 == 1 && number5 == 1 ||
                number1 == 2 && number2 == 2 && number3 == 2 && number4 == 2 && number5 == 2 ||
                number1 == 3 && number2 == 3 && number3 == 3 && number4 == 3 && number5 == 3 ||
                number1 == 4 && number2 == 4 && number3 == 4 && number4 == 4 && number5 == 4 ||
                number1 == 5 && number2 == 5 && number3 == 5 && number4 == 5 && number5 == 5 ||
                number1 == 6 && number2 == 6 && number3 == 6 && number4 == 6 && number5 == 6)
            {
                textboxYahtzeeScore.Text = 50.ToString();
                timesThrownYahtzee += 1;
                timesYahtzee.Text = timesThrownYahtzee.ToString();
                ButtonsVisibilityTrue();
            }

            CalculateVisibility();
        }


        //code voor Full House, zet alles in een array, sorteert het en kijkt of er een conditie overeenkomt.
        //telt alle dobbelstenen bij eklaar op
        private void ChooseFullHouse_click(object sender, RoutedEventArgs e)
        {
            
            i[0] = number1;
            i[1] = number2;
            i[2] = number3;
            i[3] = number4;
            i[4] = number5;

            Array.Sort(i);

            if (((i[0] == i[1]) && (i[1] == i[2]) && (i[3] == i[4]) && (i[2] != i[3])) ||
                ((i[0] == i[1]) && (i[2] == i[3]) && (i[3] == i[4]) &&(i[1] != i[2])))
            {
                textboxFullHouseScore.Text = 25.ToString();
                timesThrownFullHouse += 1;
                timesFullHouse.Text = timesThrownFullHouse.ToString();
                ButtonsVisibilityTrue();
            }

            CalculateVisibility();
        }


        //code voor Four of a kind (Carré), zet alles in een array, sorteert het en kijkt of er een conditie overeenkomt.
        //telt alle dobbelstenen bij eklaar op
        private void ChooseCarre_click(object sender, RoutedEventArgs e)
        {
            i[0] = number1;
            i[1] = number2;
            i[2] = number3;
            i[3] = number4;
            i[4] = number5;

            Array.Sort(i);
            
            if ((i[0] == 1 && i[1] == 1 && i[2] == 1 && i[3] == 1 && i[4] != 1) ||
                (i[0] == 2 && i[1] == 2 && i[2] == 2 && i[3] == 2 && i[4] != 2) ||
                (i[0] == 3 && i[1] == 3 && i[2] == 3 && i[3] == 3 && i[4] != 3) ||
                (i[0] == 4 && i[1] == 4 && i[2] == 4 && i[3] == 4 && i[4] != 4) ||
                (i[0] == 5 && i[1] == 5 && i[2] == 5 && i[3] == 5 && i[4] != 5) ||
                (i[0] == 6 && i[1] == 6 && i[2] == 6 && i[3] == 6 && i[4] != 6))
                {
                    totalnumber = number1 + number2 + number3 + number4 + number5;
                    textboxCarreScore.Text = totalnumber.ToString();
                    timesThrownCarre += 1;
                    timesCarre.Text = timesThrownCarre.ToString();

                ButtonsVisibilityTrue();
                }

            CalculateVisibility();
        }


        //Code voor Grote Straat, zet alles in een array, sorteert het en kijkt of er een conditie overeenkomt.
        //telt alle dobbelstenen bij eklaar op
        private void ChooseGroteStraat_click(object sender, RoutedEventArgs e)
        {
            i[0] = number1;
            i[1] = number2;
            i[2] = number3;
            i[3] = number4;
            i[4] = number5;

            Array.Sort(i);

            if (((i[0] == 1) && (i[1] == 2) && (i[2] == 3) && (i[3] == 4) && (i[4] == 5)) ||
                ((i[0] == 2) && (i[1] == 3) && (i[2] == 4) && (i[3] == 5) && (i[4] == 6)))
            {
                textboxGroteStraatScore.Text = 40.ToString();
                timesThrownGroteStraat += 1;
                timesGroteStraat.Text = timesThrownGroteStraat.ToString();
                ButtonsVisibilityTrue();
            }

            CalculateVisibility();
        
        }


        //Code voor kleine straat, zet alles in een array, sorteert het en kijkt of er een conditie overeenkomt.
        //telt alle dobbelstenen bij eklaar op
        //Source: https://www.codeproject.com/Articles/8657/A-Simple-Yahtzee-Game alleen voor de "for loops"
        private void ChooseKleineStraat_click(object sender, RoutedEventArgs e)
        {
            timesThrownKleineStraat += 1;

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

                if (((i[0] == 1) && (i[1] == 2) && (i[2] == 3) && (i[3] == 4)) ||
                ((i[0] == 2) && (i[1] == 3) && (i[2] == 4) && (i[3] == 5)) ||
                ((i[0] == 3) && (i[1] == 4) && (i[2] == 5) && (i[3] == 6)) ||
                ((i[1] == 1) && (i[2] == 2) && (i[3] == 3) && (i[4] == 4)) ||
                ((i[1] == 2) && (i[2] == 3) && (i[3] == 4) && (i[4] == 5)) ||
                ((i[1] == 3) && (i[2] == 4) && (i[3] == 5) && (i[4] == 6)))
                {

                    textboxKleineStraatScore.Text = 30.ToString();
                    chooseKleineStraat.Visibility = Visibility.Collapsed;
                    timesKleineStraat.Text = timesThrownKleineStraat.ToString();
                    ButtonsVisibilityTrue();
                }
                
            }
            CalculateVisibility();
        }


        //Code voor three of a kind, zet alles in een array, sorteert het en kijkt of er een conditie overeenkomt.
        //telt alle dobbelstenen bij eklaar op
        private void ChooseThreeOfAKind_click(object sender, RoutedEventArgs e)
        {

            i[0] = number1;
            i[1] = number2;
            i[2] = number3;
            i[3] = number4;
            i[4] = number5;

            Array.Sort(i);

            if (((i[0] == 1) && (i[1] == 1) && (i[2] == 1)) ||
                ((i[0] == 2) && (i[1] == 2) && (i[2] == 2)) ||
                ((i[0] == 3) && (i[1] == 3) && (i[2] == 3)) ||
                ((i[0] == 4) && (i[1] == 4) && (i[2] == 4)) ||
                ((i[0] == 5) && (i[1] == 5) && (i[2] == 5)) ||
                ((i[0] == 6) && (i[1] == 6) && (i[2] == 6)) ||
                ((i[1] == 1) && (i[2] == 1) && (i[3] == 1)) ||
                ((i[1] == 2) && (i[2] == 2) && (i[3] == 2)) ||
                ((i[1] == 3) && (i[2] == 3) && (i[3] == 3)) ||
                ((i[1] == 4) && (i[2] == 4) && (i[3] == 4)) ||
                ((i[1] == 5) && (i[2] == 5) && (i[3] == 5)) ||
                ((i[1] == 6) && (i[2] == 6) && (i[3] == 6)) ||
                ((i[2] == 1) && (i[3] == 1) && (i[4] == 1)) ||
                ((i[2] == 2) && (i[3] == 2) && (i[4] == 2)) ||
                ((i[2] == 3) && (i[3] == 3) && (i[4] == 3)) ||
                ((i[2] == 4) && (i[3] == 4) && (i[4] == 4)) ||
                ((i[2] == 5) && (i[3] == 5) && (i[4] == 5)) ||
                ((i[2] == 6) && (i[3] == 6) && (i[4] == 6)))
                {
                    totalnumber = number1 + number2 + number3 + number4 + number5;
                    textboxThreeOfAKindScore.Text = totalnumber.ToString();
                    timesThrownThreeOfAKind += 1;
                    timesThreeOfAKind.Text = timesThrownThreeOfAKind.ToString();
                ButtonsVisibilityTrue();
                }

            CalculateVisibility();
        }


        //Code voor Chance
        private void ChooseChance_click(object sender, RoutedEventArgs e)
        {
           
            totalnumber = number1 + number2 + number3 + number4 + number5;
            textboxChanceScore.Text = totalnumber.ToString();

            if (chooseChance.Visibility == Visibility.Visible && textboxChanceScore.Text.Length >= 0.1)
            {
                ButtonsVisibilityTrue();
                timesThrownChance += 1;
                timesChance.Text = timesThrownChance.ToString();
            }

            CalculateVisibility();
        }
        
       
    }
}
    