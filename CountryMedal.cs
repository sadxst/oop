using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ПР4_завдання
{
    public class CountryMedal
    {
        public string Country { get; set; }
        public int AthletesCount { get; set; }
        public int MedalsCount { get; set; }

        public CountryMedal(string country, int athletesCount, int medalsCount)
        {
            Country = country;
            AthletesCount = athletesCount;
            MedalsCount = medalsCount;
        }
        public override string ToString()
        {
            return $"Країна: {Country}, Спортсменів: {AthletesCount}, Медалей: {MedalsCount}";
        }
    }
}
