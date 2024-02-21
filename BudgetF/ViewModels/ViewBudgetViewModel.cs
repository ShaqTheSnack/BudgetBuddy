using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetF.ViewModels
{
    internal class ViewBudgetViewModel : ViewModelBase
    {
        public ViewBudgetViewModel()
        {
            TTT();
        }

        public void TTT()
        {
            string TV = MainWindowViewModel.Instance.TV.RENT;
        }
        public void BackBTN()
        {
            MainWindowViewModel.Instance.SetViewModel(new BudgetViewModel());
        }
    }
}
