using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestDrive.Models;
using TestDrive.ViewModels;

namespace TestDrive.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SchedulingView : ContentPage
	{
		public SchedulingViewModel ViewModel { get; set; }
		public SchedulingView(Veiculo veiculo)
		{
			InitializeComponent ();
			this.ViewModel = new SchedulingViewModel(veiculo);
			this.BindingContext = this.ViewModel;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
			DisplayAlert("Agendamento", 
			string.Format(
			@"
			Veículo: {0}
			Nome: {1}
			Telefone: {2}
			Email: {3}
			Data: {4}
			Hora: {5}",
			ViewModel.Scheduling.Veiculo.Name, 
			ViewModel.Scheduling.Name,
			ViewModel.Scheduling.Fone, 
			ViewModel.Scheduling.Email, 
			ViewModel.Scheduling.SchedulingTime.ToString("dd/MM/yyyy"), ViewModel.Scheduling.SchedulingHour), "OK");
        }
    }
}