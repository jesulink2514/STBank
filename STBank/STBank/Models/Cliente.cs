using System;
using System.ComponentModel;

namespace STBank.Models
{
    public class Cliente :INotifyPropertyChanged
    {
        public Guid Id { get; set; }
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}