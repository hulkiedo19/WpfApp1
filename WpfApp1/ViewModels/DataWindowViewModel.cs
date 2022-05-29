using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Model;

namespace WpfApp1.ViewModels
{
    public class DataWindowViewModel : ViewModel
    {
        private List<Employee> employees;
        private object selectedEmployee;

        public ICommand DeleteData => new DeleteDataCommand(this);
        public ICommand UpdateData => new UpdateDataCommand(this);
        public ICommand Otchet => new OtchetCommand(this);

        public DataWindowViewModel()
        {
            using (var DbContext = new DatabaseEntities())
            {
                employees = DbContext.Employees
                    .ToList();
            }
        }

        public List<Employee> Employees
        {
            get => employees;
            set => Set(ref employees, value, nameof(Employees));
        }

        public object SelectedEmployee
        {
            get => selectedEmployee;
            set => Set(ref selectedEmployee, value, nameof(SelectedEmployee));
        }
    }
}
