using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoDepartamento
{
    abstract class Funcionario //classe base-superclasse
    {
        protected int codigo;
        protected string nome;
        protected double salario;
        protected List<Dependente> dependentes = new List<Dependente>();

        public abstract double CalcularSalario(int diasUteis);

        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome:" + Nome + "\tSalário: " + Salario + "\tQuantidade de dependentes: " + TotalDependentes());
        }

        public virtual void AdicionarDependente(Dependente novoDep)
        {
            Console.WriteLine("Funcionário "+ Nome +" adicionando dependente: " + novoDep.Nome );
            dependentes.Add(novoDep);
        }

        public virtual void RemoverDependente(int codigo)
        {
            for (int i = 0; i < dependentes.Count; i++)
            {
                if (dependentes[i].Codigo == codigo)
                {
                    Console.WriteLine("Removendo: " + dependentes[i].Nome);
                    dependentes.Remove(dependentes[i]);
                }
            }
        }

        public virtual int TotalDependentes()
        {
            return dependentes.Count;
        }

        public virtual void ListarDependentes()
        {
            Console.WriteLine("Dependentes do funcionário: " + Nome);
            foreach (var dependente in dependentes)
            {
                dependente.Mostrar();
            }
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

        public List<Dependente> Dependentes
        {
            get { return this.dependentes; }
            set { this.dependentes = value; }
        }
    }
}