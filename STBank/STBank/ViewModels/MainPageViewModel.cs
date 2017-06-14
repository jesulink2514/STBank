using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using STBank.Models;

namespace STBank.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        
        public int CreditosRegistradosHoy { get; set; }
        public int CreditosRestantesCuota { get; set; }
        public ICommand EvaluarCommand { get; private set; }

        public MainPageViewModel(ICreditService creditService,
            INavigationService navigationService)
        {
            _creditService = creditService;
            _navigationService = navigationService;
            EvaluarCommand = new DelegateCommand(
                async()=> await _navigationService.NavigateAsync("CheckCreditPage"));
        }
        private readonly ICreditService _creditService;
        private readonly INavigationService _navigationService;


        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            using (Acr.UserDialogs.UserDialogs.Instance.Loading("Cargando..."))
            {
                CreditosRegistradosHoy = (await _creditService.GetCreditosHoy()).Count;
                CreditosRestantesCuota = await _creditService.GetCuotaRestante();
            }
        }
    }
}
