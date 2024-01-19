using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SistemaContasBancaria.Models
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string cliente, int numeroConta) : base(cliente,numeroConta)
        {

        }  
        

        // public decimal Rendimentos(int mes)
        // {
        //     decimal RendaMensal = Conta.Saldo*0.1*mes;
        // }
    }
}