using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai2tx1.Models
{
    public class NhanVien
    {
        public string manv {  get; set; }
        public string ten { get; set; }
        public string diachi {  get; set; }
        public int songaylam {  get; set; }
        public double luongngay {  get; set; }

        public double tongluong { get { return luongngay * songaylam; } }
        
        

        public NhanVien() { }
        public NhanVien(string manv, string ten, string diachi, int songaylam, double luongngay)
        {
            this.manv = manv;
            this.ten = ten;
            this.diachi = diachi;
            this.songaylam = songaylam;
            this.luongngay = luongngay;
           
        }
    }
}