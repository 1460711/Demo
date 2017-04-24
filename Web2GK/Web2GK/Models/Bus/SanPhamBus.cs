using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGiuaKiConnection;

namespace Web2GK.Models.Bus
{
    public class SanPhamBus
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new WebGiuaKiConnectionDB();
            return db.Query<SanPham>("select * from SanPham where TinhTrang =0");
        }
        public static Page<SanPham> DanhSach(int page,int itempage)
        {
            var db = new WebGiuaKiConnectionDB();
            return db.Page<SanPham>(page, itempage,"select * from SanPham");
        }
        public static SanPham ChiTiet(int id)
        {
            var db = new WebGiuaKiConnectionDB();
            return db.SingleOrDefault<SanPham>("select *from SanPham where MaSP=@0",id);
        }
        public static void ThemSP(SanPham sp)
        {
            var db = new WebGiuaKiConnectionDB();
            db.Insert(sp);
        }
        public static IEnumerable<LoaiSanPham> LDanhSach()
        {
            using (var db = new WebGiuaKiConnectionDB())
            {
                return db.Query<WebGiuaKiConnection.LoaiSanPham>("select * from LoaiSanPham");
            }
                
        }
        public static IEnumerable<SanPham> DanhSachAdmin()
        {
            var db = new WebGiuaKiConnectionDB();
            return db.Query<SanPham>("select * from SanPham");
        }
        public static SanPham ChiTietAdmin(int id)
        {
            var db = new WebGiuaKiConnectionDB();
            return db.SingleOrDefault<SanPham>("select *from SanPham where MaSP=@0", id);
        }


        //--------xoa tam thoi san pham--------------------//
        public static void xoatamDS(int id)
        {
            using (var db = new WebGiuaKiConnectionDB())
            {
                var lsp = db.Single<SanPham>("select * from SanPham where MaSP = @0", id);

                lsp.TinhTrang = 1;
                db.Update("SanPham", "MaSP", lsp);
            }
        }

    }
}