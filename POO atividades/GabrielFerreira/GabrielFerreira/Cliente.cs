using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielFerreira
{
    class Cliente : IMostrar
    {
        private int codigo;
        private string nome;
        private string whatsApp;
        private string email;
        private string cpf;
        private string foto;

        public Cliente(string nome, string cpf, string foto, string whatsApp, string email, int codigo)
        {
            Foto = foto;
            Cpf = cpf;
            Email = email;
            WhatsApp = whatsApp;
            Nome = nome;
            Codigo = codigo;
        }

        public void Mostrar()
        {
            Console.WriteLine("\nNome: " + Nome + "\nCPF: " + Cpf + "\nWhatsApp: " + WhatsApp + "\nEmail: " + Email  + "\nFoto: " + Foto);
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }


        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string WhatsApp
        {
            get { return whatsApp; }
            set { whatsApp = value; }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

 
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }



    }
}
