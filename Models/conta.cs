using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaContasBancaria.Models
{
    public abstract class Conta
    {
        public string Cliente { get; set; }
        protected int NumeroDaConta { get; set; }
        public decimal Saldo { get; set; }
        public Conta(string cliente, int numeroConta)
        {
            Cliente = cliente;
            NumeroDaConta = numeroConta;
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine($"O seu saldo é R$ {Saldo},00\r\n");
        }
        public void Depositar()
        {
            Console.WriteLine("Qual o valor do depósito? ");
            decimal Valor = Convert.ToDecimal(Console.ReadLine());
            Saldo += Valor;
            Console.WriteLine($"A operação de depósito no valor de R$ {Valor},00 foi realizado com sucesso!\r\n");
        }
        public void Sacar()
        {
            Console.WriteLine("Qual valor deseja sacar? ");
            decimal Valor = Convert.ToDecimal(Console.ReadLine());
            if (Saldo >= Valor && Saldo != 0)
            {
                Saldo -= Valor;
                Console.WriteLine($"A operação de saque no valor de R$ {Valor},00 foi realizada com sucesso!\r\n");
            }
            else
            {
                Console.WriteLine($"Seu saldo não é suficiente, você tem apenas R$ {Saldo},00  \r\n \r\n");
                Console.WriteLine("escolha 'S' para sacar outro valor ou 'F' para fechar.");
                string Escolha = Console.ReadLine().ToLower();
                if (Escolha == "s")
                {
                    Sacar();
                }
                Environment.Exit(0);
            }
        }           

    }

}