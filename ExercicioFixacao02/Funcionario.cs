namespace ExercicioDeFixacao02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            var salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            var aumento = (porcentagem / 100) * SalarioBruto;
            SalarioBruto += aumento;
        }
    }
}