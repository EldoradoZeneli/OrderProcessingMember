using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OrderProcessingMembersBL.Enums;
using OrderProcessingMembersBL.Manager;
using OrderProcessingMembersBL.Models;
using OrderProcessingMembersBL.Models.Calculators;
using OrderProcessingMembersBL.Models.Deliveries;
using OrderProcessingMembersBL.Models.Status;

namespace OrderProcessingMembersUI_2
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {

        private OrderProcessingMembersBeheerder _manager;
        Dictionary<Event, List<StandardOrder>> dictBenefits;
        // List<StandardOrder> orders = new List<StandardOrder>();

        public AdminWindow(OrderProcessingMembersBeheerder manager)
        {
            InitializeComponent();

            _manager = manager;
            dictBenefits = new Dictionary<Event, List<StandardOrder>>(manager.GetOrdersByEvent());


            //Address address = new Address("Werchter", "Straat", "25", 2000);
            //Address address1 = new Address("Gent", "Straat", "12", 9000);
            //Event ev = new Event("Rock Werchter", new DateTime(26, 07, 14), 140.50, address);
            //Member member = new Member("Lucas", "Email", EStatus.Gold, address1);
            //List<string> benefits = new List<string>() { "nametag", "taxi", "dinner"};


            //StandardOrder order = new GoldOrder(ev, member, 5, new ExpressDelivery(), new GoldCalculator());
            //orders.Add(order);

            //dictBenefits.Add(ev, orders);

            //TODO redirect to 'a that will project the string (example: stringname), ... in to the listbox.
            foreach (var orderList in dictBenefits.Values)
            {
                foreach (var order in orderList)
                {
                    order.AddBenefitToList(); 
                }
            }


            var x = dictBenefits.SelectMany(x => x.Value).Select(x => new
            {
                Eventname = x.Event.Name,
                EventAdress = x.Event.Address,
                MemberName = x.Member.Name,
                MemberAdress = x.Member.Address,
                Benefits = (x.Benefits == null)? null : string.Join(", ", x.Benefits)             
            });
           
                
            

            DataGrid_Benefits.ItemsSource = x;

        }
    }
}
