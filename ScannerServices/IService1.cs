using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Media;

namespace ScannerServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IColoringService" in both code and config file together.
    [ServiceContract]
    public interface IColoringService
    {
        [OperationContract]
        List<KeyValuePair<string, SolidColorBrush>> GetTokensColorData(List<KeyValuePair<string, ETokenType>> tokenList);
    }
}
