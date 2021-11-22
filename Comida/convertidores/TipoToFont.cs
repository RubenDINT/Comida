using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida.convertidores
{
    class TipoToFont : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String fuente;
            switch (value.ToString().ToUpper())
            {
                case "MEXICANA":
                    fuente = "Taco Salad";
                    break;
                case "AMERICANA":
                    fuente = "Slim Summer";
                    break;
                case "CHINA":
                    fuente = "Chinese Wok Food St";
                    break;
                default:
                    fuente = "Arial";
                    break;
            }
            return fuente;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
