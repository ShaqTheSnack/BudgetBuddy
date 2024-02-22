﻿using BudgetF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using Avalonia.Controls.Templates;

namespace BudgetF.ViewModels
{
    public class MyIncomeViewModel : ViewModelBase
    {
        public MyIncomeViewModel()
        {

        }



        
        private double _personalIncome;
        public double PersonalIncome
        {
            get => _personalIncome;
            set
            {
                this.RaiseAndSetIfChanged(ref _personalIncome, value, nameof(PersonalIncome));
            }
        }



        public void BackButton()
        {
            MainWindowViewModel.Instance.SetViewModel(new HomePageViewModel());
        }
    }
}
