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
    public class BronzeOrder : StandardOrder, INameTag
    {
        public BronzeOrder(Event @event, Member member, int nrOfTickets, IDelivery delivery, IPriceCalculator calculator) 
            : base(@event, member, nrOfTickets, delivery, calculator)
        {
        }

        public string Naamplaat()
        {
            return $"Naamplaat";
        }

        public override string ToString()
        {
            return $"{Member.Name} {Naamplaat()}";
        }

    }
}
