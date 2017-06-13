using System.Collections.Generic;
using System.Threading.Tasks;

namespace STBank.Models
{
    public interface ICreditService
    {
        Task<Cliente> GetClienteByDNI(string dni);
        Task<IList<string>> GetTipoCreditosAsync();
        Task<bool> EvaluarCreditoAsync(Credito credito);
        Task<bool> RegistrarCreditoAsync(Credito credito);
        Task<IList<Credito>> GetCreditosHoy();
        Task<int> GetCuota();
        Task<int> GetCuotaRestante();
    }
}