using go_blogs.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace go_blogs.Controllers
{
    public class MobilController : Controller
    {
        public IActionResult Index()
        {
            //cara 1 instansiasi varibael (jika tidak tahu tipe datanya)
            var mobils = new List<Mobil>();

            //cara 2  instansiasi (lebih disarankan untuk kecepatan program)
            //IEnumerable<Mobil> mobils2 = new List<Mobil>();

            //cara 3 instansiasi variabel (untuk tipe data list)
            //List<Mobil> mobils3 = new List<Mobil>();

            //mobils.Add(new Mobil
            //{
            //    IDRegistrasi = 1,
            //    Tipe = "Sedan",
            //    Merk = "Toyota",
            //    Varian = "Apple",
            //});

            //mobils.Add(new Mobil
            //{
            //    IDRegistrasi = 2,
            //    Tipe = "Bus",
            //    Merk = "Toyota",
            //    Varian = "Android",
            //});

            //string nama = "Anti";

            //cara 1 menampung data untuk dikirim ke html
            //ViewBag.namaSaya = nama;
            //ViewBag.mobils = mobils;

            //cara 2 menampung data untuk dikirim ke html
            //ViewData["nama"] = "Anti";

            //cara 3 menampung data untuk dikirim ke html
            //return View(mobils);

            var banyakMobil = new Mobil[]
            {
                new Mobil{IDRegistrasi = 1, Tipe = "Sedan", Merk = "Toyota", Varian = "FT86"},
                new Mobil{IDRegistrasi = 2, Tipe = "SUV", Merk = "Toyota", Varian = "RAV4"},
                new Mobil{IDRegistrasi = 3, Tipe = "Sedan", Merk = "Honda", Varian = "Accord"},
                new Mobil{IDRegistrasi = 4, Tipe = "SUV", Merk = "Honda", Varian = "CRV"},
                new Mobil{IDRegistrasi = 5, Tipe = "Sedan", Merk = "Honda", Varian = "City"},
            };

            var cariMobil = banyakMobil.Where(x => x.Tipe == "Sedan");
            var pertama = banyakMobil.Where(x => x.Merk == "Honda").FirstOrDefault();
            var tampil = banyakMobil.Where(x => x.Tipe == "Sedan" && x.Merk== "Honda");
            var tampil2 = banyakMobil.Where(x => x.Merk == "Honda" && x.Varian == "City").FirstOrDefault();
            var tampil3 = banyakMobil.Where(x => x.Merk == "Toyota");

            ViewBag.mobils = pertama;
            
            return View(banyakMobil);
        }
    }
}
