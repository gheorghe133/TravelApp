using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TravelApplication.Modelss;
using TravelApplication.Modelss.user;
using TravelApplicationBusinessLogic;
using TravelApplicationBusinessLogic.Interface;
using TravelApplicationDomain.Entity.response;
using TravelApplicationDomain.Entity.user;

namespace TravelApplication.Controllers
{
    public class LoginControllers : Controller
    {
        private readonly ISession _session;

        public LoginControllers() 
        {
            var bl = new BusinessLogic();
            _session = bl.GetSessionBL();

        }
        public ActionResult Index()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Index(userLogin data)
        {

            var uData = new ULoginData
            {
                Credential = data.Credential,
                Password = data.Password,
                Ip ="0.0.0.0",
                LoginTime = DateTime.Now
            };
            ULoginResp resp = _session.UserLoginAction(uData);
            return View();

        }
        
    }
}