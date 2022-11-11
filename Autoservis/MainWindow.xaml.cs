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

namespace Autoservis
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
        private void ZakaznikViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            Autoservis.ViewModel.ZakaznikViewModel zakaznikViewModelObject =
               new Autoservis.ViewModel.ZakaznikViewModel();
            zakaznikViewModelObject.LoadStudents();

            ZakaznikViewControl.DataContext = zakaznikViewModelObject;
        }

        private void AutoViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            Autoservis.ViewModel.AutoViewModel autoViewModelObject =
               new Autoservis.ViewModel.AutoViewModel();
            autoViewModelObject.LoadAuta();

            ZakaznikViewControl.DataContext = autoViewModelObject;
        }

        private void PridejViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            Autoservis.ViewModel.ZakaznikViewModel autoViewModelObject =
               new Autoservis.ViewModel.ZakaznikViewModel();

            ZakaznikViewControl.DataContext = autoViewModelObject;
        }

    }
}
