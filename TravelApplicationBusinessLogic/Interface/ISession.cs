using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApplicationDomain.Entity.response;
using TravelApplicationDomain.Entity.user;

namespace TravelApplicationBusinessLogic.Interface
{
    public interface ISession
    {
        ULoginResp UserLoginAction(ULoginData data);

    }
}
