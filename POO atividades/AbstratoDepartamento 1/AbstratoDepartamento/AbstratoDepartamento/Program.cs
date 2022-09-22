using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoDepartamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Assalariado a1 = new Assalariado(2, "Gabriel", 500);
            Dependente a1d1 = new Dependente(1, "Maria", 9);
            a1.AdicionarDependente(a1d1);
            Dependente a1d2 = new Dependente(2, "Thomas", 12);
            a1.AdicionarDependente(a1d2);
            a1.ListarDependentes();

            Console.WriteLine();

            Assalariado a2 = new Assalariado(3, "Lucas", 200);
            Dependente a2d1 = new Dependente(1, "Pedro", 10);
            a2.AdicionarDependente(a2d1);

            Console.WriteLine();

            Comissionado c1 = new Comissionado(4, "João", 600, 0.3);
            Dependente c1d1 = new Dependente(1, "Arthur", 7);
            c1.AdicionarDependente(c1d1);

            Console.WriteLine();

            Comissionado c2 = new Comissionado(5, "Fin", 400, 0.2);

            Departamento d1 = new Departamento(1, "Relações Públicas");
            d1.Vetf = new List<Funcionario>();
            d1.AdmitirFuncionario(a1);
            d1.AdmitirFuncionario(c1);
            d1.ListarNomeFuncionarioESalarioFixo();
            Console.WriteLine();
            d1.MostrarQtdeDependentesFuncionario();
            Console.WriteLine();

            a1.RemoverDependente(1);
            Console.WriteLine();
            a1.ListarDependentes();
            Console.WriteLine();
            d1.MostrarQtdeDependentesFuncionario();
            Console.WriteLine("Total: " + d1.CalculaFolhaPagamento(30));
            Console.WriteLine("Total: " + d1.CalculaFolhaPagamento(30));

            Console.WriteLine();
            d1.DemitirFuncionario(2);
            d1.ListarNomeFuncionarioESalarioFixo();

            Departamento d2 = new Departamento(2, "RH");
            d2.Vetf = new List<Funcionario>();
            d2.AdmitirFuncionario(a2);
            d2.AdmitirFuncionario(c2);
            d2.ListarNomeFuncionarioESalarioFixo();
            Console.WriteLine();
            d2.MostrarQtdeDependentesFuncionario();
            Console.WriteLine("Total: " + d2.CalculaFolhaPagamento(30));
            Console.WriteLine();
            d2.DemitirFuncionario(5);
            d2.ListarNomeFuncionarioESalarioFixo();
            Console.ReadKey();
        }
    }
}
