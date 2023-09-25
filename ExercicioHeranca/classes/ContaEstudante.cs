using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca.classes
{
    internal class ContaEstudante : Conta
    {
        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }
        public string Instituicao { get; set; }
        public ContaEstudante(double limiteChequeEspecial,string cpf, string instituicao,
            int nconta, string agencia, string titularConta, double saldo):
            base(nconta,agencia,titularConta,saldo)
        {
            this.LimiteChequeEspecial= limiteChequeEspecial;
            Cpf = cpf;
            Instituicao = instituicao;
        }

        public override void Saque(double valor)
        {
            if(valor <= Saldo + LimiteChequeEspecial)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
        }
    }
}
