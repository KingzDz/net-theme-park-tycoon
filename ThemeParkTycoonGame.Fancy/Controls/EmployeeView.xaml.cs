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

        public EmployeeView()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            string role = "Performer";
            Employee NewEmployee = new Employee(role);
            NewEmployee.Boost.StatType = StatTypes.GetByUniqueId("excitement");

            Employees.Add(NewEmployee);
        }

        private void FireButton_Click(object sender, RoutedEventArgs e)
        {
            Employees.RemoveAt(employeeListView.SelectedIndex);
            
        }

    }
}
