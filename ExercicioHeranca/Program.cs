
using ExercicioHeranca.classes;

public class Program
{
    static void Main(string[] args)
    {
        int Nconta = 1;
        string agencia = "Jipa";
        while (true)
        {
            Console.WriteLine("Digite \n " +
            "1 para conta normal, \n " +
            "2 para conta estudante e \n " +
            "3 para conta empresarial \n" +
            "4 para sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular");
            string nomeTitular = Console.ReadLine();

            if(opcao == 1)
            {
                Conta c = new Conta(Nconta,agencia, nomeTitular, 0);
                Nconta += 1;
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar  e 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());
                     
                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Deposito(valor);
                        Console.WriteLine($"Novo saldo {c.Saldo}");
                    }
                    else if(opcao == 2)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Saque(valor);
                        Console.WriteLine($"Novo saldo {c.Saldo}");
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }else if(opcao == 2)
            {
                Console.WriteLine("Digite o CPF do estudante");
                string cpf = Console.ReadLine();

                Console.WriteLine("Informe a instituição");
                string instituicao = Console.ReadLine();

                ContaEstudante ce = new ContaEstudante(100,cpf,instituicao, Nconta, agencia,nomeTitular,0);
                Nconta += 1;
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar  e 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Deposito(valor);
                        Console.WriteLine($"Novo saldo {ce.Saldo}");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Saque(valor);
                        Console.WriteLine($"Novo saldo {ce.Saldo}");
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if(opcao == 3)
            {
                ContaEmpresa cempresa = new ContaEmpresa(10,1000, Nconta, agencia, nomeTitular, 0);
                Nconta += 1;
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar  e 3 para fazer emprestimo e 4 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresa.Deposito(valor);
                        Console.WriteLine($"Novo saldo {cempresa.Saldo}");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresa.Saque(valor);
                        Console.WriteLine($"Novo saldo {cempresa.Saldo}");
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresa.RealizarEmprestimo(valor);
                        Console.WriteLine($"Novo saldo {cempresa.Saldo}");
                    }
                    else if (opcao == 4)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if(opcao == 4)
            {
                break;
            }
        }
    }
}