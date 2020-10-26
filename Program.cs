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

                Console.WriteLine("Please enter your age.");
                userAge = Convert.ToInt32(Console.ReadLine());

                if (userAge >= 2){
            
                    Console.WriteLine("You are an infant.");
                    Console.ReadLine();
                }


                else (userAge >= 5)
                {
                    Console.WriteLine("You are a toddler.");
                    Console.ReadLine();
                }


                if(userAge >= 12){

                    Console.WriteLine("You are a kid.");
                    Console.ReadLine();
                }


                else (userAge >= 17){
            
                    Console.WriteLine("You are a teen.");
                    Console.ReadLine();
                };

                if (userAge >= 18){ 
            
                    Console.WriteLine("You are an adult.");
                    Console.ReadLine();
                }

                else (userAge >= 40){ 
            
                    Console.WriteLine("You are middle-aged.");
                    Console.ReadLine();
                };

                if (userAge >= 60){ 

                    Console.WriteLine("You are a senior.");
                    Console.ReadLine();
                }

                else (userAge <= 99) {

                    Console.WriteLine("You are ancient!");
                    Console.ReadLine();
                };

            
        }
    }
}
