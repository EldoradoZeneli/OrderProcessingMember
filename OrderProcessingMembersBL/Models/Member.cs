using OrderProcessingMembersBL.Enums;
using OrderProcessingMembersBL.Interfaces;
using OrderProcessingMembersBL.Models.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models
{
    public class Member
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public EStatus Status { get; set; }
        public Address Address { get; set; }
        public Member(string name, string email, EStatus status, Address address)
        {
            Name = name;
            Email = email;
            Status = status;
            Address = address;
        }

        //public override string ToString()
        //{
        //    return $"ID: {Id}, Naam: {Name}, Email: {Email},\n Adres: {Adres},\n Status: {Status}";
        //}


    }
}
