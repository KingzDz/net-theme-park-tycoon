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
using System.Windows.Shapes;
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for EmployeeApplicationsWindow.xaml
    /// </summary>
    public partial class EmployeeApplicationsWindow : Window
    {
        public ObservableCollection<Employee> HireableEmployees { get; set; }
        public Employee HiredEmployee;
        public bool IsHired;

        Random rng;

        public EmployeeApplicationsWindow()
        {
            InitializeComponent();

            rng = new Random();
            HireableEmployees = new ObservableCollection<Employee>();

            for (int i = 0; i < rng.Next(5, 15); i++)
            {
                Employee employee = new Employee("Performer");

                HireableEmployees.Add(employee);
                Console.WriteLine(employee.Name);
            }

            this.DataContext = this;
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HiredEmployee = HireableEmployees[employeeListView.SelectedIndex];
                HireableEmployees.RemoveAt(employeeListView.SelectedIndex);
                IsHired = true;

                MessageBox.Show(HiredEmployee.Name + "has been hired!");
                this.Visibility = Visibility.Hidden;
            }
            catch
            {
                MessageBox.Show("Kies eerst de werknemer die je wilt aannemen!");
            }
            
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
