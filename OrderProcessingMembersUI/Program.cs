using OrderProcessingMembersBL.Manager;
using OrderProcessingMembersUtils;

namespace OrderProcessingMembersUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            OrderProcessingMembersBeheerder beheerder = new OrderProcessingMembersBeheerder(OrderProcessingMembersFactory.GetLidRepositoryMemory());

            var whatShouldIDo = beheerder.GeefLeden();

            foreach (var item in whatShouldIDo) 
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
