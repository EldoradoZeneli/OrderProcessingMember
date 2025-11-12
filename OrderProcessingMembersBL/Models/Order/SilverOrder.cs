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
    public class SilverOrder : StandardOrder, INameTag, IWelcomingPackage, IDinner
    {
        public SilverOrder(Event @event, Member member, int nrOfTickets, IDelivery delivery, IPriceCalculator calculator)
            : base(@event, member, nrOfTickets, delivery, calculator)
        {

        }

        public string Avondmaal()
        {
            return "avondmaal";
        }

        public string Naamplaat(string naam)
        {
            return $"Naamplaat: {naam}";
        }

        public string Welkomstpakket()
        {
            return "Welkomstpakket";
        }
    }
}
