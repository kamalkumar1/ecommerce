using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ecomservice
{
    [ServiceContract]
    interface IUser
    {
        [OperationContract]
        void AuthenticateUser(string username, string passowrd);
       
    }
}
