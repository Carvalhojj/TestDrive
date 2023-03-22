using System;
using TestDrive.Models;

namespace TestDrive.ViewModels
{
    public class SchedulingViewModel
    {
        public Scheduling Scheduling { get; set; }
        public Veiculo Veiculo
        {
            get { return Scheduling.Veiculo; }
            set { Scheduling.Veiculo = value; }
        }
        public string Name
        {
            get { return Scheduling.Name; }
            set { Scheduling.Name = value; }
        }
        public string Fone
        {
            get { return Scheduling.Fone; }
            set { Scheduling.Fone = value; }
        }
        public string Email
        {
            get { return Scheduling.Email; }
            set { Scheduling.Email = value; }
        }
        public DateTime SchedulingTime
        {
            get
            {
                return Scheduling.SchedulingTime;
            }
            set
            {
                Scheduling.SchedulingTime = value;
            }
        }
        public TimeSpan SchedulingHour
        {
            get { return Scheduling.SchedulingHour; }
            set { Scheduling.SchedulingHour = value; }
        }
        public SchedulingViewModel(Veiculo veiculo)
        {
            this.Scheduling = new Scheduling();
            this.Scheduling.Veiculo = veiculo;
        }
    }
}
