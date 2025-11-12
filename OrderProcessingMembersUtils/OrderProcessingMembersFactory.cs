using OrderProcessingMemberDL_File;
using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersUtils
{
    public static class OrderProcessingMembersFactory
    {
        public static IOrderManagerRepository GetLidRepositoryMemory() 
        {
            return new LidRepositoryMemory();
        }
    }
}
