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

<<<<<<< HEAD
        public List<Member> GeefLeden()
=======
        // TODO |!| Group an order with a member

        public List<Lid> GeefLeden()
>>>>>>> c72e159f33774426b8aac4226db2c474323a102d
        {
            return _repo.GeefLeden();
        }
    }
}
