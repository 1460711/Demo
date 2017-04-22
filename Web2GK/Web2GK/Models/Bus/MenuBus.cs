using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGiuaKiConnection;

namespace Web2GK.Models.Bus
{
    public class MenuBus
    {
        public static IEnumerable<LoaiSanPham> DanhSach()
        {
            var sql = new WebGiuaKiConnectionDB();
            return sql.Query<LoaiSanPham>("select * from LoaiSanPham ");
        }

        public static Page<SanPham> DanhSach(int page, int itempage)
        {
            var sql = new WebGiuaKiConnectionDB();
            return sql.Page<SanPham>(page, itempage, "select * from SanPham ");
        }

        public static SanPham ChiTiet(int id)
        {
            var sql = new WebGiuaKiConnectionDB();
            return sql.SingleOrDefault<SanPham>("select * from SanPham ", id);
        }

        public static IEnumerable<SanPham> TatCaSanPham(int id)
        {
            var sql = new WebGiuaKiConnectionDB();
            return sql.Query<SanPham>("select * from SanPham where MaLoaiSanPham = @0", id).ToList();
        }
    }
}