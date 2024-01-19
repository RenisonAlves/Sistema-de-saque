using System.Runtime.InteropServices.Marshalling;
using SistemaContasBancaria.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Cliente: ");
        string cliente = Console.ReadLine();
        Console.Clear();

        Console.WriteLine($"Olá {cliente}, qual conta você deseja acessar? \r\n \r\n C -> Conta Corrente \r\n P -> Poupança");
        string TipoConta = Console.ReadLine().ToLower();
        string Opcao;

        if (TipoConta == "c")
        {

            Console.WriteLine("Qual o número da sua conta? ");
            int Conta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{cliente}, bem vindo a sua Conta Corrente");

            ContaCorrente cc = new ContaCorrente(cliente, Conta);
            Console.Clear();
            Console.WriteLine($"Ola {cc.Cliente}, o que você precisa fazer:  \r\n \r\n");

            do
            {
                Console.WriteLine("########## Escolha uma opção ##########");
                Console.WriteLine("Saldo, pressione C:");
                Console.WriteLine("Saque, S: ");
                Console.WriteLine("Depósito, D: ");
                Console.WriteLine("Sair, E");
                Opcao = Console.ReadLine().ToLower();
                Console.Clear();
                //saque
                if (Opcao == "s")
                {
                    cc.Sacar();                 
                }
                //saldo
                else if (Opcao == "c")
                {
                    cc.ConsultarSaldo();
                }
                //deposito
                else if (Opcao == "d")
                {
                    cc.Depositar();
                }

            } while (Opcao != "e");

        }
        else
        {   
            Console.WriteLine("Numero da sua conta: ");
            int Conta = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"{cliente}, bem vindo a sua Conta Poupança \r\n \r\n");
            
            
            ContaPoupanca cp = new ContaPoupanca(cliente, Conta);

            do
            {
                Console.WriteLine("########## Escolha uma opção ########## \r\n \r\n");
                Console.WriteLine("Saldo, pressione C:");
                Console.WriteLine("Saque, S: ");
                Console.WriteLine("Depósito, D: ");
                Console.WriteLine("Sair, E");
                Console.WriteLine(" \r\n \r\n########################################");
                Opcao = Console.ReadLine().ToLower();
                Console.Clear();
                //saque
                if (Opcao == "s")
                {
                    cp.Sacar();
                }
                //saldo
                else if (Opcao == "c")
                {
                    cp.ConsultarSaldo();
                }
                //deposito
                else if (Opcao == "d")
                {
                    cp.Depositar();
                }

                else if((Opcao != "s")&&(Opcao != "c")&&(Opcao != "d")&&(Opcao != "e"))
                {
                    Console.WriteLine("Escolha uma opção valida");
                }
            }

     while (Opcao != "e") ;
}

}
}