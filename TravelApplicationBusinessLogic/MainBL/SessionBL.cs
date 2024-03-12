using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApplicationBusinessLogic.Core;
using TravelApplicationBusinessLogic.Interface;
using TravelApplicationDomain.Entity.response;
using TravelApplicationDomain.Entity.user;

namespace TravelApplicationBusinessLogic.MainBL
{
    public class SessionBL : UserAPI ,ISession
    {
        public ULoginResp UserLoginAction(ULoginData data) 
        {
            return RLoginUpService(data);


        }
    }
}

