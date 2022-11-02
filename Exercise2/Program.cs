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
            Console.WriteLine("");
            Console.WriteLine("========================");    
            Console.WriteLine(" Masukkan Element Array ");
            Console.WriteLine("========================");

            for(int i=0; i < n; i++)//funtion untuk display array
            {
                Console.WriteLine("<"+ (i+1)+">");
                string s1 = Console.ReadLine(); 
                fad[i] = Int32.Parse(s1);
            }

        }

        public void display()
        {
            //Menampilkan array yang telah tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" Element Array Telah Tersusun ");
            Console.WriteLine("-----------------------------");
            for (int j =0; j <n; j++)
            {
                Console.WriteLine(fad[j]);
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
        }
    }
}
