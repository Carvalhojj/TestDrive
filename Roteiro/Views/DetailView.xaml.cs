using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static TestDrive.Views.ListaView;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailView : ContentPage
    {
        private const int FREIO_ABS = 800;
        private const int AR_CONDICIONADO = 1000;
        private const int MP3_PLAYER = 500;

        public string TextFreioAbs
        {
            get { return string.Format("Freio ABS - R$ {0}", FREIO_ABS); }
        }
        public string TextArCondicionado
        {
            get { return string.Format("Ar Condicionado - R$ {0}", AR_CONDICIONADO); }
        }
        public string TextMp3Player
        {
            get { return string.Format("MP3 Player - R$ {0}", MP3_PLAYER); }
        }

        bool freioOn;
        public bool FreioOn 
        {
            get { return freioOn; }
            set 
            {
               freioOn = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalValue));
            }
        }

        bool arCondicionadoOn;
        public bool ArCondicionadoOn
        {
            get { return arCondicionadoOn; }
            set
            {
                arCondicionadoOn = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalValue));
            }
        }

        bool mp3PlayerOn;
        public bool Mp3PlayerOn
        {
            get { return mp3PlayerOn; }
            set
            {
                mp3PlayerOn = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalValue));
            }
        }

        public string TotalValue 
        { 
            get 
            { 
                return string.Format("Valor Total: R$ {0}", Veiculo.Price + (FreioOn ? FREIO_ABS : 0) + (ArCondicionadoOn ? AR_CONDICIONADO : 0) + (Mp3PlayerOn ? MP3_PLAYER : 0)); 
            } 
        }
        public Veiculo Veiculo { get; set; }
        public DetailView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            this.BindingContext = this;
        }

        private void btProx_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SchedulingView(this.Veiculo));
        }
    }
}