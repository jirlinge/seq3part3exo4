using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int tries = 0;
            int nb = random.Next(1,51);
            Console.WriteLine("devinez le nombre entre 1 et 50 !");
            int nbUser = Convert.ToInt32(Console.ReadLine());
            tries++;
          

            while (nbUser>nb){
                Console.WriteLine($"c'est plus petit que {nbUser}, vous avez fait {tries} tentatives ! Devinez à nouveau");
                nbUser = Convert.ToInt32(Console.ReadLine());
                tries++;
               
            }

            while (nbUser < nb)
            {
                Console.WriteLine($"c'est plus grand que {nbUser}, vous avez fait {tries} tentatives ! Devinez à nouveau !");
                nbUser = Convert.ToInt32(Console.ReadLine());
                tries++;
                


            }

            while (nbUser != nb)
            {
                Console.WriteLine($"encore raté :/ ce n'est pas {nbUser} , vous avez fait {tries} tentatives devinez à nouveau");
                nbUser = Convert.ToInt32(Console.ReadLine());
                tries++;
                
            }

            Console.WriteLine($"C'est pas trop tot ! vous avez trouvé en {tries} tentatives,  Félicitation !");
        }
    }
}
