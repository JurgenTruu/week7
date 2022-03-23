using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada eesnimi
            //programm palub kasutajal sisestada numbri 1-3
            //kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnimi tagurpidi
            //kui 2 siis kuvatakse esimest t2hte
            //kui 3 siis kuvatakse kasutaja eesnime pikkust
            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number '1', '2' v6i '3':");
            char userNumber = Convert.ToChar(Console.ReadLine());
            switch (userNumber)
            {
                case '1':
                    UserNumberOne(userName);
                    break;
                case '2':
                    UserNumberTwo(userName);
                    break;
                case '3':
                    UserNumberThree(userName);
                    break;

                    
            }
        }
        public static void UserNumberOne(string userName)
        {
           for(int i = userName.Length - 1; i >= 0; i--)
            {
                Console.Write(userName[i]);
            }
        }
        public static void UserNumberTwo (string userName)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}");
        }
        public static void UserNumberThree (string userName)
        {
            Console.WriteLine($"Sinu eesnimi on {userName.Length} sümbolit pikk.");
        }
    }
}
