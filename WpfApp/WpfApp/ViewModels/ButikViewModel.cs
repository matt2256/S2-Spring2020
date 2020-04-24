using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.ViewModels
{
    public class ButikViewModel : ObservableObjects
    {
        public ObservableCollection<ProductViewModel> items { get; private set; }
        public PaymentViewModel Bank { get; private set; }

        public ButikViewModel()
        {
            Bank = new PaymentViewModel();
            items = new ObservableCollection<ProductViewModel>()
            {
                new ProductViewModel(1, "Filur", 10),
                new ProductViewModel(2, "Twiser", 9),
                new ProductViewModel(3, "Københavnerstang", 5),
                new ProductViewModel(4, "Magnum", 20)
            };
        }

        public void Purchase(object item)
        {
            var requestedItem = item as ProductViewModel;
            Bank.SelectedPrice(requestedItem.information.Price);

            if (Bank.Confirm())
            {
                if (requestedItem.Dispense())
                {
                    Bank.Pay();
                    Console.WriteLine("Nyd de køb");
                }
            }
        }

        public void InsertChange(double value)
        {
            Bank.Insert(value);
        }

        public void CollectPayments()
        {
            Bank.collect();
        }

        public void Refill()
        {
            foreach (var i in items)
            {
                i.Refil();
            }
            Console.WriteLine("Butikken er nu blevet fuldt op");
        }

        public void Empty()
        {
            foreach (var i in items)
            {
                i.Empty();
            }
            Console.WriteLine("Butikken er nu blevet tømt");
        }
    }
}
