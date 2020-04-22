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
        int antalIs = 100;
        #endregion


        
       

        public MainWindow()
        {
            InitializeComponent();

            
            DataContext = this;
        }

        private void BtnMagnum_Click(object sender, RoutedEventArgs e)
        {
            LbxInfo.Items.Clear();
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
    }


   
}
