using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public class RegistrationWindowViewModel : ViewModel
    {
        private string _username;
        private string _passwordFirst;
        private string _passwordSecond;

        //public ICommand BackToLogin => new BackToLogin();

        public string Username
        {
            get => _username;
            set => Set(ref _username, value, nameof(Username));
        }

        public string PasswordFirst
        {
            get => _passwordFirst;
            set => Set(ref _passwordSecond, value, nameof(PasswordFirst));
        }

        public string PasswordSecond
        {
            get => _passwordSecond;
            set => Set(ref _passwordSecond, value, nameof(PasswordSecond));
        }
    }
}
