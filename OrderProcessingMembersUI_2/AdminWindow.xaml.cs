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
    
    public partial class AdminWindow : Window
    {

        private OrderProcessingMembersBeheerder _manager;
        List<StandardOrder> listAdmin;
      
        public AdminWindow(OrderProcessingMembersBeheerder manager)
        {
            InitializeComponent();

            _manager = manager;
            listAdmin = new List<StandardOrder>(manager.GetOrders());



            var x = listAdmin.Select(order => new
            {
                Eventname = order.Event.Name,
                EventAdress = order.Event.Address,
                MemberName = order.Member.Name,
                MemberAdress = order.Member.Address,
                Benefits = (order.Benefits == null) ? null : string.Join(", ", order.Benefits)

            })
                .Where(x => x.Benefits != null);


            DataGrid_Benefits.ItemsSource = x;

        }
    }
}
