using System;

namespace _05._11._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input size:");

            int size = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[size];

            Console.WriteLine("input names:");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("Do you want to continue (Y/N)? ");

            
               string name = Console.ReadLine();
               Array.Resize(ref names, names.Length + 1);

            
            

            for (int j = 0; j < names.Length; j++)
            {
                Console.Write(names[j] + "");
            }
            
        }   
    }
}       
