using System;
using System.Collections.Generic;
using System.Linq;
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

namespace HT1___Control_Workspace
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Customer customer;
        public MainWindow()
        {
            InitializeComponent();        
            cbType.Items.Add("Low");
            cbType.Items.Add("Middle");
            cbType.Items.Add("High");
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            customer = new Customer(tbName.Text, tbSurname.Text, tbEmail.Text, cbType.SelectedValue.ToString());
            lbCustomers.Items.Add(customer);
        }
    }
}
