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
using OrderProcessingMembersBL.Manager;
using OrderProcessingMembersBL.Models;
using OrderProcessingMembersBL.Models.Status;

namespace OrderProcessingMembersUI_2
{
    /// <summary>
    /// Interaction logic for EventOrderWindow.xaml
    /// </summary>
    public partial class EventOrderWindow : Window
    {
        private Member _member;
        private OrderProcessingMembersBeheerder _manager;

        public EventOrderWindow(Member member, OrderProcessingMembersBeheerder manager)
        {
            InitializeComponent();

            _manager = manager;
            _member = member;

            List<Event> events = manager.GetEventList();
            ComboBox_EventList.ItemsSource = events;

        }

        private void ButtonClick_Order(object sender, RoutedEventArgs e)
        {
            Event ev = (Event)ComboBox_EventList.SelectedItem;
            try
            {
                int amountOfticks = int.Parse(TextBox_TicketAmount.Text);
               _manager.GetOrder(_member, ev, amountOfticks);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
