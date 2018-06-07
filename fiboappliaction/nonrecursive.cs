using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiboappliaction
{
    class nonrecursive
    {
        static void Main(string[] args)
        {
            long fiboinput,first=0,second=1,third=0;
            Console.WriteLine("enter the number");
            fiboinput = long.Parse(Console.ReadLine());
            Console.WriteLine("0 1");
            for(int fibo=2;fibo<=fiboinput;fibo++)
            {
                third = first + second;
                first = second;
                second = third;
                Console.WriteLine(third);
            }
            Console.ReadKey();  
        }
    }
}
