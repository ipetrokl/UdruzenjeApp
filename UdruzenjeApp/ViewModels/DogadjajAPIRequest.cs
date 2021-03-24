using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdruzenjeApp.ViewModels
{
    public class DogadjajAPIRequest
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string VrijemeOdrzavanja { get; set; }
        public string opis { get; set; }
        public string OgranicenoMjesta { get; set; }
        public string brojMjesta { get; set; }

    }
}
