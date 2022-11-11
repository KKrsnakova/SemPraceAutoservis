using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservis.Model
{
    public class AutoModel
    {
    }

    public class Auto : INotifyPropertyChanged
    {
        private string znackaVozu;
        private string modelVozu;
        private string spz;
        private string vin;
        private string barva;

        public string ZnackaVozu
        {
            get
            {
                return znackaVozu;
            }

            set
            {
                if (znackaVozu != value)
                {
                    znackaVozu = value;
                    RaisePropertyChanged("ZnackaVozu");
                }
            }
        }

        public string ModelVozu
        {
            get { return modelVozu; }

            set
            {
                if (modelVozu != value)
                {
                    modelVozu = value;
                    RaisePropertyChanged("ModelVozu");
                }
            }
        }

        public string Spz
        {
            get { return spz; }

            set
            {
                if (spz != value)
                {
                    spz = value;
                    RaisePropertyChanged("Spz");
                }
            }
        }

        public string Vin
        {
            get { return vin; }

            set
            {
                if (vin != value)
                {
                    vin = value;
                    RaisePropertyChanged("Vin");
                }
            }
        }

        public string Barva
        {
            get { return barva; }

            set
            {
                if (barva != value)
                {
                    barva = value;
                    RaisePropertyChanged("Barva");
                }
            }
        }

      
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
