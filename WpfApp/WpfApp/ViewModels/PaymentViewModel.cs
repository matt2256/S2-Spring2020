using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.ViewModels
{
    public class PaymentViewModel : ObservableObjects
    {
        //Kunde informationer
        private double _total;
        private double _inserted;
        private double _change;

        //Machine information
        private double _bankTotal;

        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }
        }

        public double Inserted
        {
            get
            {
                return _inserted;
            }
            set
            {
                _inserted = value;
                OnPropertyChanged("Inserted");
            }
        }
        
        public double Change
        {
            get
            {
                return _change;
            }
            set
            {
                _change = value;
                OnPropertyChanged("Change");
            }
        }

        public double BankTotal
        {
            get
            {
                return _bankTotal;
            }
            set
            {
                _bankTotal = value;
                OnPropertyChanged("BankTotal");
            }
        }

        public PaymentViewModel()
        {
            Total = 0;
            Inserted = 0;
            Change = 0;
            BankTotal = 0;
        }

        //Methode for at insætte penge
        public void Insert(double value)
        {
            Inserted += value;
        }

        //Sætter den totale prisen for et item
        public void SelectedPrice(double value)
        {
            Total = value;
        }

        //Methode der bekræfter at betaling kan laves
        public bool Confirm()
        {
            if (Inserted >= Total)
            {
                return true;
            }
            return false;
        }

        public void Pay()
        {
            Change = Total - Inserted;
            BankTotal += Total;
            Inserted = 0;
            Total = 0;
        }

        public void collect()
        {
            Console.WriteLine("Collected Payments: £" + BankTotal);
            BankTotal = 0;
        }
    }
}
