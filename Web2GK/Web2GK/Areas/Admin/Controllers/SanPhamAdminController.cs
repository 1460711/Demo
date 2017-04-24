using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web2GK.Models.Bus;
using WebGiuaKiConnection;

namespace Web2GK.Areas.Admin.Controllers
{
    public class SanPhamAdminController : Controller
    {
        // GET: Admin/SanPhamAdmin
        public ActionResult Index()
        {
            var ds = SanPhamBus.DanhSachAdmin();
            return View(ds);
        }

        // GET: Admin/SanPhamAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/SanPhamAdmin/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiSanPham = new SelectList(SanPhamBus.LDanhSach(), "MaLoaiSanPham", "TenLoaiSP");
            return View();
        }

        // POST: Admin/SanPhamAdmin/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(SanPham  sp)
        {
            {
                // TODO: Add insert logic here
                //Hàm thêm
                if (HttpContext.Request.Files.Count > 0) { }

                var hpf = HttpContext.Request.Files[0];
                if (hpf.ContentLength > 0)
                {
                    string fileName = Guid.NewGuid().ToString();

                    string fullPathWithFileName = "/Assets/img/products/" + fileName + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.HinhAnh = fullPathWithFileName;
                    sp.HinhAnh1 = fullPathWithFileName;
                    sp.HinhAnh2 = fullPathWithFileName;
                    sp.HinhAnh3 = fullPathWithFileName;
                    sp.HinhAnh4 = fullPathWithFileName;
                }
            }
            sp.TinhTrang = 0;
            SanPhamBus.ThemSP(sp);
            return RedirectToAction("Index");
        }

        // GET: Admin/SanPhamAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View(SanPhamBus.ChiTietAdmin(id));
        }

        // POST: Admin/SanPhamAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SanPhamAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/SanPhamAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
