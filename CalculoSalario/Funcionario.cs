using System;
namespace CalculoSalario
{
    public class Funcionario
    {
        public double CPF { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double ValorHora { get; set; }
        public double HorasTrab { get; set; }
        public double Salario { get; private set; }

        public void CalculaSalario()
        {
            Salario = (HorasTrab * ValorHora) * 30;
        }

    }
}
