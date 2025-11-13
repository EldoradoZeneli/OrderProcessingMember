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
            return $"Pick-up Service FROM: {Member.Address.ToString()} TO: {Event.Address.ToString()}";
        }

        public string Avondmaal()
        {
            return "Avondmaal";
        }

        public string Naamplaat()
        {
            return "Naamplaat";
        }
        public string Welkomstpakket()
        {
            return "Welkomstpakket";
        }

        public override string ToString()
        {
            return $"{Member.Name} {Avondmaal()}, {Naamplaat()}, {Welkomstpakket()}, FROM: {Member.Address.ToString()} TO: {Event.Address.ToString()}";
        }

        public override void AddBenefitToList()
        {
            AddBenefit(Naamplaat());
            AddBenefit(Avondmaal());
            AddBenefit(Welkomstpakket());
            AddBenefit(Afhaalservice());
        }

    }
}
