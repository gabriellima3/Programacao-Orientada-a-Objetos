using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoDepartamento
{
    class Comissionado : Funcionario
    {
        private double porcentagem;

        public override double CalcularSalario(int diasUteis)
        {
            return salario * 30 / diasUteis *
                Porcentagem + Salario; ;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Porcentagem: " + Porcentagem);
        }

        public double Porcentagem
        {
            set { this.porcentagem = value; }
            get { return this.porcentagem; }
        }

        public Comissionado(int codigo, string nome,
            double salario, double porcentagem)
            : base(codigo, nome, salario)
        {
            Porcentagem = porcentagem;
        }
    }

}
