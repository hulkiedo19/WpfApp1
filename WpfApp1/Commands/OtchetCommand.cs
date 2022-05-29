using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.ViewModels;
using Microsoft.VisualBasic;
using WpfApp1.Model;

namespace WpfApp1.Commands
{
    public class OtchetCommand : Commands
    {
        private DataWindowViewModel _viewModel;

        public OtchetCommand(DataWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            string EmployeeName = Interaction.InputBox("type employee last name");

            using(var DbContext = new DatabaseEntities())
            {
                var Employee = DbContext.Employees
                    .Where(e => e.LastName == EmployeeName)
                    .SingleOrDefault();

                if(Employee == default)
                {
                    MessageBox.Show($"employee with this {EmployeeName} name does not exists");
                    return;
                }

                if(Employee.BusinessTrips.Count == 0)
                {
                    MessageBox.Show("Employee does not have business trips");
                    return;
                }

                var BusinessTrip = Employee.BusinessTrips.First();

                MessageBox.Show($"EmployeeId = {BusinessTrip.EmployeeId}, Budget = {BusinessTrip.Budget}, Destination = {BusinessTrip.Destination}, Purpose = {BusinessTrip.Purpose}, PeriodStart = {BusinessTrip.PeriodStart}, PeriodEnd = {BusinessTrip.PeriodEnd}");
            }
        }
    }
}
