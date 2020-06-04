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

namespace HT_5___ColorPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public VM vm { get; set; } = new VM();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
            lbColors.ItemsSource = vm.colors;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            vm.colors.Add(new CustomColor
            {
                Alpha = vm.customColor.Alpha,
                Red = vm.customColor.Red,
                Green = vm.customColor.Green,
                Blue = vm.customColor.Blue
            });
            vm.CheckExist = vm.checkExistColorInCollection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            vm.colors.Remove((CustomColor)btn.DataContext);
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblPreviewColor.Background = new SolidColorBrush(Color.FromArgb(vm.customColor.Alpha, vm.customColor.Red, vm.customColor.Green, vm.customColor.Blue));
            vm.CheckExist = vm.checkExistColorInCollection();
        }
    }
}
