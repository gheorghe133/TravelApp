using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApplicationDomain.Entity.response;
using TravelApplicationDomain.Entity.user;

namespace TravelApplicationBusinessLogic.Core
{
    public class UserAPI
    {
        public ULoginResp RLoginUpService(ULoginData data)
        {

            //Stepel - SELECT FROM DB> User WARE CREDENTIAL == data.Credential  AND
            //POSSWORD == data.Password 
            //STEP2 - IF object != NULL
            //CREATE SESSION
            //RETURN SESSION AND STATUS TRUE
            return new ULoginResp { Status = false };
        }
    }
}
