using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoDepartamento
{
    class Dependente
    {
        private int codigo;

        private string nome;

        private int idade;

        public Dependente(int codigo, string nome, int idade)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.idade = idade;
        }

        public void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome:" + Nome + "\tIdade: " + Idade);
        }

        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public bool VerificarMaiorIdade()
        {
            return this.Idade >= 18;
        }
    }
}
