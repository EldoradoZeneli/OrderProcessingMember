using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models.Calculators;
public class GoldCalculator : IPriceCalculator
{
    public decimal GetPrice(decimal cost)
    {
        return cost * 3;
    }
}
