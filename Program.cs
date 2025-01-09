using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp3;

namespace Console3
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco;

            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("havera deposito inicial (s/n) ? ");
            char depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial == 's')
            {
                Console.Write("Entre com o valor do deposito: ");
                double depositoI = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                banco = new Banco(conta, titular, depositoI); /* Aqui precisei criar uma variavel para informar o valor do deposito
                               e depois informei ela dentro do construtor para guardar o valor atribuido nela */
            } else
            {
                 banco = new Banco(conta, titular); /* se eu nao fizer o deposito o else ira usar o construtor para 
                para imprimir o numero int da conta e a nome string do titular */
            }

           

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(banco);
            Console.WriteLine();

            Console.Write("Entre com um valor para o deposito: ");
            double depositofinal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            banco.Deposito(depositofinal); // Nesse caso o metodo criado na classe foi chamado na qual é " banco.Deposito" e no (depositofinal vai jogar o valor da variavel dentro da operacao)
            //e ja deixa salvo o valor devido o "Saldo" estar dentro do metodo
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(banco);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            depositofinal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados: ");
            banco.Saque(depositofinal);
            Console.WriteLine(banco);







        }




    }
}
