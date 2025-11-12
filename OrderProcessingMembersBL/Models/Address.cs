using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNr { get; set; }
        public int Postcode { get; set; }

        public Address(string city, string street, string houseNr, int postcode)
        {
            City = city;
            Street = street;
            HouseNr = houseNr;
            Postcode = postcode;
        }

        public override string ToString()
        {
            return $"{Street} {HouseNr}, {City} {Postcode}";
        }
    }

}
