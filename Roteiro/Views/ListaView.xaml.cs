using System.Collections.Generic;
using Xamarin.Forms;

namespace TestDrive.Views
{
    public partial class ListaView : ContentPage
    {
        public class Veiculo
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string FormattedPrice => string.Format("R$ {0}", Price);
        }
        public List<Veiculo> Veiculos { get; set; }
        public ListaView()
        {
            InitializeComponent();

            Veiculos = new List<Veiculo>
            {
                new Veiculo { Name = "Azera V6", Price = 85000 },
                new Veiculo { Name = "Onix 1.6", Price = 35000 },
                new Veiculo { Name = "Fiesta 2.0", Price = 52000 },
                new Veiculo { Name = "C3 1.0", Price = 22000 },
                new Veiculo { Name = "Uno Fire", Price = 11000 },
                new Veiculo { Name = "Sentra 2.0", Price = 53000 },
                new Veiculo { Name = "Astra Sedan", Price = 39000 },
                new Veiculo { Name = "Vectra 2.0", Price = 37000 },
                new Veiculo { Name = "Hilux 4x4", Price = 90000 },
                new Veiculo { Name = "Montana", Price = 57000 },
                new Veiculo { Name = "Outlander", Price = 90000 },
            };

            BindingContext = this;
        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            Navigation.PushAsync(new DetailView(veiculo));
        }
    }
}
