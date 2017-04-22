using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGiuaKiConnection;

namespace Web2GK.Areas.Admin.Models.BUS
{
    public class NhaSanXuat
    {
        public static IEnumerable<LoaiSanPham> DanhSach()
        {
            var db = new WebGiuaKiConnectionDB();
            return db.Query<LoaiSanPham>("select * from LoaiSanPham");
        }
        public static void Them(LoaiSanPham sx)
        {
            var sql = new WebGiuaKiConnectionDB();
            sql.Insert(sx);
        }
    }
}