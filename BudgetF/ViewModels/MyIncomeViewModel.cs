using BudgetF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using Avalonia.Controls.Templates;

namespace BudgetF.ViewModels
{
    internal class MyIncomeViewModel : ViewModelBase
    {
        public MyIncomeViewModel()
        {
        }


        public void BackButton()
        {
            MainWindowViewModel.Instance.SetViewModel(new HomePageViewModel());
        }
    }
}
