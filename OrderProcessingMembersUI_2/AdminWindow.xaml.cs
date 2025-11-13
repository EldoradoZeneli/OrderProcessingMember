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
        List<StandardOrder> dictBenefits;
        // List<StandardOrder> orders = new List<StandardOrder>();

        public AdminWindow(OrderProcessingMembersBeheerder manager)
        {
            InitializeComponent();

            _manager = manager;
            dictBenefits = new List<StandardOrder>(manager.GetOrders());

            


            //business logica moet niet hier toegepast worden!           
            //foreach (var orderList in dictBenefits)
            //{
            //    foreach (var order in orderList)
            //    {
            //        order.AddBenefitToList(); 
            //    }
            //}


            var x = dictBenefits.Select(order => new
            {
                Eventname = order.Event.Name,
                EventAdress = order.Event.Address,
                MemberName = order.Member.Name,
                MemberAdress = order.Member.Address,
                Benefits = (order.Benefits == null) ? null : string.Join(", ", order.Benefits)

            })
                .Where(x => x.Benefits != null);

            //var x = dictBenefits.SelectMany(x => x.Value).Select(x => new
            //{
            //    Eventname = x.Event.Name,
            //    EventAdress = x.Event.Address,
            //    MemberName = x.Member.Name,
            //    MemberAdress = x.Member.Address,
            //    Benefits = (x.Benefits == null)? null : string.Join(", ", x.Benefits[0])             
            //});
           
                
            

            DataGrid_Benefits.ItemsSource = x;

        }
    }
}
