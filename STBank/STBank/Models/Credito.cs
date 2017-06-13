using System;
using System.ComponentModel;

namespace STBank.Models
{
    public class Credito : INotifyPropertyChanged
    {
        public Guid Id { get; set; }
        public Cliente Cliente { get; set; }
        public double Monto { get; set; }
        public string Tipo { get; set; }
        public int PlazoEnMeses { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;        
    }
}