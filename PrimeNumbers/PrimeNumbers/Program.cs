using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace PrimeNumbers
{
    class Program
    {
       static bool PrimeNumbers(int n)
        {
            bool isprime = true;
            for (int i = 2; i < 10; i++)
            {
                int remaining=n % i;
                if (n!=i && remaining==0)
                {
                    isprime =false;
                    return isprime;
                     }
            }
            return isprime;
        }
        public static void AskForNumbers()
        {
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("Give number: \n");
                int number = Convert.ToInt32(Console.ReadLine());
                PrimeNumbers(number);
                if (PrimeNumbers(number))//Εαν επιστρέψει true
                {
                    Console.WriteLine("Prime Number\n");
                }
                else
                {
                    Console.WriteLine("NOT!!!\n");
                }

                Console.WriteLine("If you want to stop type:'STOP' \n");
                var option = Console.ReadLine();
                if (option == "STOP" || option == "stop" || option == "Stop")
                {
                    stop = true;
                    Console.WriteLine("Bye\n");
                    //return;
                }
            }         
        }
        static void Main(string[] args)
        {
            AskForNumbers();
        }
    }
}
