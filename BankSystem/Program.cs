using System;

namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User C1 = new User()
            {
                ID = 1,
                Name = "Tim",
                UserName = "Tim1",
                Password = "1234",
                Currency = 3000

            };

            User C2 = new User()
            {
                ID = 2,
                Name = "Elin",
                UserName = "Elin1",
                Password = "4321",
                Currency = 4000

            };

            User C3 = new User()
            {
                ID = 3,
                Name = "Dennis",
                UserName = "Dennis1",
                Password = "5678",
                Currency = 5000

            };

            User C4 = new User()
            {
                ID = 4,
                Name = "Anton",
                UserName = "Anton1",
                Password = "8765",
                Currency = 6000

            };

           

        }
    }
}
