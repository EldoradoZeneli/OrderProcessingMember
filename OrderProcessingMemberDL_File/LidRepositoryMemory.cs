using OrderProcessingMembersBL.Interfaces;
using OrderProcessingMembersBL.Models;
using OrderProcessingMembersBL.Models.Status;

namespace OrderProcessingMemberDL_File
{
    public class LidRepositoryMemory : IOrderManagerRepository
    {

        private Dictionary<int, Lid> leden;
        private int lidID = 1;

        public LidRepositoryMemory()
        {

            leden = new();

            // This is mock data, only used to simulate the application
            var adres = new Adres("x", "x", "x", "x", "x");

            leden.Add(lidID, new Lid(lidID, "Gebruiker1", "mail1@outlook.com", adres, new StandardOrder()));
            lidID++;

            leden.Add(lidID, new Lid(lidID, "Gebruiker2", "mail2@outlook.com", adres, new BronzeOrder()));
            lidID++;

            leden.Add(lidID, new Lid(lidID, "Gebruiker3", "mail3@outlook.com", adres, new SilverOrder()));
            lidID++;

            leden.Add(lidID, new Lid(lidID, "Gebruiker4", "mail4@outlook.com", adres, new GoldOrder()));
            lidID++;
        }

        public List<Lid> GeefLeden()
        {
            return leden.Values.ToList();
        }

    }
}
