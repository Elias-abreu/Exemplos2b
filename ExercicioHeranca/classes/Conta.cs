using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca.classes
{
    internal class Conta
    {
        public int Nconta { get; set; }
        public string Agencia { get; set; }
        public string TitularConta { get; set; }
        public double Saldo { get; set; }

        public Conta() { }
        public Conta(int nconta, string agencia, string titularConta, double saldo)
        {
            Nconta = nconta;
            Agencia = agencia;
            TitularConta = titularConta;
            Saldo = saldo;
        }

        public virtual void Saque(double valor)
        {
            if(Saldo >=  valor)
            {
                //Saldo -= valor;
                Saldo = Saldo - valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public void Deposito(double valor)
        {
            if(valor >= 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Operação inválida!");
            }
            
        }
    }
}
