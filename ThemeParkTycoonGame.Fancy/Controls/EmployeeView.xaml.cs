using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : UserControl
    {
        private GuestList guests;
        public GuestList Guests
        {
            get
            {
                return guests;
            }
            set
            {
                guests = value;
            }
        }

        private ObservableCollection<Employee> employees;
        public ObservableCollection<Employee> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                employees = value;
            }
        }

        GridView grid;

        public EmployeeView()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            Employee NewEmployee = new Employee();
            NewEmployee.Function = "Performer";
            NewEmployee.Boost.StatType = StatTypes.GetByUniqueId("excitement");

            Employees.Add(NewEmployee);
            //employeeListView.Items.Add(NewEmployee);
        }

        private void FireButton_Click(object sender, RoutedEventArgs e)
        {
            string employeeName = (string)employeeListView.Items[employeeListView.SelectedIndex];

        }

    }
}
