using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Media;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISyntaxColoringService" in both code and config file together.
    [ServiceContract]
    public interface ISyntaxColoringService
    {
        [OperationContract]
        string GetTokensColorData( List<KeyValuePair<string, ETokenType>> tokenList );
    }
}
