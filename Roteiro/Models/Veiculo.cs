namespace TestDrive.Models
{
    public class Veiculo
    {
        public const int FREIO_ABS = 800;
        public const int AR_CONDICIONADO = 1000;
        public const int MP3_PLAYER = 500;
        public string Name { get; set; }
        public double Price { get; set; }
        public string FormattedPrice => string.Format("R$ {0}", Price);
        public bool FreioOn { get; set; }
        public bool ArCondicionadoOn { get; set; }
        public bool Mp3PlayerOn { get; set; }
        public string TotalPriceFormatted 
        {
            get 
            {
                return string.Format("Valor Total: R$ {0}", Price + (FreioOn ? Veiculo.FREIO_ABS : 0) + (ArCondicionadoOn ? Veiculo.AR_CONDICIONADO : 0) + (Mp3PlayerOn ? Veiculo.MP3_PLAYER : 0));
            }
        }
    }
}
