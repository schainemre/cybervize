using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyber.Controllers
{
    public class MusterilerController1 : Controller
    {
        public IActionResult Listele()
        {
            return View(Models.MusterilerVeri.Musteriler);
        }
        public IActionResult yeni()
        {
            return View();
        }
        [HttpPost]
        public IActionResult yeni(Models.Musteriler YeniMusteriler)
        {
            Models.MusterilerVeri.Musteriler.Add(YeniMusteriler);
            return RedirectToAction("Listele");
            
        }
        public IActionResult Guncelle(int id)
        {
            
            var r = Models.MusterilerVeri.Musteriler.FirstOrDefault(x => x.ID == id);
            return View(r);
        }

        [HttpPost]
        public IActionResult Guncelle(Models.Musteriler musteri)
        {
            var c = Models.MusterilerVeri.Musteriler.FirstOrDefault(x => x.ID == musteri.ID);

            var r = Models.MusterilerVeri.Musteriler.FirstOrDefault(x => x.ID == musteri.ID);
            r.AD = musteri.AD;
            r.SOYAD = musteri.SOYAD;
            r.TCKIMLIKNO = musteri.TCKIMLIKNO;
            r.HIZMETYILI = musteri.HIZMETYILI;
            r.ISYERIADI = musteri.ISYERIADI;
            r.TELEFONNO = musteri.TELEFONNO;

            Models.MusterilerVeri.Musteriler.Remove(c);

            Models.MusterilerVeri.Musteriler.Add(r);

            return RedirectToAction("Listele");
        }

        public IActionResult Detay(int id)
        {
            var r = Models.MusterilerVeri.Musteriler.FirstOrDefault(x => x.ID == id);
            return View(r);
        }


        public IActionResult Sil(int id)
        {
            var r = Models.MusterilerVeri.Musteriler.FirstOrDefault(x => x.ID == id);
            return View(r);
        }

        [HttpPost]
        public IActionResult Sil(Models.Musteriler ogrenci)
        {
            var r = Models.MusterilerVeri.Musteriler.FirstOrDefault(x => x.ID == ogrenci.ID);
            Models.MusterilerVeri.Musteriler.Remove(r);
            return RedirectToAction("Listele");
        }
    }
}
