using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TestDrive.Models;

namespace TestDrive.ViewModels
{
    public class DetailViewModel : INotifyPropertyChanged
    {
        public Veiculo Veiculo { get; set; }
        public string TextFreioAbs
        {
            get { return string.Format("Freio ABS - R$ {0}", Veiculo.FREIO_ABS); }
        }
        public string TextArCondicionado
        {
            get { return string.Format("Ar Condicionado - R$ {0}", Veiculo.AR_CONDICIONADO); }
        }
        public string TextMp3Player
        {
            get { return string.Format("MP3 Player - R$ {0}", Veiculo.MP3_PLAYER); }
        }

        public bool FreioOn
        {
            get { return Veiculo.FreioOn; }
            set
            {
                Veiculo.FreioOn = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalValue));
            }
        }

        public bool ArCondicionadoOn
        {
            get { return Veiculo.ArCondicionadoOn; }
            set
            {
                Veiculo.ArCondicionadoOn = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalValue));
            }
        }

        public bool Mp3PlayerOn
        {
            get { return Veiculo.Mp3PlayerOn; }
            set
            {
                Veiculo.Mp3PlayerOn = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalValue));
            }
        }

        public string TotalValue
        {
            get
            {
                return Veiculo.TotalPriceFormatted;
            }
        }
        public DetailViewModel(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string name="")
        {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
