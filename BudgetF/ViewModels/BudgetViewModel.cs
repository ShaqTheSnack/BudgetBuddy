using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetF.ViewModels
{
    internal class BudgetViewModel : ViewModelBase
    {
        public BudgetViewModel() 
        { 
            
        }

        #region ALL BOOLS

        public bool RentTrue
        {
            get => MainWindowViewModel.Instance.TV.RENT;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.RENT, value, nameof(RentTrue));
            }
        }


        public bool UtilitiesTrue
        {
            get => MainWindowViewModel.Instance.TV.UTILITIES;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.UTILITIES, value, nameof(UtilitiesTrue));
            }
        }


        public bool GroceriesTrue
        {
            get => MainWindowViewModel.Instance.TV.GROCERIES;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.GROCERIES, value, nameof(GroceriesTrue));
            }
        }


        public bool TransportationTrue
        {
            get => MainWindowViewModel.Instance.TV.TRANSPORTATION;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.TRANSPORTATION, value, nameof(TransportationTrue));
            }
        }


        public bool InsurancePremiumsTrue
        {
            get => MainWindowViewModel.Instance.TV.INSURANCEPREMIUMS;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.INSURANCEPREMIUMS, value, nameof(InsurancePremiumsTrue));
            }
        }


        public bool MinimumDebtPaymentsTrue
        {
            get => MainWindowViewModel.Instance.TV.MINIMUMDEBTPAYMENTS;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.MINIMUMDEBTPAYMENTS, value, nameof(MinimumDebtPaymentsTrue));
            }
        }


        public bool OtherEssentialExpensesTrue
        {
            get => MainWindowViewModel.Instance.TV.OTHERESSENTIALEXPENSES;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.OTHERESSENTIALEXPENSES, value, nameof(OtherEssentialExpensesTrue));
            }
        }


        public bool RetirementSavingsTrue
        {
            get => MainWindowViewModel.Instance.TV.RETIREMENTSAVINGS;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.RETIREMENTSAVINGS, value, nameof(RetirementSavingsTrue));
            }
        }


        public bool EmergencyFundTrue
        {
            get => MainWindowViewModel.Instance.TV.EMERGENCYFUND;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.EMERGENCYFUND, value, nameof(EmergencyFundTrue));
            }
        }


        public bool HouseDownPaymentTrue
        {
            get => MainWindowViewModel.Instance.TV.HOUSEDOWNPAYMENT;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.HOUSEDOWNPAYMENT, value, nameof(HouseDownPaymentTrue));
            }
        }


        public bool InvestmentsTrue
        {
            get => MainWindowViewModel.Instance.TV.INVESTMENTS;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.INVESTMENTS, value, nameof(InvestmentsTrue));
            }
        }


        public bool ChildrenEducationSavingsTrue
        {
            get => MainWindowViewModel.Instance.TV.CHILDRENEDUCATIONSAVINGS;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.CHILDRENEDUCATIONSAVINGS, value, nameof(ChildrenEducationSavingsTrue));
            }
        }


        public bool DiningOutTrue
        {
            get => MainWindowViewModel.Instance.TV.DININGOUT;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.DININGOUT, value, nameof(DiningOutTrue));
            }
        }

        public bool EntertainmentTrue
        {
            get => MainWindowViewModel.Instance.TV.ENTERTAINMENT;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.ENTERTAINMENT, value, nameof(EntertainmentTrue));
            }
        }

        public bool TravelTrue
        {
            get => MainWindowViewModel.Instance.TV.TRAVEL;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.TRAVEL, value, nameof(TravelTrue));
            }
        }


        public bool HobbiesTrue
        {
            get => MainWindowViewModel.Instance.TV.HOBBIES;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.HOBBIES, value, nameof(HobbiesTrue));
            }
        }

        public bool ShoppingTrue
        {
            get => MainWindowViewModel.Instance.TV.SHOPPING;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.SHOPPING, value, nameof(ShoppingTrue));
            }
        }


        public bool OtherDiscretionaryExpensesTrue
        {
            get => MainWindowViewModel.Instance.TV.OTHERDISCRETIONARYEXPENSES;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.OTHERDISCRETIONARYEXPENSES, value, nameof(OtherDiscretionaryExpensesTrue));
            }
        }

        public bool MaleTrue
        {
            get => MainWindowViewModel.Instance.TV.MALE;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.MALE, value, nameof(MaleTrue));
            }
        }

        public bool FemaleTrue
        {
            get => MainWindowViewModel.Instance.TV.FEMALE;
            set
            {
                this.RaiseAndSetIfChanged(ref MainWindowViewModel.Instance.TV.FEMALE, value, nameof(FemaleTrue));
            }
        }
        #endregion

        public void ViewBudget()
        {
            MainWindowViewModel.Instance.SetViewModel(new ViewBudgetViewModel());
        }

        public void BackBTN()
        {
            MainWindowViewModel.Instance.SetViewModel(new HomePageViewModel());
        }
    }
}
