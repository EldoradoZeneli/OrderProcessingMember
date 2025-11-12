using OrderProcessingMembersBL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IDelivery
    {
        Levering TypeLevering();
    }
}
