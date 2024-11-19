namespace ExercicioCapitulo05
{
    public class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }

        public string NomeDoTitular { get; set; }

        public double ValorDoDepositoInicial { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int _numeroDaConta, string _nomeDoTitular, double _valorDeDeposito) 
        {
            NumeroDaConta = _numeroDaConta;
            NomeDoTitular = _nomeDoTitular;
            Deposito(_valorDeDeposito);
        }

        public double Deposito(double valorDoDeposito)
        {
            return Saldo += valorDoDeposito;
        }

        public double Saque(double valorDoSaque)
        {
            double taxaDoSaque = 5.0;
            valorDoSaque += taxaDoSaque;
            return Saldo -= valorDoSaque;
        }
    }
}