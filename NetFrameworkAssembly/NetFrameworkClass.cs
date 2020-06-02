using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkAssembly
{
    public class NetFrameworkClass
    {
        public string NetFrameworkSpecificProperty => System.Web.Mail.MailFormat.Html.ToString();
        public string AnyProperty => "Any property from net framewok";
    }
}
