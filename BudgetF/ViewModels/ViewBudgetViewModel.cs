using DynamicData.Aggregation;
using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetF.ViewModels
{
    internal class ViewBudgetViewModel : ViewModelBase
    {
        public string ONE = "1";
        public ViewBudgetViewModel()
        {
            EXECUTEALL();
            AllSalery();
        }


        #region Double values
        double RENTVALUE;
        double UTILITIESVALUE;
        double GROCERIESVALUE;
        double TRANSPORTATIONVALUE;
        double INSURANCEPREMIUMSVALUE;
        double MINIMUMDEBTPAYMENTSVALUE;
        double OTHERESSENTIALEXPENSESVALUE;
        double RETIREMENTSAVINGSVALUE;
        double EMERGENCYFUNDVALUE;
        double HOUSEDOWNPAYMENTVALUE;
        double INVESTMENTSVALUE;
        double CHILDRENEDUCATIONSAVINGSVALUE;
        double DININGOUTVALUE;
        double ENTERTAINMENTVALUE;
        double TRAVELVALUE;
        double HOBBIESVALUE;
        double SHOPPINGVALUE;
        double OTHERDISCRETIONARYEXPENSESVALUE;
        #endregion

        #region ExecuteALL Bools
        public void EXECUTEALL()
        {
            if (MainWindowViewModel.Instance.TV.RENT)
            {
                 RENTVALUE = MainWindowViewModel.Instance.Parent.EssentialExpenses.RentOrMortgage;
            }

            if (MainWindowViewModel.Instance.TV.UTILITIES)
            {
                 UTILITIESVALUE = MainWindowViewModel.Instance.Parent.EssentialExpenses.Utilities;
            }

            if (MainWindowViewModel.Instance.TV.GROCERIES)
            {
                 GROCERIESVALUE = MainWindowViewModel.Instance.Parent.EssentialExpenses.Groceries;
            }

            if (MainWindowViewModel.Instance.TV.TRANSPORTATION)
            {
                 TRANSPORTATIONVALUE = MainWindowViewModel.Instance.Parent.EssentialExpenses.Transportation;
            }

            if (MainWindowViewModel.Instance.TV.INSURANCEPREMIUMS)
            {
                 INSURANCEPREMIUMSVALUE = MainWindowViewModel.Instance.Parent.EssentialExpenses.InsurancePremiums;
            }

            if (MainWindowViewModel.Instance.TV.MINIMUMDEBTPAYMENTS)
            {
                 MINIMUMDEBTPAYMENTSVALUE = MainWindowViewModel.Instance.Parent.EssentialExpenses.MinimumDebtPayments;
            }


            if (MainWindowViewModel.Instance.TV.EMERGENCYFUND)
            {
                EMERGENCYFUNDVALUE = MainWindowViewModel.Instance.Parent.FinancialGoals.EmergencyFund;
            }


            if (MainWindowViewModel.Instance.TV.OTHERESSENTIALEXPENSES)
            {
                 OTHERESSENTIALEXPENSESVALUE = MainWindowViewModel.Instance.Parent.EssentialExpenses.OtherEssentialExpenses;
            }

            if (MainWindowViewModel.Instance.TV.RETIREMENTSAVINGS)
            {
                 UTILITIESVALUE = MainWindowViewModel.Instance.Parent.FinancialGoals.RetirementSavings;
            }

            if (MainWindowViewModel.Instance.TV.EMERGENCYFUND)
            {
                 RETIREMENTSAVINGSVALUE = MainWindowViewModel.Instance.Parent.FinancialGoals.RetirementSavings;
            }

            if (MainWindowViewModel.Instance.TV.HOUSEDOWNPAYMENT)
            {
                 HOUSEDOWNPAYMENTVALUE = MainWindowViewModel.Instance.Parent.FinancialGoals.HouseDownPayment;
            }

            if (MainWindowViewModel.Instance.TV.INVESTMENTS)
            {
                 INVESTMENTSVALUE = MainWindowViewModel.Instance.Parent.FinancialGoals.Investments;
            }

            if (MainWindowViewModel.Instance.TV.CHILDRENEDUCATIONSAVINGS)
            {
                 CHILDRENEDUCATIONSAVINGSVALUE = MainWindowViewModel.Instance.Parent.FinancialGoals.ChildrenEducationSavings;
            }

            if (MainWindowViewModel.Instance.TV.DININGOUT)
            {
                 DININGOUTVALUE = MainWindowViewModel.Instance.Parent.DiscretionarySpending.DiningOut;
            }

            if (MainWindowViewModel.Instance.TV.ENTERTAINMENT)
            {
                 ENTERTAINMENTVALUE = MainWindowViewModel.Instance.Parent.DiscretionarySpending.Entertainment;
            }

            if (MainWindowViewModel.Instance.TV.TRAVEL)
            {
                 TRAVELVALUE = MainWindowViewModel.Instance.Parent.DiscretionarySpending.Travel;
            }

            if (MainWindowViewModel.Instance.TV.HOBBIES)
            {
                 HOBBIESVALUE = MainWindowViewModel.Instance.Parent.DiscretionarySpending.Hobbies;
            }

            if (MainWindowViewModel.Instance.TV.SHOPPING)
            {
                 SHOPPINGVALUE = MainWindowViewModel.Instance.Parent.DiscretionarySpending.Shopping;
            }

            if (MainWindowViewModel.Instance.TV.OTHERDISCRETIONARYEXPENSES)
            {
                 OTHERDISCRETIONARYEXPENSESVALUE = MainWindowViewModel.Instance.Parent.DiscretionarySpending.OtherDiscretionaryExpenses;
            }

            if (MainWindowViewModel.Instance.TV.MALE)
            {

            }

            if (MainWindowViewModel.Instance.TV.FEMALE)
            {

            }
        }
        #endregion

       
        public void AllSalery()
        {
            Salerys = MainWindowViewModel.Instance.Income.PersonalIncome;


             Sum1 = RENTVALUE * Salerys;
             Sum2 = UTILITIESVALUE * Salerys;
             Sum3 = GROCERIESVALUE * Salerys;
             Sum4 = TRANSPORTATIONVALUE * Salerys;
             Sum5 = INSURANCEPREMIUMSVALUE * Salerys;
             Sum6 = MINIMUMDEBTPAYMENTSVALUE * Salerys;
             Sum7 = OTHERESSENTIALEXPENSESVALUE * Salerys;
             Sum8 = RETIREMENTSAVINGSVALUE * Salerys;
             Sum9 = HOUSEDOWNPAYMENTVALUE * Salerys;
             Sum10 = INVESTMENTSVALUE * Salerys;
             Sum11 = CHILDRENEDUCATIONSAVINGSVALUE * Salerys;
             Sum12 = DININGOUTVALUE * Salerys;
             Sum13 = ENTERTAINMENTVALUE * Salerys;
             Sum14 = TRAVELVALUE * Salerys;
             Sum15 = HOBBIESVALUE * Salerys;
             Sum16 = SHOPPINGVALUE * Salerys;
             Sum17 = OTHERDISCRETIONARYEXPENSESVALUE * Salerys;
             Sum18 = EMERGENCYFUNDVALUE * Salerys;

            TotalPayment = Sum1 + Sum2 + Sum3 + Sum4 + Sum5 + Sum6 + Sum7 + Sum8 + Sum9 + Sum10 + Sum11 + Sum12 + Sum13 + Sum14 + Sum15 + Sum16 + Sum17 + Sum18;
            TotalSavings = Salerys - TotalPayment;
        }
        #region ForText





        private double _salery;
        public double Salerys
        {
            get => _salery;
            set
            {
                this.RaiseAndSetIfChanged(ref _salery, value, nameof(Salerys));
            }
        }




        private double _totalPayment;
        public double TotalPayment
        {
            get => _totalPayment;
            set
            {
                this.RaiseAndSetIfChanged(ref _totalPayment, value, nameof(TotalPayment));
            }
        }

        private double _totalSavings;
        public double TotalSavings
        {
            get => _totalSavings;
            set
            {
                this.RaiseAndSetIfChanged(ref _totalSavings, value, nameof(TotalSavings));
            }
        }


        private double _sum1;
        public double Sum1
        {
            get => _sum1;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum1, value, nameof(Sum1));
            }
        }

        private double _sum2;
        public double Sum2
        {
            get => _sum2;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum2, value, nameof(Sum2));
            }
        }

        private double _sum3;
        public double Sum3
        {
            get => _sum3;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum3, value, nameof(Sum3));
            }
        }

        private double _sum4;
        public double Sum4
        {
            get => _sum4;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum4, value, nameof(Sum4));
            }
        }

        private double _sum5;
        public double Sum5
        {
            get => _sum5;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum5, value, nameof(Sum5));
            }
        }

        private double _sum6;
        public double Sum6
        {
            get => _sum6;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum6, value, nameof(Sum6));
            }
        }

        private double _sum7;
        public double Sum7
        {
            get => _sum7;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum7, value, nameof(Sum7));
            }
        }

        private double _sum8;
        public double Sum8
        {
            get => _sum8;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum8, value, nameof(Sum8));
            }
        }

        private double _sum9;
        public double Sum9
        {
            get => _sum9;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum9, value, nameof(Sum9));
            }
        }

        private double _sum10;
        public double Sum10
        {
            get => _sum10;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum10, value, nameof(Sum10));
            }
        }

        private double _sum11;
        public double Sum11
        {
            get => _sum11;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum11, value, nameof(Sum11));
            }
        }

        private double _sum12;
        public double Sum12
        {
            get => _sum12;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum12, value, nameof(Sum12));
            }
        }

        private double _sum13;
        public double Sum13
        {
            get => _sum13;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum13, value, nameof(Sum13));
            }
        }

        private double _sum14;
        public double Sum14
        {
            get => _sum14;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum14, value, nameof(Sum14));
            }
        }

        private double _sum15;
        public double Sum15
        {
            get => _sum15;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum15, value, nameof(Sum15));
            }
        }

        private double _sum16;
        public double Sum16
        {
            get => _sum16;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum16, value, nameof(Sum16));
            }
        }

        private double _sum17;
        public double Sum17
        {
            get => _sum17;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum17, value, nameof(Sum17));
            }
        }

        private double _sum18;
        public double Sum18
        {
            get => _sum18;
            set
            {
                this.RaiseAndSetIfChanged(ref _sum18, value, nameof(Sum18));
            }
        }
        #endregion
















        public void BackBTN()
        {
            MainWindowViewModel.Instance.SetViewModel(new BudgetViewModel());
        }
    }
}
