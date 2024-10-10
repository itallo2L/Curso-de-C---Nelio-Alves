namespace ExercicioCapitulo05
{
    public class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }

        public string NomeDoTitular { get; set; }

        public double ValorDoDepositoInicial { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int _numeroDaConta, string _nomeDoTitular, double? _valorDeDeposito) 
        {
            NumeroDaConta = _numeroDaConta;
            NomeDoTitular = _nomeDoTitular;

            if (ValorDoDepositoInicial == 0.0 || ValorDoDepositoInicial == null)
                Saldo = 0.0;
        }

        public double Deposito(double valorDoDeposito)
        {
            return Saldo += valorDoDeposito;
        }

        public void Saque(double valorDoSaque)
        {
            double taxaDoSaque = 5.0;
            valorDoSaque += taxaDoSaque;
            Saldo -= valorDoSaque;
        }
    }
}