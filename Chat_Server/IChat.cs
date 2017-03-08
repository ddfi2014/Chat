using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Server
{
    [ServiceContract]
    public interface IChat
    {
        [OperationContract]
        String[] machWas();
    }
}
