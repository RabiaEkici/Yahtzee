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

         

        public void Throw_click(object sender, RoutedEventArgs e)
        {


            Random rnd = new Random();
            int number1 = rnd.Next(1, 7);
            int number2 = rnd.Next(1, 7);
            int number3 = rnd.Next(1, 7);
            int number4 = rnd.Next(1, 7);
            int number5 = rnd.Next(1, 7);
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

            if (section1 == 1.ToString())
            {
                dice1.Text = "dobbelsteen";
            }

            if (section2 == 1.ToString())
            {
                dice2.Text = "dobbelsteen";
            }

            if (section3 == 1.ToString())
            {
                dice3.Text = "dobbelsteen";
            }

            if (section4 == 1.ToString())
            {
                dice4.Text = "dobbelsteen";
            }

            if (section5 == 1.ToString())
            {
                dice5.Text = "🎲";
            }

                else if (section5 == 2.ToString())
                {
                    dice5.Text = "2obbelsteen";
                }


        }

        private void Rules_click(object sender, RoutedEventArgs e)
        {

        }

        public void Lock1_click(object sender, RoutedEventArgs e)
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

        
    }
}
