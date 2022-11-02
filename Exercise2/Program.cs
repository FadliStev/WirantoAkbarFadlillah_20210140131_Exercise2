using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        int[] fad = new int[24];//create new array
        int n;//add variable

        public void read()//menambahkan method untuk element array
        {
            while (true)//menambahkan function  
            {
                Console.WriteLine("Masukkan banyaknya element/data pada array : ");
                string s = Console.ReadLine();  
                n = Int32.Parse(s);
                if (n <= 20)//menambahkan function
                    break;
                else
                    Console.WriteLine("\n Element yang diamsukkan tidak bisa lebih dari 24");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
