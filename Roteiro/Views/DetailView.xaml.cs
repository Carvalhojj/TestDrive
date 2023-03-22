using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestDrive.Models;
using TestDrive.ViewModels;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailView : ContentPage
    {
        public Veiculo Veiculo { get; set; }
        public DetailView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            this.BindingContext = new DetailViewModel(veiculo);
        }

        private void btProx_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SchedulingView(this.Veiculo));
        }
    }
}