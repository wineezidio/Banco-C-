using System;
using System.Globalization;


namespace ConsoleApp3
{
    internal class Banco
    {
        public double Saldo { get; private set; } // proprities onde eu posso imprimir o saldo sem poder alterar ele
        public string Titular { get; set; } // aqui eu posso alterar e chamar o Titular
        public int Conta { get; private set; } // aqui eu nao posso alterar o numero da conta


        public Banco(int conta, string titular) /* construtor com 2 paramtros int e string e
            instaciando os atributos nos parametros */
        {
            Titular = titular;
            Conta = conta;
            
        }

        public Banco(int conta, string titular, double saldo) : this (conta, titular) /*construtor com 3 paramtros int, string e double 
            usando o this para chamar os parametros e os atributos do outro construtor e passando tambem um parametro para o atributo instaciado  */
        {
            Saldo = saldo;
        }

        public void  Deposito(double depositofinal) /* Aqui sao os metodos de operacao "esse double depositofinal" 
             vai me trazer um valor da outra classe 
            para somar com o saldo e na outra classe eu preciso chamar esse metodo com o nome 
            atribuido a ele la "banco.Deposito("aqui minha variavel double") "*/
        {
            Saldo = Saldo + depositofinal;
        }

        public void Saque(double depositofinal)
        {
            Saldo -= depositofinal + 5.0;
        }




        public override string ToString()
        {
            return "Conta " +
                Conta + 
                ", Titular: " 
                + Titular 
                + ", Saldo: $ " 
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}

