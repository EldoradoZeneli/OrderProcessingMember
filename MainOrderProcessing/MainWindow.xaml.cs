using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OrderProcessingMembersBL.Enums;
using OrderProcessingMembersBL.Manager;
using OrderProcessingMembersBL.Models;

namespace MainOrderProcessing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OrderProcessingMembersBeheerder _manager;
        public MainWindow(OrderProcessingMembersBeheerder manager)
        {
            InitializeComponent();  
            _manager = manager;
        }

        private void Click_LoginMember(object sender, RoutedEventArgs e)
        {
            string email = TextBox_Email.Text;
            Member memberLo = _manager.GetMemberByEmail(email);
        }
    }
}