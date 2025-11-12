using BL.Interfaces;
using OrderProcessingMembersBL.Enums;
using OrderProcessingMembersBL.Interfaces;
using OrderProcessingMembersBL.Models.Deliveries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models.Status
{
    
    public class StandardOrder
    {
        private List<string> _benefits;
        public int? Id { get; set; }
        public Event Event { get; set; }
        public Member Member { get; set; }
        public int NrOfTickets { get; set; }
        public IReadOnlyList<string> Benefits => _benefits;
        public IDelivery Delivery { get; set; }
        public IPriceCalculator Calculator { get; set; }

        public StandardOrder(Event @event, Member member, int nrOfTickets, IDelivery delivery, IPriceCalculator calculator)
        {
            Event = @event;
            Member = member;
            NrOfTickets = nrOfTickets;
            Delivery = delivery;
            Calculator = calculator;
        }

    }
}
