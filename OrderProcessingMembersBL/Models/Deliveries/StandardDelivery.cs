using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models.Deliveries;
public class StandardDelivery : IDelivery
{
    public string SendOrder()
    {
        return $"standard delivery!";
    }
}
