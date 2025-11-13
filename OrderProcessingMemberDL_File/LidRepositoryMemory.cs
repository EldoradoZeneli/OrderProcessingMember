using OrderProcessingMembersBL.Enums;
using OrderProcessingMembersBL.Interfaces;
using OrderProcessingMembersBL.Manager;
using OrderProcessingMembersBL.Models;
using OrderProcessingMembersBL.Models.Calculators;
using OrderProcessingMembersBL.Models.Deliveries;
using OrderProcessingMembersBL.Models.Status;
using System.Net;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OrderProcessingMemberDL_File
{
    public class LidRepositoryMemory : IOrderManagerRepository
    {
        private Dictionary<string, Member> _leden;
        private Dictionary<int, Event> _events;
        private List<StandardOrder> _orders;
        // string = key email voor methode memberbyemail

        // TODO <- [EDIT, LC]
        // Created a Dictionary for all the orders that are being added
        // key:
        //      -> eventName AND memberName of the Order,
        // value:
        //      -> StandardOrder object OR a class that inherits from StandardOrder
        // YOU CAN'T USE THE ID AS THE KEY SINCE THIS VALUE IS NULLABLE!

        //TODO is a list not an option? List<Member, List<Order>> _createdOrders 
        // this way are the orders for each member saved
        //private Dictionary<(Event eventName, Member memberName), StandardOrder> _createdOrders = new(); 
        private List<StandardOrder> _createdOrders;


        public LidRepositoryMemory()
        {
            _createdOrders = new List<StandardOrder>();

            _leden = new();
            _events = new Dictionary<int, Event>();
            _orders = new();
            
            int eventId = 1;
            Address fakeadress = new Address("x", "x", "x", 1);

            Member member = new Member("Lucas", "lucas@school.be", EStatus.Gold, fakeadress);
            Member member2 = new Member("Eldorado", "eldorado@school.be", EStatus.Gold, fakeadress);
            Member member3 = new Member("Qwertygebruiker", "qwerty@school.be", EStatus.Silver, fakeadress);
            Member member4 = new Member("Kelly", "Kelly@school.be", EStatus.Bronze, fakeadress);
            Member member5 = new Member("x", "x@school.be", EStatus.Standard, fakeadress);

            _leden.Add(member.Email, member);
            _leden.Add(member2.Email, member2);
            _leden.Add(member3.Email, member3);
            _leden.Add(member4.Email, member4);
            _leden.Add(member5.Email, member5);

            Event event1 = new Event("josfest", DateTime.Now, 20.22, fakeadress);
            Event event2 = new Event("bickyavond", DateTime.Now, 29.22, fakeadress);
            Event event3 = new Event("hooplacon", DateTime.Now, 20.28, fakeadress);
            Event event4 = new Event("dalamudfall", DateTime.Now, 20.22, fakeadress);
            Event event5 = new Event("murdercon", DateTime.Now, 45.22, fakeadress);

            _events.Add(eventId, event1);
            event1.Id = eventId;
            eventId++;
            _events.Add(eventId, event2);
            event2.Id = eventId;
            eventId++;
            _events.Add(eventId, event3);
            event3.Id = eventId;
            eventId++;
            _events.Add(eventId, event4);
            event4.Id = eventId;
            eventId++;
            _events.Add(eventId, event5);
            event5.Id = eventId;
            eventId++;

            //GoldOrder o1 = new(event1, member, 1, new ExpressDelivery(), new GoldCalculator());
            //GoldOrder o2 = new(event1, member2, 1, new ExpressDelivery(), new GoldCalculator());
            //SilverOrder o3 = new(event1, member3, 1, new ExpressDelivery(), new SilverCalculator());
            //BronzeOrder o4 = new(event2, member4, 1, new StandardDelivery(), new BronzeCalculator());
            //StandardOrder o5 = new(event2, member5, 1, new StandardDelivery(), new StandardCalculator());

            //_orders.Add(o1);
            //_orders.Add(o2);
            //_orders.Add(o3);
            //_orders.Add(o4);
            //_orders.Add(o5);

        }

        public List<Member> GeefLeden()
        {
            return _leden.Values.ToList();
        }


        public List<Event> GetEventList()
        {
            return _events.Values.ToList();
        }

        public Member GetMemberByEmail(string email)
        {
            if (_leden.ContainsKey(email))
            {
                return _leden[email];
            }
            else
            {
                // TODO < |EDIT, LC|
                // Instead  of throwing an exception, we return a null value
                // This way when a user tries to login with the wrong e-mail, the whole WPF app doesn't crash, it just does nothing
                // You can check how this null value is handeled, in the Click_LoginMember method in the MainWindow.xaml.cs file

                return null;

                # region Deprecated
                //throw new Exception();
                #endregion
            }
        }

        public List<StandardOrder> GetOrders()
        {

            #region [DEPRECATED] HARD CODED DATA
            //Dictionary<Event, List<StandardOrder>> data = new();

            //foreach(var x in _orders)
            //{
            //    if (!data.ContainsKey(x.Event))
            //    {
            //        data.Add(x.Event, new List<StandardOrder>() { x });
            //    }

            //    else
            //    {
            //        data[x.Event].Add(x);
            //    }
            //}
            //return data;
            //

            //foreach (var x in _createdOrders)
            //{
            //    if (!data.ContainsKey(x.Value.Event))
            //    {
            //        data.Add(x.Value.Event, new List<StandardOrder> { x.Value });
            //    }

            //    else
            //    {
            //        data[x.Value.Event].Add(x.Value);
            //    }
            //}
            //return data;
            #endregion

            // TODO < [EDIT, LC]

            return _createdOrders;

        }


        // TODO < [EDIT, LC]
        // Method that adds all the created orders in a list
        public void AddCurrentOrderToOrderList(StandardOrder returnedOrder)
        {

            _createdOrders.Add(returnedOrder);
        }

    }
}
