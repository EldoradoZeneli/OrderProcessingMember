using BL.Interfaces;
using OrderProcessingMembersBL.Enums;
using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models.Status
{
    // IStatus is used to group every type of status, the Interface itself doesn't contain any logic
    public class BronzeOrder : StandardOrder, INameTag, IDinner
    {

        public override Levering TypeLevering()
        {
            return Levering.Standard;
        }

        public override decimal BerekenKost(decimal kost)
        {
            return kost + 100;
        }

        public string Naamplaat(string naam)
        {
            return "Naamplaat: " + naam;
        }

        public string Avondmaal()
        {
            return "Avondmaal!";
        }

    }
}
