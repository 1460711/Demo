using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web2GK.Areas.Admin.Models.BUS;
using WebGiuaKiConnection;

namespace Web2GK.Areas.Admin.Controllers
{
    public class LoaiSanPhamController : Controller
    {
        // GET: Admin/LoaiSanPham
        public ActionResult Index()
        {
            return View(NhaSanXuat.DanhSachAdmin());
        }

        // GET: Admin/LoaiSanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/LoaiSanPham/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Admin/LoaiSanPham/Create
        [HttpPost]
        public ActionResult Create(LoaiSanPham p)
        {
            try
            {
                // TODO: Add insert logic here
                p.TinhTrang = 0;
                NhaSanXuat.Them(p);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LoaiSanPham/Edit/5
        public ActionResult Edit(int id)
        {
            return View(NhaSanXuat.ChitietAdmin(id));
        }

        // POST: Admin/LoaiSanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, LoaiSanPham lsp)
        {
            try
            {
                // TODO: Add update logic here
                lsp.TinhTrang = 0;
                NhaSanXuat.Updatensx(id, lsp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult XoaTamThoi(int id)
        {
            return View(NhaSanXuat.ChitietAdmin(id));
        }
        public ActionResult XoaTamThoi(int id, LoaiSanPham lsp)
        {
            try
            {
                // TODO: Add delete logic here
                NhaSanXuat.Updatensx(id, lsp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Admin/LoaiSanPham/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/LoaiSanPham/Delete/5
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
        public ActionResult DeleteNSX(int id)
        {
            try
            {
                // TODO: Add delete logic here
                NhaSanXuat.DeleteDS(id);
                TempData["Success"] = "Xoa thanh cong !";
            }
            catch
            {
                TempData["Error"] = "Xoa khong thanh cong !";
            }

            return RedirectToAction("Index");
        }
    }
}
