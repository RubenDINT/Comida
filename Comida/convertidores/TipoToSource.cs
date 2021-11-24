using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida.convertidores
{
    class TipoToSource : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String source;
            switch (value.ToString().ToUpper())
            {
                case "MEXICANA":
                    source = "/assets/mexico.png";
                    break;
                case "AMERICANA":
                    source = "/assets/united_states.png";
                    break;
                case "CHINA":
                    source = "/assets/china.png";
                    break;
                default:
                    source = "";
                    break;
            }
            return source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
