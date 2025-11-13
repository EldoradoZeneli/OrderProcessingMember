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
using OrderProcessingMembersUI_2;
using OrderProcessingMembersUtils;

namespace MainOrderProcessing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OrderProcessingMembersBeheerder _manager = new OrderProcessingMembersBeheerder(OrderProcessingMembersFactory.GetLidRepositoryMemory());
        public MainWindow()
        {
            InitializeComponent();              
        }

        private void Click_LoginMember(object sender, RoutedEventArgs e)
        {
            string email = TextBox_Email.Text;


            Member memberLo = _manager.GetMemberByEmail(email);

            EventOrderWindow w = new EventOrderWindow(memberLo, _manager);


            // TODO < |EDIT, LC|
            // When an invalid email has been entered, do nothing
            // The null value is being passed through the else section from the GetMemberByEmail method in the LidRepositoryMemory.cs file
            if (memberLo == null)
            {
                return;
            }


            if (RadioButton_Admin.IsChecked == true)
            {
                //TODO add window admin with list of orders and their benefits
                AdminWindow adminw = new AdminWindow(_manager);
                adminw.ShowDialog();
            }
            else
            {
                w.ShowDialog();
            }


        }
    }
}