using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas;

namespace Tugas
{
    public class Admin : User
    {
        public void UbahSaldo(Customer customer, double saldo)
        {
            customer.Saldo += saldo;
        }

        public Admin(string nama)
        {
            this.Name = nama;
        }
    }
}
