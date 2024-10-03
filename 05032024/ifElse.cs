using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Estrutura de If");

            int x;

            x = Convert.ToInt32(Console.ReadLine());
            if (x >= 18)
            {
                if (x >= 60)
                {
                    Console.WriteLine("idoso");

                }
                else
                {
                    Console.WriteLine("maior de idade");

                }
            }
            else
            {
                Console.WriteLine("criança");

            }Console.ReadKey();
        
        } 
            
        

    }
}
