using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models
{
    public class Adres(string Land, string Provincie, string Gemeente, string Straat, string Huisnummer)
    {

        public override string ToString()
        {
            return $"{Straat} {Huisnummer}, {Gemeente}, {Provincie}, {Land}";
        }
    }

}
