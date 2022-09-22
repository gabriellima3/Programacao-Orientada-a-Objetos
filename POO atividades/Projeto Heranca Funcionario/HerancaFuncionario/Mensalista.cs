using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    class Mensalista : Funcionario
    {
        private double qtdeHorasTrabalhadas;

        public Mensalista(int codigo, string nome, double salario, double qtdeHorasTrabalhadas)
          : base(codigo, nome, salario)
        {
            QtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
        }
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Quantidade de horas trabalhadas  no mês: " + QtdeHorasTrabalhadas + " horas");
        }
        public double QtdeHorasTrabalhadas
        {
            set { this.qtdeHorasTrabalhadas = value; }
            get { return this.qtdeHorasTrabalhadas; }
        }
    }
}
