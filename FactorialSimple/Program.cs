using System;

namespace FactorialSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Number");
            int Usernum = Int32.Parse(Console.ReadLine());
            int Factnum = 1;
            for(int i=1; i<=Usernum; i++)
            {



                Factnum = Factnum * i;



            }
            Console.WriteLine("Your Provided  Factorial number {0}, and its Factorial is {1}", Usernum, Factnum);


        }
    }
}
