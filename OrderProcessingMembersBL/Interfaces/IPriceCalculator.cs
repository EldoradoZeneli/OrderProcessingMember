using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Interfaces
{
    public interface IPriceCalculator
    {
        decimal GetPrice(decimal cost);
    }
}
