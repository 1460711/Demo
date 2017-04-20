using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web2GK.Models.Bus;

namespace Web2GK.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int page=1)
        {
            var dsSanPham = SanPhamBus.DanhSach(page,6);
            return View(dsSanPham);
        }
        public ActionResult Details(int id)
        {
            return View(SanPhamBus.ChiTiet(id));
        }

        public ActionResult Shop()
        {
            return View();
        }
        public ActionResult SingleProduct()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
    }
}