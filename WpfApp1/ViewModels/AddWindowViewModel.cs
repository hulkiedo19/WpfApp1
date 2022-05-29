using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;

namespace WpfApp1.ViewModels
{
    public class AddWindowViewModel : ViewModel
    {
        private string _firstName;
        private string _lastName;
        private string _middleName;
        private object _dateOfBirth;
        private string _phone;
        private string _mail;
        private string _adress;
        private string _workExp;
        private string _passport;
        private string _inn;

        public ICommand AddDataCommand => new AddDataCommand2(this);

        public AddWindowViewModel()
        {
        }

        public string FirstName
        {
            get => _firstName;
            set => Set(ref _firstName, value, nameof(FirstName));
        }

        public string LastName
        {
            get => _lastName;
            set => Set(ref _lastName, value, nameof(LastName));
        }

        public string MiddleName
        {
            get => _middleName;
            set => Set(ref _middleName, value, nameof(MiddleName));
        }

        public object DateOfBirth
        {
            get => _dateOfBirth;
            set => Set(ref _dateOfBirth, value, nameof(DateOfBirth));
        }

        public string Phone
        {
            get => _phone;
            set => Set(ref _phone, value, nameof(Phone));
        }

        public string Mail
        {
            get => _mail;
            set => Set(ref _mail, value, nameof(Mail));
        }

        public string Adress
        {
            get => _adress;
            set => Set(ref _adress, value, nameof(Adress));
        }

        public string WorkExp
        {
            get => _workExp;
            set => Set(ref _workExp, value, nameof(WorkExp));
        }

        public string Passport
        {
            get => _passport;
            set => Set(ref _passport, value, nameof(Passport));
        }

        public string INN
        {
            get => _inn;
            set => Set(ref _inn, value, nameof(INN));
        }
    }
}
