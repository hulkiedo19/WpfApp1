using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.Model;
using WpfApp1.ViewModels;

namespace WpfApp1.Commands
{
    public class DeleteDataCommand : Commands
    {
        private DataWindowViewModel _viewModel;

        public DeleteDataCommand(DataWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            if (_viewModel.SelectedEmployee == null)
            {
                return;
            }

            int employeeId = (_viewModel.SelectedEmployee as Employee).Id;

            using (var DbContext = new DatabaseEntities())
            {
                var employee = DbContext.Employees
                    .Where(e => e.Id == employeeId)
                    .Single();

                DbContext.Employees.Remove(employee);
                DbContext.SaveChanges();

                _viewModel.Employees.Remove(employee);
                (parameter as ItemCollection).Refresh();
            }

            UpdateEmployees();
            (parameter as ItemCollection).Refresh();
        }

        private void UpdateEmployees()
        {
            using (var DbContext = new DatabaseEntities())
            {
                _viewModel.Employees = DbContext.Employees
                    .ToList();
            }
        }
    }
}
