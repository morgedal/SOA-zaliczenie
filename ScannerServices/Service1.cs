using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Media;
using Services;

namespace ScannerServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ColoringService" in both code and config file together.
    public class ColoringService : IColoringService
    {
        public List<KeyValuePair<string, SolidColorBrush>> GetTokensColorData(List<KeyValuePair<string, ETokenType>> tokenList)
        {
            var a = new KeyValuePair<string, SolidColorBrush>("main", Brushes.Blue);
            var l = new List<KeyValuePair<string, SolidColorBrush>>();

            l.Add(a);

            return l;
        }

    }
}
