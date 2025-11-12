using OrderProcessingMembersBL.Interfaces;
using OrderProcessingMembersBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Manager
{
    public class OrderProcessingMembersBeheerder
    {
        private IOrderManagerRepository _repo;
        public OrderProcessingMembersBeheerder(IOrderManagerRepository repo)
        {
            _repo = repo;
        }

        // TODO |!| Group an order with a member

        public List<Lid> GeefLeden()
        {
            return _repo.GeefLeden();
        }
    }
}
