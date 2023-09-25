using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca.classes
{
    internal class ContaEmpresa:Conta
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get;set; }
        public double TotalEmprestimo { get; set; }

        public ContaEmpresa(double anuidade, double limiteEmprestimo, 
            int nconta, string agencia, string titularConta, double saldo):
            base(nconta, agencia, titularConta, saldo)
        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;       
        }


        public override void Saque(double valor)
        {
            if(valor <= Saldo)
            {
                Saldo -= valor;
                if(valor >= 5000)
                {
                    Saldo -= 5;
                }
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
        }

        public void RealizarEmprestimo(double valor)
        {
            if(valor <= LimiteEmprestimo - TotalEmprestimo)
            {
                Saldo += valor;
                TotalEmprestimo += valor;
            }
            else
            {
                Console.WriteLine("Valor indispovível!");
            }
        }
    }
}
