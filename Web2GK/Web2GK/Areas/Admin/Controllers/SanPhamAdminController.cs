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
                    string fileName1 = Guid.NewGuid().ToString();
                    string fileName2 = Guid.NewGuid().ToString();
                    string fileName3 = Guid.NewGuid().ToString();
                    string fileName4 = Guid.NewGuid().ToString();
                    string fullPathWithFileName = "/Assets/img/products/" + fileName + ".jpg";
                    string fullPathWithFileName1 = "/Assets/img/products/" + fileName + ".jpg";
                    string fullPathWithFileName2 = "/Assets/img/products/" + fileName + ".jpg";
                    string fullPathWithFileName3 = "/Assets/img/products/" + fileName + ".jpg";
                    string fullPathWithFileName4 = "/Assets/img/products/" + fileName + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName1));
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName2));
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName3));
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName4));
                    sp.HinhAnh = fullPathWithFileName;
                    sp.HinhAnh1 = fullPathWithFileName1;
                    sp.HinhAnh2 = fullPathWithFileName2;
                    sp.HinhAnh3 = fullPathWithFileName3;
                    sp.HinhAnh4 = fullPathWithFileName4;
                }
            }
            sp.TinhTrang = 0;
            SanPhamBus.ThemSP(sp);
            return RedirectToAction("Index");
        }

        // GET: Admin/SanPhamAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.MaLoaiSanPham = new SelectList(SanPhamBus.LDanhSach(), "MaLoaiSanPham", "TenLoaiSP");
            return View(SanPhamBus.ChiTietAdmin(id));
        }

        // POST: Admin/SanPhamAdmin/Edit/5
        [HttpPost, ValidateInput(false)]    
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

        [HttpPost]
        public ActionResult DeleteSP(int id)
        {
            
                // TODO: Add delete logic here
                SanPhamBus.xoatamDS(id);
                return RedirectToAction("Index");
        }
    }
}
