using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> listaPlatos;

        public ObservableCollection<Plato> ListaPlatos
        {
            get { return listaPlatos; }
            set { listaPlatos = value;
                NotifyPropertyChanged("ListaPlatos");
            }
        }
        private Plato platoActual;

        public Plato PlatoActual
        {
            get { return platoActual; }
            set { platoActual = value;
                NotifyPropertyChanged("PlatoActual");
            }
        }

        private ObservableCollection<String> tipoComida;

        public ObservableCollection<String> TipoComida
        {
            get { return tipoComida; }
            set { tipoComida = value;
                NotifyPropertyChanged("TipoComida");
            }
        }


        public MainWindowVM()
        {
            listaPlatos = Plato.GetSamples("assets/");
            tipoComida = Plato.GetTiposComida();
        }

        //Implementación de la interfaz INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
