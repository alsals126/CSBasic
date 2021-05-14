using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 52, 172, 13, 13, 103 };
            intArray[2] = 0;
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);
            Console.WriteLine(intArray.Length);

            int[] intArray2 = new int[1000];
            Console.WriteLine(intArray2[0]);
            Console.WriteLine(intArray2[999]);

            int i = 0;
            int[] intArray3 = { 52, 273, 32, 65, 103 };
            while (i < intArray3.Length)
            {
                Console.WriteLine(i + "번째 출력:" + intArray3[i]);
                i++;
            }

            string input;
            do
            {
                Console.Write("입력(exit를 입력하면 종료):");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("go 공지사항");
                        break;
                    case "2":
                        Console.WriteLine("go 오늘의 점심");
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다");
                        break;
                }
            } while (input != "exit");

            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            //for를 쓰고 tab 2번 누르기 => 자동완성
            foreach (var item in array)// 타입을 쓸 필요가 없다. => var 사용
            {
                Console.WriteLine(item);
            }

            //별찍기1
            for(i = 0; i<10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");
                Console.WriteLine("");
                // Console.Write("\n");
            }
            //별찍기2
            for(i=0; i<10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                    Console.Write(' ');
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.Write('\n');
            }
        }
    }
}