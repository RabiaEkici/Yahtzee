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

        //variabelen die in dit programma worden gebruikt
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
        int timesThrown;

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
      
        //de comments zijn gemaakt door Emre en Sten
        //Sten's opdrachten beginnen hier
        public void Throw_click(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            number1 =  rnd.Next(1, 7);
            number2 =  rnd.Next(1, 7);
            number3 =  rnd.Next(1, 7);
            number4 =  rnd.Next(1, 7);
            number5 =  rnd.Next(1, 7);
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

            ButtonsVisibilityFalse();

            // Emre's opdrachten beginnen hier
            string section1 = dice1.Text;
            string section2 = dice2.Text;
            string section3 = dice3.Text;
            string section4 = dice4.Text;
            string section5 = dice5.Text;
           

            /*verandert nummer in dice, je kan section1 (deze variabelen kunnen gewoon verwijdert worden) veranderen naar number1 enz. maar anders moet ik dat aanpassen wat weer veel tijd gaat kosten.
              Dus doe ik dat nu niet en het werkt nu gewoon.*/

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

            ButtonsVisibilityFalse();
           
           //maakt alle "Choose" knoppen zichtbaar
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
            
        }


        //Stuurt je naar een andere pagina op een klik event
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
                textboxYahtzeeScore.Text += 50.ToString();
                timesYahtzee.Text = timesYahtzee.Text + 1;
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
                timesFullHouse.Text = timesFullHouse.Text + 1;
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
                    timesCarre.Text = timesCarre.Text + 1;
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
                timesThrown = timesThrown + 1;
                textboxGroteStraatScore.Text = 40.ToString();
                timesGroteStraat.Text = timesThrown.ToString();
                ButtonsVisibilityTrue();
            }

            CalculateVisibility();
        
        }


        //Code voor kleine straat, zet alles in een array, sorteert het en kijkt of er een conditie overeenkomt.
        //telt alle dobbelstenen bij eklaar op
        //Source: https://www.codeproject.com/Articles/8657/A-Simple-Yahtzee-Game alleen voor de "for loops"
        private void ChooseKleineStraat_click(object sender, RoutedEventArgs e)
        { 
            timesThrown = timesThrown + 1;

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
                    timesKleineStraat.Text = timesThrown.ToString();
                    ButtonsVisibilityTrue();
                }
                
            }
            CalculateVisibility();
        }


        //Code voor three of a kind, zet alles in een array, sorteert het en kijkt of er een conditie overeenkomt.
        //telt alle dobbelstenen bij eklaar op
        private void ChooseThreeOfAKind_click(object sender, RoutedEventArgs e)
        {
            timesThrown = timesThrown + 1;

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
                    timesThreeOfAKind.Text = timesThrown.ToString();
                    ButtonsVisibilityTrue();
                }

            CalculateVisibility();
        }
        

        //Code voor Chance
        private void ChooseChance_click(object sender, RoutedEventArgs e)
        {
            timesThrown = timesThrown + 1;
            totalnumber = number1 + number2 + number3 + number4 + number5;
            textboxChanceScore.Text = totalnumber.ToString();

            if (chooseChance.Visibility == Visibility.Visible && textboxChanceScore.Text.Length >= 0.1)
            {
                timesChance.Text = timesThrown.ToString();
                ButtonsVisibilityTrue();
            }

            CalculateVisibility();
        
        }
    }
}
    // Emre's opdrachten eindigen hier