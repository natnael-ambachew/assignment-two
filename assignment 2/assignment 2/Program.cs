using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many course you take");
            int course = int.Parse(Console.ReadLine());
            for (int i = 0; i < course; i++)
            {
                Console.WriteLine("enter mark");
                int mark = int.Parse(Console.ReadLine());
                if (mark >= 90 && mark <= 100)
                {
                    Console.WriteLine("Grade A, great");
                }
                if (mark >= 75 && mark <90)
                {
                    Console.WriteLine("Grade b, good");
                }
                if (mark >= 50 && mark <75)
                {
                    Console.WriteLine("Grade c ,not good");
                }
                if (mark >= 0 && mark < 50)
                {
                    Console.WriteLine("Grade f, bad");
                }

            }

            }
        }
}
