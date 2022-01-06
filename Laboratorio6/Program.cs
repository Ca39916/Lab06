using System;
using System.Collections.Generic;

namespace Laboratorio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Execício 6.1 ------");
            ContaPoupanca Poupanca1 = new ContaPoupanca(0.01m,DateTime.Now,"Camila Rezende");
            Console.WriteLine("Titular da conta: " + Poupanca1.Titular);
            Poupanca1.Depositar(200);
            Poupanca1.Sacar(20);
            Console.WriteLine("Saldo da conta 1 R$ " + Poupanca1.Saldo);
            Console.ReadKey();
            Poupanca1.AdicionarRendimento();
            Console.WriteLine("Valor do saldo após o rendimento R$ " + Poupanca1.Saldo);
            Console.ReadKey();
            Console.WriteLine("");

            ContaPoupanca Poupanca2 = new ContaPoupanca(0.01m, DateTime.Now, "Marcelo Salino");
            Console.WriteLine("Titular da conta: " + Poupanca2.Titular);
            Poupanca2.Depositar(100);
            Poupanca2.Sacar(40);
            Console.WriteLine("Saldo da conta 2 R$ " + Poupanca2.Saldo);
            Console.ReadKey();
            Poupanca2.AdicionarRendimento();
            Console.WriteLine("Valor do saldo após o rendimento R$ " + Poupanca2.Saldo);
            Console.ReadKey();
            Console.WriteLine("");

            ContaPoupanca Poupanca3 = new ContaPoupanca(0.01m, DateTime.Now, "Richard Rezende");
            Console.WriteLine("Titular da conta: " + Poupanca3.Titular);
            Poupanca3.Depositar(500);
            Poupanca3.Sacar(50);
            Console.WriteLine("Saldo da conta 3 R$ " + Poupanca3.Saldo);
            Console.ReadKey();
            Poupanca3.AdicionarRendimento();
            Console.WriteLine("Valor do saldo após o rendimento R$ " + Poupanca3.Saldo);
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("------ Execício 6.2 ------");
            List<ContaPoupanca> lista = new List<ContaPoupanca>(); //para usar o list tive que importar uma biblioteca
            lista.Add(new ContaPoupanca(0.01m, DateTime.Now, "Camila Rezende"));
            lista.Add(new ContaPoupanca(0.01m, DateTime.Now, "Gustavo"));
            lista.Add(new ContaPoupanca(0.01m, DateTime.Now, "Bruna"));

            lista[0].Depositar(500);
            lista[0].Sacar(50);
            lista[0].AdicionarRendimento();

            lista[1].Depositar(200);
            lista[1].Sacar(50);
            lista[1].AdicionarRendimento();

            lista[2].Depositar(500);
            lista[2].Sacar(50);
            lista[2].AdicionarRendimento();
            //todos os métodos podem ser chamados pela coleção


            foreach (ContaPoupanca lista2 in lista)
            {
                Console.WriteLine(" Nome do titular da conta:" + lista2.Titular);
                Console.WriteLine(" Saldo da conta  R$ " + lista2.Saldo);
                Console.WriteLine(" Data da abertura da conta: " + lista2.DataAniversario);
                Console.WriteLine("");
                Console.ReadKey();
            }
        
          

        }
    }
}
