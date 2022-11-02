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

        public void algorithm()
        {
            for (int i = 1; i < n; i++)//funtion untuk logika pada algorithm
            {
                int temp = fad[i];
                int j = i  -1;
                while(j>=0 && fad[j] > temp)
                {
                    fad[j + 1] = fad[j];
                    j--;
                }
                    fad[j+1] = temp;
            }
        }

        public void algorithm2()
        {
            
            int high = n - 1;//variabel untuk high
            int low = 0;//variabel untuk low
            int mid = (low + high) / 2;//variabel untuk mid
           

            int i = low;//variabel untuk i
            int j = mid + 1;//variabel untuk j
            int k = low;//variabel untuk k
            if (fad[i]<=fad[j])//function untuk array[i] <= array[j]
            {

                fad[i] = k;
                i++;
                j++;
                k++;

            }
            if (j > high)
            {
                fad[j] = k;
                j++;
                k++;
            }
            if (i > mid)
            {
                fad[i] = k;
                i++;
                k++;
            }
        }
        static void Main(string[] args)
        {
            Program exercise = new Program();
            exercise.read();
            exercise.algorithm();
            exercise.display();
            Console.Read();
        }
    }
}
