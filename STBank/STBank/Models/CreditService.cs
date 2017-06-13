using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STBank.Models
{
    public class CreditService: ICreditService
    {
        private static List<Cliente> Clientes = new List<Cliente>()
        {
            new Cliente(){DNI = "70255464",Nombres = "Cesar Jesus",Apellidos = "Angulo", Id = Guid.NewGuid()},
            new Cliente(){DNI = "80255464",Nombres = "Elton",Apellidos = "Rodriguez", Id = Guid.NewGuid()},
            new Cliente(){DNI = "12345678",Nombres = "Martin",Apellidos = "Angulo", Id = Guid.NewGuid()},
            new Cliente(){DNI = "01234567",Nombres = "Maria Isabel",Apellidos = "Vallenas", Id = Guid.NewGuid()}
        };
        private static List<Credito> Creditos = new List<Credito>();
        private const int DelayInMs = 300;
        private const int Cuota = 30;
        public async Task<Cliente> GetClienteByDNI(string dni)
        {
            await Task.Delay(DelayInMs);
            return Clientes.FirstOrDefault(c => c.DNI == dni);
        }

        public async Task<IList<string>> GetTipoCreditosAsync()
        {
            await Task.Delay(DelayInMs);
            return new List<string>()
            {
                "Personal","Hipotecario","Automotriz"
            };
        }

        public async Task<bool> EvaluarCreditoAsync(Credito credito)
        {
            await Task.Delay(DelayInMs);

            switch (credito.Cliente.DNI.ToCharArray()[0])
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    return false;
                    break;
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    return true;
                    break;
            }
            return false;
        }

        public async Task<bool> RegistrarCreditoAsync(Credito credito)
        {
            await Task.Delay(2 * DelayInMs);
            Creditos.Add(credito);
            return true;
        }

        public async Task<IList<Credito>> GetCreditosHoy()
        {
            await Task.Delay(DelayInMs);
            return Creditos;
        }

        public async Task<int> GetCuota()
        {
            await Task.Delay(DelayInMs);
            return Cuota;
        }

        public async Task<int> GetCuotaRestante()
        {
            await Task.Delay(DelayInMs);
            return Cuota - Creditos.Count;
        }
    }
}
