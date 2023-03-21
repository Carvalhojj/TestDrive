using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static TestDrive.Views.ListaView;

namespace TestDrive.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SchedulingView : ContentPage
	{
		public Veiculo Veiculo { get; set; }

		public string Name { get; set; }
		public string Fone { get; set; }
		public string Email { get; set; }

		DateTime schedulingTime = DateTime.Today;
        public DateTime SchedulingTime 
		{
			get 
			{
				return schedulingTime;
			}
			set 
			{
				schedulingTime = value;
			} 
		}
		public TimeSpan SchedulingHour { get; set; }
		public SchedulingView(Veiculo veiculo)
		{
			InitializeComponent ();
			this.Veiculo = veiculo;
			this.BindingContext = this;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
			DisplayAlert("Agendamento", 
string.Format(
@"Nome: {0}
Telefone: {1}
Email: {2}
Data: {3}
Hora: {4}",
Name, Fone, Email, SchedulingTime.ToString("dd/MM/yyyy"), SchedulingHour), "OK");
        }
    }
}