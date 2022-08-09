using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfAnynumbers
{
    
    
    
    public class AverageClass
    {
        public double average(int[] a, int m)
        {
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < m; i++)
            {
                sum += a[i];
            }
             avg = sum / m;
            return avg;

        }

        public double avgParam(string s, params int[] list)
        {
            double avg = 0;
            int total = 0;
            for (int i = 0; i < list.Length; i++)
                total += list[i];
            avg = total / list.Length;
            return avg;

        }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int m;
            //Console.WriteLine("Enter the Number of Terms in the Array ");
            //m = int.Parse(Console.ReadLine());
            //int[] a = new int[m];
            //Console.WriteLine("Enter the Array Elements ");
            //for (int i = 0; i < m; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            
            //Console.WriteLine("Average is : ");
            //AverageClass avg = new AverageClass();
            //Console.WriteLine(avg.average(a,m));


            //Console.WriteLine(avg.avgParam(1, 2, 3, 4, 5));



            Console.ReadKey();
        }
    }




}
