using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SistemaContasBancaria.Models
{

    public class ContaCorrente : Conta
    {
        public decimal Taxa = 25;
        public ContaCorrente(string cliente, int numeroConta) : base(cliente, numeroConta)
        {       

        }

        public decimal TaxaAdministrativas() => Taxa;
    }
}