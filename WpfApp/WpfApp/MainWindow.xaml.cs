using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
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
using WpfApp;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields
        //int magnum = 30;
        int money = 100;
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            AntalIs();
            DataContext = this;
        }

        public void Pung()
        {
            if ()
            {
                money -= 10;
                LbPung.Content = money;
            }
        }


        public void AntalIs()
        {
            LbMagnum.Content = 30;
            LbAstronaut.Content = 30;
            LbKøbenhavnerstang.Content = 30;
            LbTwiser.Content = 30;
            LbFilur.Content = 30;
            LbKungFu.Content = 30;
        }

        #region Buttons

        private void BtnMagnum_Click(object sender, RoutedEventArgs e)
        {

            LbxInfo.Items.Add("Dette er en Magnum");
            LbxKøbsInfo.Items.Add("1x Magnum");
        }

        private void BtnAstronaunt_Click(object sender, RoutedEventArgs e)
        {
            LbxInfo.Items.Clear();
            LbxInfo.Items.Add("Dette er en Astronaut");
            LbxKøbsInfo.Items.Add("1x Astronaut");
        }

        private void BtnKøbenhavnerstang_Click(object sender, RoutedEventArgs e)
        {
            LbxInfo.Items.Clear();
            LbxInfo.Items.Add("Dette er en københavner stang");
            LbxKøbsInfo.Items.Add("1x Københavner stang");
        }

        private void BtnTwister_Click(object sender, RoutedEventArgs e)
        {
            LbxInfo.Items.Clear();
            LbxInfo.Items.Add("Dette er en Twister");
            LbxKøbsInfo.Items.Add("1x Twiser");
        }

        private void BtnFilur_Click(object sender, RoutedEventArgs e)
        {
            LbxInfo.Items.Clear();
            LbxInfo.Items.Add("Dette er en Filur");
            LbxKøbsInfo.Items.Add("1x Magnum");
        }

        private void BtnKungFu_Click(object sender, RoutedEventArgs e)
        {
            LbxInfo.Items.Clear();
            LbxInfo.Items.Add("Dette er en Kung Fu");
            LbxKøbsInfo.Items.Add("1x Kung Fu");
        }
        #endregion

    }


   
}
