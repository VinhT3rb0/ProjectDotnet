using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.Model;
using WpfApp2.Repositories;

namespace WpfApp2.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private string _userName;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible=true;

        private IUserRepository userRepository;

        public string UserName { 
            get
            {
                return _userName;
            }
            set {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public SecureString Password {
            get { return _password; }
            set {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ErrorMessage { 
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public bool IsViewVisible {
            get { return _isViewVisible; }
            set { 
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberRecoverCommand { get; }

        public LoginViewModel()
        {
            userRepository = new UserRepository();
            LoginCommand = new ViewModelCommand(ExcuteLoginCommand, CanExcuteLoginCommand);
            RecoverPasswordCommand = new ViewModelCommand(p => ExcuteRecoverPassCommand("", ""));
        }

        private void ExcuteRecoverPassCommand(string username, string email)
        {
            throw new NotImplementedException();
        }

        private bool CanExcuteLoginCommand(object obj)
        {
            bool validData;
            if(string.IsNullOrWhiteSpace(UserName) || UserName.Length<3 || Password==null
                 || Password.Length<3)
                validData = false;
            else
                validData = true;
            return validData;
        }

        private void ExcuteLoginCommand(object obj)
        {
            var isValidUser = userRepository.AuthenticateUser(new NetworkCredential(UserName, Password));
            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(UserName),null);
                IsViewVisible = false;
            }
            else
            {
                ErrorMessage = "* Sai tài khoản hoặc mật khẩu";
            }
        }
    }
}
