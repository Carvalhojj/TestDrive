using System.Collections.Generic;

namespace TestDrive.Models
{
    public class ListaVeiculos
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListaVeiculos() 
        {
            this.Veiculos = new List<Veiculo>
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
        }
    }
}
