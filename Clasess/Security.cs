using System;

namespace KALKULATOR.Classes{
    class Security
    {
        public void CheckPasswod(){
            string password = "";

            do
            {
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
            } while (password != "pa$$w0rd");
        }
    }
}

