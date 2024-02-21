using BudgetF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using System.Diagnostics;
using DynamicData.Kernel;

namespace BudgetF.ViewModels
{
    internal class HomePageViewModel : ViewModelBase
    {
        public HomePageViewModel()
        {

        }


        public void MyIncome()
        {
            MainWindowViewModel.Instance.SetViewModel(new MyIncomeViewModel());
        }


        public void BillsBTN()
        {
            MainWindowViewModel.Instance.SetViewModel(new BillsViewModel());
        }


        public void BudgetBTN()
        {
            MainWindowViewModel.Instance.SetViewModel(new BudgetViewModel());
        }

        #region PRØV
        /*
        public void BudgetBTN()
        {
            kkk();
        }

        private double _sernameInput;
        public double sernameInput
        {
            get => _sernameInput;
            set
            {
                this.RaiseAndSetIfChanged(ref _sernameInput, value, nameof(sernameInput));
            }
        }

        public void kkk()
        {
            sernameInput = MainWindowViewModel.Instance.Parent.EssentialExpenses.Groceries;
            Debug.WriteLine(sernameInput);
        }
        */
        #endregion
    }

}
