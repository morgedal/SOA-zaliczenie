using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Media;

namespace Lexer_Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        public List<KeyValuePair<string, string>> GetTokensColorData(List<KeyValuePair<string, ETokenType>> tokenList)
        {
            var a = new KeyValuePair<string, string>("main", "Blue");
            var l = new List<KeyValuePair<string, string>>();

            l.Add(a);

            return l;
        }
    }
}
