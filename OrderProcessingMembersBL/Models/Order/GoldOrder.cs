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
    public class GoldOrder: StandardOrder, INameTag, IWelcomingPackage, IDinner, ITaxi
    {
        public GoldOrder(Event @event, Member member, int nrOfTickets, IDelivery delivery, IPriceCalculator calculator)
            : base(@event, member, nrOfTickets, delivery, calculator)
        {
        }

        public string Afhaalservice()
        {
            throw new NotImplementedException();
        }

        public string Avondmaal()
        {
            throw new NotImplementedException();
        }

        public string Naamplaat(string naam)
        {
            throw new NotImplementedException();
        }

        public string Welkomstpakket()
        {
            throw new NotImplementedException();
        }
    }
}
