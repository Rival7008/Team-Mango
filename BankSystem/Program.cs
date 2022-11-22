using System;

namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer()
            {
                ID = 1,
                Name = "Tim",
                UserName = "Tim1",
                Password = "1234",
                Currency = 3000

            };

            Customer C2 = new Customer()
            {
                ID = 2,
                Name = "Elin",
                UserName = "Elin1",
                Password = "4321",
                Currency = 4000

            };

            Customer C3 = new Customer()
            {
                ID = 3,
                Name = "Dennis",
                UserName = "Dennis1",
                Password = "5678",
                Currency = 5000

            };

            Customer C4 = new Customer()
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
