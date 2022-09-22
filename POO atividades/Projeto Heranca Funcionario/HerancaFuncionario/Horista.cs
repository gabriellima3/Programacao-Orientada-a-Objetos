using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    class Horista : Funcionario
    {
        private double qtdeHorasSemana;

        public Horista(int codigo, string nome, double salario, double qtdeHorasSemana)
          : base(codigo, nome, salario)
        {
            QtdeHorasSemana = qtdeHorasSemana;
        }
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Quantidade de horas trabalhadas por semana: " + QtdeHorasSemana + " horas");
        }
        public double QtdeHorasSemana
        {
            set { this.qtdeHorasSemana = value; }
            get { return this.qtdeHorasSemana; }
        }
    }
}
