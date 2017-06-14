using System.Collections.Generic;
using Prism.Mvvm;
using Prism.Navigation;
using STBank.Models;

namespace STBank.ViewModels
{
    public class CheckCreditPageViewModel : 
        BindableBase, INavigatedAware
    {
        public string DNI { get; set; }
        public string Monto { get; set; }
        public string TipoCredito { get; set; }
        public List<string> TiposCredito { get; set; }
        public int NumeroCuotas { get; set; }
        public List<int> Cuotas { get; set; }
        public bool EstaAprobado { get; set; }
        public string Mensaje { get; set; }

        public CheckCreditPageViewModel
            (ICreditService creditService)
        {
            _creditService = creditService;
        }
        private readonly ICreditService _creditService;

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}
