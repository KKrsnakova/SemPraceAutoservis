
using Autoservis.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservis.ViewModel
{
    internal class AutoViewModel
    {
        public static ObservableCollection<Auto> Auta
        {
            get;
            set;
        }

        public void LoadAuta()
        {
            ObservableCollection<Auto> seznamAut = new ObservableCollection<Auto>();

            seznamAut.Add(new Auto
            {
                IdVozu = 1,
                ZnackaVozu = "Škoda",
                ModelVozu = "Fabia",
                Spz = "2SD853",
                Vin = "xdsd44s4s",
                Barva = "Modrá",
                IdKlienta = 1
            });
            seznamAut.Add(new Auto
            {
                IdVozu = 2,
                ZnackaVozu = "Ford",
                ModelVozu = "Focus",
                Spz = "2SD883",
                Vin = "fddes4445s6",
                Barva = "Červená",
                IdKlienta = 2
                
            });
            Auta = seznamAut;
        }
    }
}
