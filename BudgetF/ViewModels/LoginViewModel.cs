using ReactiveUI;

namespace BudgetF.ViewModels
{
    internal class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {

        }

        #region Validation Strings
        private string _UsernameInput;
        public string UsernameInput
        {
            get => _UsernameInput;
            set
            {
                this.RaiseAndSetIfChanged(ref _UsernameInput, value, nameof(UsernameInput));
            }
        }

        private string _PasswordInput;
        public string PasswordInput
        {
            get => _PasswordInput;
            set
            {
                this.RaiseAndSetIfChanged(ref _PasswordInput, value, nameof(PasswordInput));
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
        #region Validate login
        public void LoginBTN()
        {
            if (Database.Instance.Login(UsernameInput, PasswordInput))
            {
                MainWindowViewModel.Instance.UserInfo.Username = UsernameInput;
                MainWindowViewModel.Instance.SetViewModel(new HomePageViewModel());
            }
            else
            {
                Error = "Invalid [Username] or [Password]";
            }
        }
        #endregion
        #region Create user
        public void CreateUserBtn()
        {
            MainWindowViewModel.Instance.SetViewModel(new CreateUserViewModel());
        }
        #endregion

    }
}
