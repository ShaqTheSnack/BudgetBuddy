using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetF.Models
{
    public class JsonParent
    {
        public JSONEssentialExpenses EssentialExpenses;
        public JSONFinancialGoals FinancialGoals;
        public JSONDiscretionarySpending DiscretionarySpending;
    }
    public class JSONEssentialExpenses
    {
        public double RentOrMortgage;
        public double Utilities;
        public double Groceries;
        public double Transportation;
        public double InsurancePremiums;
        public double MinimumDebtPayments;
        public double OtherEssentialExpenses;
    }

    public class JSONFinancialGoals
    {
        public double RetirementSavings;
        public double EmergencyFund;
        public double HouseDownPayment;
        public double Investments;
        public double ChildrenEducationSavings;
    }

    public class JSONDiscretionarySpending
    {
        public double DiningOut;
        public double Entertainment;
        public double Travel;
        public double Hobbies;
        public double Shopping;
        public double OtherDiscretionaryExpenses;
    }

}
