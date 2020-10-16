using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5___Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;

            Console.WriteLine("Please enter your age");
            userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge >= 18)
            {
                Console.WriteLine("You are an adult.");
                Console.ReadLine();
            }
                

        }
    }
}
