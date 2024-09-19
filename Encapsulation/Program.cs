using System;
using System.Reflection.Metadata;

namespace Encapsulation
{
    //class lingkaran dengan enkapsulasi
    public class Lingkaran
    {
        //Privasi field untuk menyimpan nilai radius
        private double radius;

        //public property untuk mengakses dan mengatur radius
        public double Radius { 
            get { 
                return radius; 
            } 
            set { 
                if(value < 0)
                {
                    throw new ArgumentException("Radius harus > 0");
                }
                radius = value; 
            } 
        }

        //method buat hitung luas lingkaran
        public double Luas()
        {
            return 3.14 * radius * radius;
        }
    }

    public class Tabung
    {
        private Lingkaran lingkaran;
        private double tinggi;

        public Tabung(double radius, double tinggi)
        {
            lingkaran = new Lingkaran();
            lingkaran.Radius = radius;
            this.tinggi = tinggi;
        }

        public double Volume()
        {
            return this.lingkaran.Luas() * tinggi;
        }

        static void Main(string[] args)
        {
            try
            {
                Tabung tabung = new Tabung(-5, 10);
                Console.WriteLine(tabung.Volume());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }

}