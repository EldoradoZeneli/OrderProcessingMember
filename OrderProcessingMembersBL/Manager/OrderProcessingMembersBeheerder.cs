using OrderProcessingMembersBL.Enums;
using OrderProcessingMembersBL.Interfaces;
using OrderProcessingMembersBL.Models;
using OrderProcessingMembersBL.Models.Calculators;
using OrderProcessingMembersBL.Models.Deliveries;
using OrderProcessingMembersBL.Models.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Manager
{
    public class OrderProcessingMembersBeheerder
    {
        private IOrderManagerRepository _repo;

        public OrderProcessingMembersBeheerder(IOrderManagerRepository repo)
        {
            _repo = repo;
        }

        public StandardOrder GetOrder(Member member, Event @event, int nrOfTickets)
        {
            StandardOrder order;
            var typeOrder = member.Status switch
            {
                EStatus.Gold => order = new GoldOrder(@event, member, nrOfTickets, new ExpressDelivery(),
                new GoldCalculator()),
                EStatus.Silver => order = new SilverOrder(@event, member, nrOfTickets, new ExpressDelivery(), new SilverCalculator()),
                EStatus.Bronze => order = new BronzeOrder(@event, member, nrOfTickets, new StandardDelivery(), new BronzeCalculator()),
                _ => order = new StandardOrder(@event, member, nrOfTickets, new StandardDelivery(), new StandardCalculator())
            };
            return order;
        }

        public Member GetMemberByEmail(string email)
        {
            return _repo.GetMemberByEmail(email);
        }

        public List<Event> GetEventList()
        {
            return _repo.GetEventList();
        }
        public List<Member> GeefLeden()
        {
            return _repo.GeefLeden();
        }

        public Dictionary<Event, List<StandardOrder>> GetOrdersByEvent()
        {

            return _repo.GetOrdersByEvent();
        }

        // TODO < [EDIT, LC]
        // Asking to repo to add the current order to the current order list
        public void AddCurrentOrderToOrderList(StandardOrder returnedOrder)
        {
            _repo.AddCurrentOrderToOrderList(returnedOrder);
        }
    }
}
