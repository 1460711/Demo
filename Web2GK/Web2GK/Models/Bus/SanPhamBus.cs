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
            return db.Query<SanPham>("select * from sanpham");
        }
        public static Page<SanPham> DanhSach(int page,int itempage)
        {
            var db = new WebGiuaKiConnectionDB();
            return db.Page<SanPham>(page, itempage,"select * from sanpham");
        }
        public static SanPham ChiTiet(int id)
        {
            var db = new WebGiuaKiConnectionDB();
            return db.SingleOrDefault<SanPham>("select *from sanpham where MaSP=@0",id);
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
    }
}