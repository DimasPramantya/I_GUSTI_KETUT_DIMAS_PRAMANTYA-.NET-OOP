using System;

namespace Tugas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = { new Customer("dimas", 1000), new Customer("tegus", 1000) };
            Admin admin = new Admin("Wiliam");
            bool check = true;
            int menu;
            string nama;
            int saldo;
            while (check)
            {
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine("Program EMONEY");
                System.Console.WriteLine();
                System.Console.WriteLine("1. ADMIN");
                System.Console.WriteLine("2. CUSTOMER");
                System.Console.Write("Menu = ");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    System.Console.WriteLine();
                    System.Console.Write("Masukkan nama :");
                    nama = Console.ReadLine();
                    if (nama == "William")
                    {
                        foreach (var item in customer)
                        {
                            System.Console.WriteLine("Nama : " + item.Name);
                            System.Console.WriteLine("Saldo: " + item.Saldo);
                            System.Console.WriteLine();
                        }
                        System.Console.Write("Pilih customer: ");
                        nama = Console.ReadLine();
                        System.Console.WriteLine(nama);
                        int i = -1;
                        for(int index = 0; index < customer.Length; index++)
                        {
                            if (String.Equals(customer[index].Name, nama)){
                                i = index;

                            }
                        }
                        if (i == -1)
                        {
                            System.Console.WriteLine("Customer tidak ditemukan");
                        }
                        else
                        {
                            System.Console.WriteLine();
                            System.Console.Write("Masukkan saldo yang ingin ditambahkan: ");
                            saldo = Convert.ToInt32(Console.ReadLine());
                            admin.UbahSaldo(customer[i], saldo);
                            System.Console.WriteLine("Saldo berhasil ditambah, saldo sekarang: " + customer[i].Saldo);
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("UNAUTHORIZED!");
                    }

                }
                if (menu == 2)
                {
                    System.Console.WriteLine();
                    System.Console.Write("Masukkan nama :");
                    nama = Console.ReadLine();
                    int i = -1;
                    for (int index = 0; index < customer.Length; index++)
                    {
                        if (String.Equals(customer[index].Name, nama)){
                            i = index;
                        }
                    }
                    if (i == -1)
                    {
                        System.Console.WriteLine("Customer tidak ditemukan");
                    }
                    else
                    {
                        System.Console.WriteLine("Nama : " + customer[i].Name);
                        System.Console.WriteLine("Saldo: " + customer[i].Saldo);
                    }
                }
                else if(menu == 3)
                {
                    check = false;
                }
            }

        }
    }
}