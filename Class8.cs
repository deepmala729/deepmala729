using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class8
    {
        public static void Main9()
        {
            int age;
            Console.Write("\n\n");


            Console.Write("Input the age of the candidate : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.Write(" not eligible to your vote.\n");

            }
            else if(age >= 60)
                   {
                Console.Write("senior citizen\n\n");
            }
            else
            {
                Console.Write("eligible for vote\n\n");
            }

        }

    }

    



}
    

