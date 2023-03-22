using Xamarin.Forms;
using TestDrive.Models;
using TestDrive.ViewModels;

namespace TestDrive.Views
{
    public partial class ListaView : ContentPage
    {
        

        public ListaView()
        {
            InitializeComponent();
        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            Navigation.PushAsync(new DetailView(veiculo));
        }
    }
}
