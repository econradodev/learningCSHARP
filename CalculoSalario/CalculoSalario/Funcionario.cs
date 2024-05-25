using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioAtual;

        public double SalarioLiquido()
        {
            return SalarioAtual = SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioAtual += SalarioBruto * porcentagem / 100;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + SalarioAtual.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
