using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdruzenjeApp.Data;
using UdruzenjeApp.Models;
using UdruzenjeApp.ViewModels;

namespace UdruzenjeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AngularHome : ControllerBase
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        [HttpGet]
        public List<Dogadjaj> GetDogadjaji() {
            return _db.dogadjaj.Include(x=>x.Upravitelj).Include(x=>x.grad).ToList();
        }

        [HttpPost]
        public Dogadjaj Dodaj([FromBody] DogadjajAPIRequest request)
        {
            Dogadjaj nd = new Dogadjaj()
            {
                Naziv = request.Naziv,
                brojMjesta = int.Parse(request.brojMjesta),
                OgranicenoMjesta = true,
                VrijemeOdrzavanja = DateTime.Parse(request.VrijemeOdrzavanja),
                opis = request.opis,
                GradID = 1,
                UpraviteljID = 1005
            };

            _db.dogadjaj.Add(nd);
            _db.SaveChanges();
            return nd;
        }
        [HttpDelete]
        public int Delete()
        {
            _db.dogadjaj.RemoveRange(_db.dogadjaj.ToList());
            _db.SaveChanges();
            return 1;
        }
        
    }
}
