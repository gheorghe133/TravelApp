using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelApplication.Models;

namespace TravelApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
        {
            new Product { 
                Title = "Amazon Cruise", 
                Description = "O călătorie incredibilă pe Amazon, explorând frumusețea naturii și a vieții sălbatice.",
                Photo = "/assets/images/gallery/gallery_01.jpg",
                Price = 1999.99 
            },
            new Product { 
                Title = "Egipt Expedition", 
                Description = "Descoperiți secretele istoriei și cultura Egiptului într-o aventură plină de mister și minuni arheologice.",
                Photo = "/assets/images/gallery/gallery_02.jpg", 
                Price = 2999.99 
            },
            new Product { 
                Title = "Mountain Retreat",
                Description = "Relaxați-vă în mijlocul naturii, respirați aer proaspăt de munte și bucurați-vă de priveliști spectaculoase.", 
                Photo = "/assets/images/gallery/gallery_03.jpg", 
                Price = 1599.99 
            },
        };

            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Packages()
        {
            ViewBag.Message = "Your packages page.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Your blog page.";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Your gallery page.";

            return View();
        }
    }
}