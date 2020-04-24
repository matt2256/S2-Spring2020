using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.Models;


namespace WpfApp.ViewModels
{
    public class ProductViewModel : ObservableObjects
    {
        //Model for produktet som viewmodellen repræsentere
        private IsButikItem _Model;

        //maksimum antal af vare der er tiladt i viewmodellen
        private const int _MaksAntal = 10;

        //Den nuværende antal i  viewmodellen
        private int _Antal;

        public int Id
        {
            get
            {
                return _Model.Id;
            }
        }

        public int Antal
        {
            get
            {
                return _Antal;
            }
            private set
            {
                _Antal = value;
                OnPropertyChanged("Out of Stock");
                OnPropertyChanged("Inventory Display");
                OnPropertyChanged("Antal");
            }
        }

        //Beskeden der vises af et produkt og dets antal
        //Ex: "Filur: 7"
        public string InventoryDisplay
        {
            get
            {
                return _Model.Name + ": " + _Antal;
            }
        }

        //returner en kopi af denne model værdi
        public IsButikItem information
        {
            get
            {
                return _Model;
            }
        }

        //Bestemt hvis der er behvo for at vise en besked for hvis en vare er ude af stock 
        public Visibility OutOfStockMessage
        {
            get
            {
                if (Antal > 0)
                {
                    return Visibility.Hidden;
                }

                return Visibility.Hidden;
            }
        }

        public ProductViewModel(int id, string name, double price)
        {
            _Model = new IsButikItem(id, name, price);
            Antal = 0;
        }

        public int Refil()
        {
            var amount = _MaksAntal - Antal;
            Antal += amount;

            return amount;
        }

        public int Empty()
        {
            var amount = Antal;
            Antal = 0;
            return amount;
        }

        public bool Dispense()
        {
            if (Antal >0)
            {
                Antal--;
                return true;
            }
            return false;
        }

        
    }
}
