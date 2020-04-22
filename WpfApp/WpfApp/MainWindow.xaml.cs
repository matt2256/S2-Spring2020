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


        #region Lister
        List<Vare> vare = new List<Vare>() { };
        List<Vare> AntalVareTilbage = new List<Vare> () { };
        List<Vare> VareOversigt = new List<Vare>() 
        {
        };
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            TilføjIs();
            Pung();
            DataContext = this;
        }

        #region Tilføjelse af is data til listbox type 
        //Tilføjer data til listboxen
        public void TilføjIs()
        {
            VareOversigt.Add(new Vare("Magnum", 12));
            VareOversigt.Add(new Vare("Filur", 13));
            VareOversigt.Add(new Vare("Twister", 42));
            VareOversigt.Add(new Vare("Københavnerstang", 9));
            VareOversigt.Add(new Vare("Astronaut", 24));
            VareOversigt.Add(new Vare("Kung Fu", 10));

            LbxIceType.ItemsSource = VareOversigt;
        }

        #endregion

        private void BtnAddIce_Click(object sender, RoutedEventArgs e)
        {
            vare.Add(VareOversigt[].Navn);
            DtgIceInfo.ItemsSource = vare;
            DtgIceInfo.Items.Refresh();


            AntalVareTilbage.Add(new Vare(LbxIceType.SelectedValue.ToString(), antalIs));
            DtgIcePrice.ItemsSource = AntalVareTilbage;
            DtgIcePrice.Items.Refresh();

            antalIs -= 1;
        }

        private void Pung()
        {
            switch (LbxIceType.SelectedValue)
            {
                case 0:
                    LbPrice.Content = VareOversigt[0].pris;
                    break;
                case 1:
                    LbPrice.Content = VareOversigt[1].pris;
                    break;
                case 2:
                    LbPrice.Content = VareOversigt[2].pris;
                    break;
                case 3:
                    LbPrice.Content = VareOversigt[3].pris;
                    break;
                case 4:
                    LbPrice.Content = VareOversigt[4].pris;
                    break;
                default:
                    break;
            }
        }
    }


   
}
