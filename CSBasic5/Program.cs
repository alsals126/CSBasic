using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiClass ml = new MultiClass();
            Console.WriteLine(ml.Multi(52, 273));
            Console.WriteLine(ml.Multi(103, 32));
            ml.Print();
            Console.WriteLine(ml.Sum(1, 100));
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(273));
        }
        class MyMath
        {
            public static int Abs(int input)
            {
                return (input < 0) ? -input : input;-
            }
        }

        class MultiClass
        {
            public int Multi(int x, int y)
            {
                return x * y;
            }
            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출");
            }
            public int Sum(int min, int max)
            {
                int output = 0;
                for(int i = min; i<=max; i++)
                {
                    output += i;
                }
                return output;
            }
        }
    }
}
