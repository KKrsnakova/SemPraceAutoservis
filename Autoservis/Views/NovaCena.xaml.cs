using Autoservis.Model;
using Autoservis.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Autoservis.Views
{
    /// <summary>
    /// Interaction logic for NovaCena.xaml
    /// </summary>
    public partial class NovaCena : Window
    {
        
        public NovaCena()
        {
            InitializeComponent();
            if(ServisView.editP)
            {
                polozka.Text = ServisView.cena.Polozka;
                cena.Text = ServisView.cena.CenaPolozky+"";
            }
        }

        private void pridat_Click(object sender, RoutedEventArgs e)
        {
            Thread threadAdd = new Thread(() =>
            {
                if (ServisView.editP)
                {
                    try
                    {
                        Dispatcher.Invoke(() => ServisView.cena.Polozka =  polozka.Text);
                        Dispatcher.Invoke(() => ServisView.cena.CenaPolozky =  int.Parse(cena.Text));
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show("Chybne vyplněno" + e, "Chyba");
                    }

                }
                else
                {
              
                    try
                    {
                        Dispatcher.Invoke(() => CenaViewModel.SeznamCenaServisu.Add(new Cena
                        {
                            Polozka = Dispatcher.Invoke(() => polozka.Text),
                            CenaPolozky = Dispatcher.Invoke(() => int.Parse(cena.Text)),
                            IdServisu = Dispatcher.Invoke(() => ServisView.servis.IdServis)
                        }));
                    }

                    catch (Exception e)
                    {
                        MessageBox.Show("Chybně vyplněno" + e, "Chyba");
                    }

                }
             Dispatcher.Invoke(() => NovaCena.GetWindow(this).Close());

            });
            threadAdd.Start();
        }


        private void konec_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(() => NovaCena.GetWindow(this).Close());
        }
    }
}
