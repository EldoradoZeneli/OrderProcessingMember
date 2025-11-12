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
    
    public class StandardOrder : IDelivery, iPriceCalculator
    {
        public virtual decimal BerekenKost(decimal kost)
        {
            return kost;
        }

        
    }
}
