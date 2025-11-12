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

        Dictionary<Event, List<StandardOrder>> benefits = new Dictionary<Event, List<StandardOrder>>();
        List<StandardOrder> orders = new List<StandardOrder>();

        public AdminWindow()
        {
            InitializeComponent();

            Address address = new Address("Werchter", "Straat", "25", 2000);
            Address address1 = new Address("Gent", "Straat", "12", 9000);
            Event ev = new Event("Rock Werchter", new DateTime(26, 07, 14), 140.50, address);
            Member member = new Member("Lucas", "Email", EStatus.Gold, address1);
            List<string> benefits = new List<string>() { "nametag", "taxi", "dinner"};
            

            StandardOrder order = new GoldOrder(ev, member, 5, new ExpressDelivery(), new GoldCalculator());
            orders.Add(order);

            benefits.Add(ev, orders);




            var x = benefits.SelectMany(x => x.Value).Select(x => new
            {
                Eventname = x.Event.Name,
                EventAdress = x.Event.Address,
                MemberName = x.Member.Name,
                MemberAdress = x.Member.Address,
                Benefits = string.Join(',', x.Benefits)
            });
           
                
            

            DataGrid_Benefits.ItemsSource = x;

        }
    }
}
