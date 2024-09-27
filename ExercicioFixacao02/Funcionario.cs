namespace ExercicioDeFixacao02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalarioLiquido()
        {
            double salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            double aumento = (porcentagem / 100.00) * SalarioBruto;
            SalarioBruto += aumento;
        }
    }
}