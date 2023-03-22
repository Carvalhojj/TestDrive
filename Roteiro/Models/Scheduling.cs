using System;

namespace TestDrive.Models
{
    public class Scheduling
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
    }
}
