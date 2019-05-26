using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdruzenjeApp.ViewModels
{
    public class DogadjajiViewModel
    {
        public string Naziv { get; set; }
        public DateTime VrijemeOdrzavanja { get; set; }
        public string opis { get; set; }
        public bool OgranicenoMjesta { get; set; }
        public int brojMjesta { get; set; }
        public int DogadjajID { get; set; }

    }
}
