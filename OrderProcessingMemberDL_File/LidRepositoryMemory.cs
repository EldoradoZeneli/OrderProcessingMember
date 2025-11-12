using OrderProcessingMembersBL.Enums;
using OrderProcessingMembersBL.Interfaces;
using OrderProcessingMembersBL.Models;
using OrderProcessingMembersBL.Models.Status;

namespace OrderProcessingMemberDL_File
{
    public class LidRepositoryMemory : IOrderManagerRepository
    {

        private Dictionary<int, Member> leden;
        private int lidID = 1;

        public LidRepositoryMemory()
        {

            leden = new();

            Member member = new Member("Lucas", "lucas@school.be", EStatus.Gold, new Address("x", "x", "x", 1));
            Member member2 = new Member("Eldorado", "eldorado@school.be", EStatus.Gold, new Address("x", "x", "x", 1));
            Member member3 = new Member("Qwertygebruiker", "qwerty@school.be", EStatus.Gold, new Address("x", "x", "x", 1));
            Member member4 = new Member("Kelly", "Kelly@school.be", EStatus.Gold, new Address("x", "x", "x", 1));
            Member member5 = new Member("x", "x@school.be", EStatus.Gold, new Address("x", "x", "x", 1));
        }

        public List<Member> GeefLeden()
        {
            return leden.Values.ToList();
        }

        public List<Event> GetEventList()
        {
            return null;
        }

        public Member GetMemberByEmail(string email)
        {
            return null;
        }
    }
}
