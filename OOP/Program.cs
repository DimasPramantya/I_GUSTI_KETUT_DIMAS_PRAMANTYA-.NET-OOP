using System;


namespace UserManagement
{
    class User
    {
        //atribut
        string nama = "William";
        string role = "CEO";
        int emoney = 1000000000;

        //method
        public void UserDetail()
        {
            System.Console.WriteLine("ini detail usernya");
        }

        //membuat object
        static void Main(string[] args)
        {
            //kelas itu merupakan blueprint dari object
            User user = new User();
            user.UserDetail();
            System.Console.WriteLine("nama " + user.nama);
            System.Console.WriteLine("role " + user.role);
            System.Console.WriteLine("E-money " + user.emoney);
        }
    }
}
