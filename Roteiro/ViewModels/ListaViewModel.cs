using System.Collections.Generic;
using TestDrive.Models;

namespace TestDrive.ViewModels
{
    public class ListaViewModel
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListaViewModel() 
        {
            this.Veiculos = new ListaVeiculos().Veiculos;
        }
    }
}
