
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
        public ObservableCollection<Auto> Auta
        {
            get;
            set;
        }

        public void LoadAuta()
        {
            ObservableCollection<Auto> seznamAut = new ObservableCollection<Auto>();

            seznamAut.Add(new Auto
            {
                ZnackaVozu = "Škoda",
                ModelVozu = "Fabia",
                Spz = "2SD853",
                Vin = "xdsd44s4s",
                Barva = "Modrá"
            });
            seznamAut.Add(new Auto
            {
                ZnackaVozu = "Ford",
                ModelVozu = "Focus",
                Spz = "2SD883",
                Vin = "fddes4445s6",
                Barva = "Červená"
            });
           
            Auta = seznamAut;
        }
    }
}
