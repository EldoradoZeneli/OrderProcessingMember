using OrderProcessingMembersBL.Models;
using OrderProcessingMembersBL.Models.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Interfaces
{
    public interface IOrderManagerRepository
    {
        public List<Member> GeefLeden();
        public Member GetMemberByEmail(string email);
        public List<Event> GetEventList();

        public Dictionary<Event, List<StandardOrder>> GetOrdersByEvent();
    }
}
