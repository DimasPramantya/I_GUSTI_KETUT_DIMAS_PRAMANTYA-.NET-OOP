using System;

namespace UserBootcamp
{
    class User
    {
        static void Main(string[] args)
        {
            UserBootcamp11 user = new UserBootcamp11();
            user.NamaUser = "Surya";
            Console.WriteLine(user.NamaUser);
        }
    }
    public class UserBootcamp11
    {
        public string nama { get; set; }
        string role;
        int emoney;

        public string NamaUser
        {
            get { return nama; }
            set { nama = value; }
        }

        public string RoleUser
        {
            get { return role; }
            set { role = value; }
        }

        public int Emoney { 
            get { return emoney; } 
            set { emoney = value; } 
        }
    }
}