using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Interfaces
{
<<<<<<< HEAD:OrderProcessingMembersBL/Models/Event.cs
    public class Event
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Double TicketPriceEur { get; set; }

        public Event(int id, string name, DateTime date, double ticketPriceEur)
        {
            Id = id;
            Name = name;
            Date = date;
            TicketPriceEur = ticketPriceEur;
        }

=======
    public interface IDinner
    {
        string Avondmaal();
>>>>>>> c72e159f33774426b8aac4226db2c474323a102d:OrderProcessingMembersBL/Interfaces/IDinner.cs
    }
}
