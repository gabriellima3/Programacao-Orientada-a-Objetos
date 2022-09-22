using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecaoConta
{
    class Conta
    {

        private double saldo;
        public Conta(double saldo)
        {
            Saldo = saldo;
        }
        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }
        
        public void Depositar(double valorDepositado)
        {
            /*O sistema minimiza a tela do prompt e mostra a exceção (Exceço Sem Tratamento)*/
            try
            {
                if (valorDepositado < 0)              
                    throw new ArgumentException();
                    Saldo = Saldo + valorDepositado;
                    Console.WriteLine("Valor Depositado com Sucesso!");
            }
            catch
            {
                Console.WriteLine("Argumento Inválido");
            }
                 
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Saldo: " + Saldo);
        }
    }
}
