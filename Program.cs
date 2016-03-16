using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public void Main(string[] args)
        {
         	Console.WriteLine("Digite o valor maximo de termos para a serie Fibonacci");
			int n = Convert.ToInt32(Console.ReadLine());

			for(int i = 0; i < n; i++)
			   Console.Write(Fibonacci(i) + " ");

			Console.ReadLine();            	
        }    

        static int Fibonacci(int n) 
        {
        	if (n == 0 || n == 1)
        	   return n;
        	else 
        	   return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
