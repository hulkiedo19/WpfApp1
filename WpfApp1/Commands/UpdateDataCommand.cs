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
    public class UpdateDataCommand : Commands
    {
        private DataWindowViewModel _viewModel;

        public UpdateDataCommand(DataWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
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
