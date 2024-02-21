using ReactiveUI;

namespace BudgetF.ViewModels
{
    internal class CreateUserViewModel : ViewModelBase
    {
        public CreateUserViewModel()
        {

        }

        #region NEW USER INFO STRINGS
        private string _firstname;
        public string Firstname
        {
            get => _firstname;
            set
            {
                this.RaiseAndSetIfChanged(ref _firstname, value, nameof(Firstname));
            }
        }

        private string _lastname;
        public string Lastname
        {
            get => _lastname;
            set
            {
                this.RaiseAndSetIfChanged(ref _lastname, value, nameof(Lastname));
            }
        }

        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                this.RaiseAndSetIfChanged(ref _username, value, nameof(Username));
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                this.RaiseAndSetIfChanged(ref _password, value, nameof(Password));
            }
        }

        private string _error;
        public string Error
        {
            get => _error;
            set
            {
                this.RaiseAndSetIfChanged(ref _error, value, nameof(Error));
            }
        }

        #endregion

        public void CreateMyUser()
        {
            if(Database.Instance.CreateUser(Firstname, Lastname, Username, Password))
            {
                MainWindowViewModel.Instance.SetViewModel(new LoginViewModel());
            }
            else
            {
                Error = "Username Is Invalid or Already Taken [Username]";
            }

        }

        public void BackBTN()
        {
            MainWindowViewModel.Instance.SetViewModel(new LoginViewModel());
        }
    }
}
