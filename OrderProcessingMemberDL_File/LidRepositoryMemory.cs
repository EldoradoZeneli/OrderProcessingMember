using OrderProcessingMembersBL.Enums;
using OrderProcessingMembersBL.Interfaces;
using OrderProcessingMembersBL.Manager;
using OrderProcessingMembersBL.Models;
using OrderProcessingMembersBL.Models.Status;
using System.Net;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OrderProcessingMemberDL_File
{
    public class LidRepositoryMemory : IOrderManagerRepository
    {

        private Dictionary<string, Member> leden;
        private Dictionary<int, Event> events;
        private OrderProcessingMembersBeheerder beheerder;
        private List<StandardOrder> orders;
        // string = key email voor methode memberbyemail

        public LidRepositoryMemory()
        {

            leden = new();
            events = new Dictionary<int, Event>();
            int eventId = 1;
            Address fakeadress = new Address("x", "x", "x", 1);

            Member member = new Member("Lucas", "lucas@school.be", EStatus.Gold, fakeadress);
            Member member2 = new Member("Eldorado", "eldorado@school.be", EStatus.Gold, fakeadress);
            Member member3 = new Member("Qwertygebruiker", "qwerty@school.be", EStatus.Gold, fakeadress);
            Member member4 = new Member("Kelly", "Kelly@school.be", EStatus.Gold, fakeadress);
            Member member5 = new Member("x", "x@school.be", EStatus.Gold, fakeadress);

            leden.Add(member.Email, member);
            leden.Add(member2.Email, member2);
            leden.Add(member3.Email, member3);
            leden.Add(member4.Email, member4);
            leden.Add(member5.Email, member5);

            Event event1 = new Event("josfest", DateTime.Now, 20.22, fakeadress);
            Event event2 = new Event("bickyavond", DateTime.Now, 29.22, fakeadress);
            Event event3 = new Event("hooplacon", DateTime.Now, 20.28, fakeadress);
            Event event4 = new Event("dalamudfall", DateTime.Now, 20.22, fakeadress);
            Event event5 = new Event("murdercon", DateTime.Now, 45.22, fakeadress);

            events.Add(eventId, event1);
            event1.Id = eventId;
            eventId++;
            events.Add(eventId, event2);
            event2.Id = eventId;
            eventId++;
            events.Add(eventId, event3);
            event3.Id = eventId;
            eventId++;
            events.Add(eventId, event4);
            event4.Id = eventId;
            eventId++;
            events.Add(eventId, event5);
            event5.Id = eventId;
            eventId++;

            StandardOrder o1 = beheerder.GetOrder(member, event1, 1);
            StandardOrder o2 = beheerder.GetOrder(member2, event1, 1);
            StandardOrder o3 = beheerder.GetOrder(member3, event1, 1);
            StandardOrder o4 = beheerder.GetOrder(member4, event2, 1);
            StandardOrder o5 = beheerder.GetOrder(member5, event2, 1);

            orders.Add(o1);
            orders.Add(o2);
            orders.Add(o3);
            orders.Add(o4);
            orders.Add(o5);

        }

        public List<Member> GeefLeden()
        {
            return leden.Values.ToList();
        }

        public List<Event> GetEventList()
        {
           return events.Values.ToList();
        }

        public Member GetMemberByEmail(string email)
        {
            if (leden.ContainsKey(email))
            {
                return leden[email];
            }
            else 
            {
                throw new Exception();
            }
            
        }

        public Dictionary<Event, List<StandardOrder>> GetOrdersByEvent()
        {
            Dictionary<Event, List<StandardOrder>> data = new();
            
            foreach(var x in orders)
            {

            }
        }
    }
}
