using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Net;
using Newtonsoft.Json;


namespace RiotPlayerCheck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            API.PlayerNameCheck(tbPlayerName.Text);
            API.PlayerId(tbPlayerName.Text);

        }

        //Over ordnede ide
        //Vi lave en app der kan tage en summonername fra riot og vise hele summmonerens profil 


        //Næste ting der skal laves er:
        //1.Finde de api calls der skal bruges fra RIOT 
        //2.

        

      

    }
}
