using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    abstract class Funcionario //classe base-superclasse, referencia
    {
        protected int codigo;
        protected string nome;
        protected double salario;
        public abstract double CalcularSalario(int diasUteis);
        public virtual void Mostrar()//polimorfismo
        {
            Console.WriteLine("Código: " + Codigo +
                "\tNome:" + Nome + "\tSalário: " + Salario);
        }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public double Salario
        {
            get { return this.salario; }
            set { this.salario = value; }
        }
    }
}
