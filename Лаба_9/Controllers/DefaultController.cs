using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Лаба_9.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        BD_BIPITEntities BD_BIPIT = new BD_BIPITEntities();

        //public ActionResult Client()
        //{
        //    IEnumerable<Client> client = BD_BIPIT.Client;
        //    ViewBag.Client = client;
        //    return View("Client");
        //}
        public ActionResult Сlient()
        {
            IEnumerable<Сlient> Сlient = BD_BIPIT.Сlient;
            ViewBag.Сlient = Сlient;
            return View("Сlient");
        }
        public ActionResult Service()
        {
            IEnumerable<Service> Service = BD_BIPIT.Service;
            ViewBag.Service = Service;
            return View("Service");
        }

        public ActionResult Order()
        {
            IEnumerable<Order> Order = BD_BIPIT.Order;
            ViewBag.Order = Order;
            return View("Order");
        }
    }
}