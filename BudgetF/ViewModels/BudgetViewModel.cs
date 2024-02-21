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
        private bool _RentTrue;
        public bool RentTrue
        {
            get => _RentTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _RentTrue, value, nameof(RentTrue));
            }
        }

        private bool _UtilitiesTrue;
        public bool UtilitiesTrue
        {
            get => _UtilitiesTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _UtilitiesTrue, value, nameof(UtilitiesTrue));
            }
        }

        private bool _GroceriesTrue;
        public bool GroceriesTrue
        {
            get => _GroceriesTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _GroceriesTrue, value, nameof(GroceriesTrue));
            }
        }

        private bool _TransportationTrue;
        public bool TransportationTrue
        {
            get => _TransportationTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _TransportationTrue, value, nameof(TransportationTrue));
            }
        }

        private bool _InsurancePremiumsTrue;
        public bool InsurancePremiumsTrue
        {
            get => _InsurancePremiumsTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _InsurancePremiumsTrue, value, nameof(InsurancePremiumsTrue));
            }
        }

        private bool _MinimumDebtPaymentsTrue;
        public bool MinimumDebtPaymentsTrue
        {
            get => _MinimumDebtPaymentsTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _MinimumDebtPaymentsTrue, value, nameof(MinimumDebtPaymentsTrue));
            }
        }

        private bool _OtherEssentialExpensesTrue;
        public bool OtherEssentialExpensesTrue
        {
            get => _OtherEssentialExpensesTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _OtherEssentialExpensesTrue, value, nameof(OtherEssentialExpensesTrue));
            }
        }

        private bool _RetirementSavingsTrue;
        public bool RetirementSavingsTrue
        {
            get => _RetirementSavingsTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _RetirementSavingsTrue, value, nameof(RetirementSavingsTrue));
            }
        }

        private bool _EmergencyFundTrue;
        public bool EmergencyFundTrue
        {
            get => _EmergencyFundTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _EmergencyFundTrue, value, nameof(EmergencyFundTrue));
            }
        }

        private bool _HouseDownPaymentTrue;
        public bool HouseDownPaymentTrue
        {
            get => _HouseDownPaymentTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _HouseDownPaymentTrue, value, nameof(HouseDownPaymentTrue));
            }
        }

        private bool _InvestmentsTrue;
        public bool InvestmentsTrue
        {
            get => _InvestmentsTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _InvestmentsTrue, value, nameof(InvestmentsTrue));
            }
        }

        private bool _ChildrenEducationSavingsTrue;
        public bool ChildrenEducationSavingsTrue
        {
            get => _ChildrenEducationSavingsTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _ChildrenEducationSavingsTrue, value, nameof(ChildrenEducationSavingsTrue));
            }
        }

        private bool _DiningOutTrue;
        public bool DiningOutTrue
        {
            get => _DiningOutTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _DiningOutTrue, value, nameof(DiningOutTrue));
            }
        }

        private bool _EntertainmentTrue;
        public bool EntertainmentTrue
        {
            get => _EntertainmentTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _EntertainmentTrue, value, nameof(EntertainmentTrue));
            }
        }

        private bool _TravelTrue;
        public bool TravelTrue
        {
            get => _TravelTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _TravelTrue, value, nameof(TravelTrue));
            }
        }

        private bool _HobbiesTrue;
        public bool HobbiesTrue
        {
            get => _HobbiesTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _HobbiesTrue, value, nameof(HobbiesTrue));
            }
        }

        private bool _ShoppingTrue;
        public bool ShoppingTrue
        {
            get => _ShoppingTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _ShoppingTrue, value, nameof(ShoppingTrue));
            }
        }

        private bool _OtherDiscretionaryExpensesTrue;
        public bool OtherDiscretionaryExpensesTrue
        {
            get => _OtherDiscretionaryExpensesTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _OtherDiscretionaryExpensesTrue, value, nameof(OtherDiscretionaryExpensesTrue));
            }
        }

        private bool _MaleTrue;
        public bool MaleTrue
        {
            get => _MaleTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _MaleTrue, value, nameof(MaleTrue));
            }
        }

        private bool _FemaleTrue;
        public bool FemaleTrue
        {
            get => _FemaleTrue;
            set
            {
                this.RaiseAndSetIfChanged(ref _FemaleTrue, value, nameof(FemaleTrue));
            }
        }
        #endregion

        #region All CheckedORNot
        public void CheckOrNot()
        {

            MainWindowViewModel.Instance.TV.RENT = RentTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.UTILITIES = UtilitiesTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.GROCERIES = GroceriesTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.TRANSPORTATION = TransportationTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.INSURANCEPREMIUMS = InsurancePremiumsTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.MINIMUMDEBTPAYMENTS = MinimumDebtPaymentsTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.OTHERESSENTIALEXPENSES = OtherEssentialExpensesTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.RETIREMENTSAVINGS = RetirementSavingsTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.EMERGENCYFUND = EmergencyFundTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.HOUSEDOWNPAYMENT = HouseDownPaymentTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.INVESTMENTS = InvestmentsTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.CHILDRENEDUCATIONSAVINGS = ChildrenEducationSavingsTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.DININGOUT = DiningOutTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.ENTERTAINMENT = EntertainmentTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.TRAVEL = TravelTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.HOBBIES = HobbiesTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.SHOPPING = ShoppingTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.OTHERDISCRETIONARYEXPENSES = OtherDiscretionaryExpensesTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.MALE = MaleTrue ? "1" : "0";
            MainWindowViewModel.Instance.TV.FEMALE = FemaleTrue ? "1" : "0";
        }
        #endregion









        public void ViewBudget()
        {
            CheckOrNot();
            MainWindowViewModel.Instance.SetViewModel(new ViewBudgetViewModel());
        }
    }
}
