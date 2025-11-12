using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models
{
    public class Adres
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNr { get; set; }
        public int Postcode { get; set; }

        public Adres(string city, string street, string houseNr, int postcode)
        {
            City = city;
            Street = street;
            HouseNr = houseNr;
            Postcode = postcode;
        }
        //public override string ToString()
        //{
        //    return $"{street} {houseNr}, {city} {Postcode}";
        //}
    }
}
