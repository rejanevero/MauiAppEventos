namespace MauiAppEventos.Models
{
    public class Evento
    {
        public string? NomeEvento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int QntParticipante {  get; set; }
        public double CustoParticipante { get; set; }
        public string? LocalEvento { get; set; }
    
        public int Duracao
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }
        public double ValorTotal
        {
            get
            {
                double total = QntParticipante * CustoParticipante;

                return total;
            }
        }
    }
}
