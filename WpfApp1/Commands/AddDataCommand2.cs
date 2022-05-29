using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.ViewModels;

namespace WpfApp1.Commands
{
    public class AddDataCommand2 : Commands
    {
        private AddWindowViewModel _viewModel;

        public AddDataCommand2(AddWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            Employee employee = CreateEmployee();

            using (var DbContext = new DatabaseEntities())
            {
                DbContext.Employees.Add(employee);
                DbContext.SaveChanges();
            }
        }

        private Employee CreateEmployee()
        {
            Employee employee = new Employee()
            {
                FirstName = _viewModel.FirstName,
                LastName = _viewModel.LastName,
                MiddleName = _viewModel.MiddleName,
                DateOfBirth = Convert.ToDateTime(_viewModel.DateOfBirth),
                Phone = _viewModel.Phone,
                Mail = _viewModel.Mail,
                Adress = _viewModel.Adress,
                WorkExp = Convert.ToInt32(_viewModel.WorkExp),
                Passport = _viewModel.Passport,
                INN = _viewModel.INN
            };

            return employee;
        }
    }
}
