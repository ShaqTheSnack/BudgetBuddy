using BudgetF.Models;
using Newtonsoft.Json;
using ReactiveUI;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;


namespace BudgetF.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public static MainWindowViewModel Instance { get; private set; }
        private ViewModelBase _contentViewModel;
        public UserInfoModel UserInfo = new UserInfoModel();
        public TheValues TV = new TheValues();


        public ViewModelBase ContentViewModel
        {
            get => _contentViewModel;
            private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
        }

        public void SetViewModel(ViewModelBase model)
        {
            ContentViewModel = model;
        }

        public JsonParent Parent;
        public MainWindowViewModel()
        {
            if(Instance == null)
            {
                Instance = this;
            }
            _contentViewModel = new LoginViewModel();

            string JsonText = File.ReadAllText("Scripts\\JSON.json");
            Parent = JsonConvert.DeserializeObject<JsonParent>(JsonText);
        }
    }
}

