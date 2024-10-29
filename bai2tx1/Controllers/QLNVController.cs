using bai2tx1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai2tx1.Controllers
{
    public class QLNVController : Controller
    {
        // GET: QLNV
        static List<NhanVien> ds;
        public QLNVController()
        {
            if (ds == null)
            {
                ds = new List<NhanVien>();
                ds.Add(new NhanVien("Nv01", "Nguyễn Văn Anh","Hà Nội", 15, 20000));
                ds.Add(new NhanVien("Nv02", "Lê Thu Hà", "Hải Phòng", 27, 25000));
                ds.Add(new NhanVien("Nv03", "Nguyễn Văn Hoàng", "Hà Nội", 18, 25000));
                ds.Add(new NhanVien("Nv04", "Trần Thu Hương", "Hải Phòng", 25, 19000));
                ds.Add(new NhanVien("Nv05", "Ngô Phương Thảo", "Quảng Ninh", 20, 18000));

            }
        }
        public ActionResult hienthi()
        {
            ViewBag.ds1 = ds.Where(s => s.songaylam < 20).ToList(); 
            ViewBag.ds2 = ds.Where(s => s.luongngay > 19000).ToList();
            return View();
        }
        public ActionResult nhap()
        {
            return View();
        }
        public ActionResult save( string manv, string ten, string diachi, int songaylam, double luongngay)
        {
            var a = new NhanVien(manv,ten,diachi,songaylam,luongngay);
            ds.Add(a);
            return View(ds);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}