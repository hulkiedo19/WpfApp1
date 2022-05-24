using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public class LoginWindowViewModel : ViewModel
    {
        private string _username;
        private string _password;

        //public ICommand LoginCommand => new Login(this);
        //public ICommand RegistrationCommand => new RegistrationOpen();

        public string Username
        {
            get => _username;
            set => Set(ref _username, value, nameof(Username));
        }

        public string Password
        {
            get => _password;
            set => Set(ref _password, value, nameof(Password));
        }
    }
}
