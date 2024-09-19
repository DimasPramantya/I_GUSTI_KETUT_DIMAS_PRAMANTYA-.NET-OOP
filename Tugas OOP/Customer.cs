using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas;

namespace Tugas
{
    public class Customer : User
    {
        public Customer(string nama, double saldo)
        {
            this.Saldo = saldo;
            this.Name = nama;
        }

    }
}
