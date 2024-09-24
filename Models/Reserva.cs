namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            bool validacaoDeHospedes = hospedes.Count() <= Suite.Capacidade;
            if (validacaoDeHospedes)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Quantidade de hospedes além da capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(List<Pessoa> hospedes)
        {
            int quantidadeDeHospedes = hospedes.Count();
            return quantidadeDeHospedes;
        }

        public double CalcularValorDiaria()
        {
            double valor = 0;

            valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.1);
            }

            return valor;
        }
    }
}