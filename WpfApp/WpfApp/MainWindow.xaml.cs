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
using WpfApp.ViewModels;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ButikViewModel _butik = new ButikViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _butik;
        }

        #region Payment
        private void BtnMoneyLeft_Click(object sender, RoutedEventArgs e)
        {
            _butik.InsertChange(5);
        }

        private void BtnMoneyCenter_Click(object sender, RoutedEventArgs e)
        {
            _butik.InsertChange(10);
        }

        private void BtnMoneyRight_Click(object sender, RoutedEventArgs e)
        {
            _butik.InsertChange(20);
        }
        #endregion

        #region Mangement
        private void BtnRefil_Click(object sender, RoutedEventArgs e)
        {
            _butik.Refill();
        }

        private void BtnEmpty_Click(object sender, RoutedEventArgs e)
        {
            _butik.Empty();
        }

        private void Withdraw_Click(object sender, RoutedEventArgs e)
        {
            _butik.CollectPayments();
        }


        #endregion

        #region Betaling
        private void Purchase_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            _butik.Purchase(button.DataContext);
        }
        #endregion


    }
}
