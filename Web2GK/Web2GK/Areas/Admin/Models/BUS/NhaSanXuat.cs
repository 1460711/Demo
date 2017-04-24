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
        //--Admin
        public static void Them(LoaiSanPham sx)
        {
            var sql = new WebGiuaKiConnectionDB();
            sql.Insert(sx);
        }
        public static IEnumerable<LoaiSanPham> DanhSachAdmin()
        {
            var db = new WebGiuaKiConnectionDB();
            return db.Query<LoaiSanPham>("select * from LoaiSanPham");
        }
        public static LoaiSanPham ChitietAdmin(int id)
        {
            var db = new WebGiuaKiConnectionDB();
            return db.SingleOrDefault<LoaiSanPham>("select * from LoaiSanPham where MaLoaiSanPham = @0", id);
        }
        public static void Updatensx(int id, LoaiSanPham lsp)
        {
            {
                var sql = new WebGiuaKiConnectionDB();
                sql.Update(lsp, id);
            }
        }
        public static void DeleteDS(int id)
        {
            using (var db = new WebGiuaKiConnectionDB())
            {
                var lsp = db.Single<LoaiSanPham>("select * from LoaiSanPham where MaLoaiSanPham = @0", id);

                lsp.TinhTrang = 1;
                db.Update("LoaiSanPham", "MaLoaiSanPham", lsp);
            }
        }

    }
}