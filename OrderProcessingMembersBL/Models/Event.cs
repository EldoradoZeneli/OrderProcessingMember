using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models;
public class Event
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public double TicketPriceEur { get; set; }
    public Address Address { get; set; }
    public Event(string name, DateTime date, double ticketPriceEur, Address address)
    {
        Name = name;
        Date = date;
        TicketPriceEur = ticketPriceEur;
        Address = address;
    }

    public Event(int? id, string name, DateTime date, double ticketPriceEur, Address address)
    {
        Id = id;
        Name = name;
        Date = date;
        TicketPriceEur = ticketPriceEur;
        Address = address;
    }

    public override string ToString()
    {
        return $"{Name} | {Date} | {TicketPriceEur} | {Address}";
    }
}
