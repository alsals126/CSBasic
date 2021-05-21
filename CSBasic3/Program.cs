using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            // toupper, tolower
            // C#은 문자열(string) 관련된 메소드들의 원본을 건들지 않는다.
            string inputString = "Potato Tomato";
            inputString.ToUpper(); // return POTATO TOMATO
            Console.WriteLine(inputString); // Potato Tomato
            Console.WriteLine(inputString.ToLower()); // potato tomato

            // split
            string foodString = "감자 고구마 토마토 치킨";
            string[] foods = foodString.Split(new char[] { ' ' });
            foreach(var food in foods)
            {
                Console.WriteLine(food);
            }

            string pathString = "C:\\Program Files (x86)\\Common Files\\Oracle\\Java\\javapath;C:\\oraclexe\\app\\oracle\\product\\11.2.0\\server\\bin;%SystemRoot%\\system32;%SystemRoot%;%SystemRoot%\\System32\\Wbem;%SYSTEMROOT%\\System32\\WindowsPowerShell\\v1.0\\;%SYSTEMROOT%\\System32\\OpenSSH\\;C:\\Program Files\\dotnet\\;C:\\Program Files\\nodejs\\;C:\\Program Files\\Microsoft SQL Server\\130\\Tools\\Binn\\;C:\\Program Files\\Microsoft SQL Server\\Client SDK\\ODBC\\170\\Tools\\Binn\\;C:\\Program Files\\Git\\cmd;%JAVA_HOME%\\bin\\;";
            string[] paths = pathString.Split(new char[] { ';' });
            foreach (var path in paths)
                Console.WriteLine(path);

            // trim
            string StrangeInput = " test \n     \n ";
            Console.WriteLine("[" + StrangeInput + "]");
            Console.WriteLine("[" + StrangeInput.Trim() + "]");

            string[] foodsArray = { "감자", "고구마", "토마토" };
            Console.WriteLine(string.Join(",", foodsArray));

            // Thread.Sleep() 메서드
            // 바가 증가하는거, 지렁이게임같은거 만들 수 있다.
            // ncurses 라이브러리를 쓰는것도 괜찮다.
            Console.Clear();
            Console.WriteLine("포맷 중 :  0%  [__________]");
            for(int f=0; f<10; f++)
            {

                Console.SetCursorPosition(0,0);
                Console.Write("포맷 중 :  ");
                Console.Write((f + 1) * 10 + "%  [");
                for (int f2 = 0; f2 < f+1; f2++)
                    Console.Write("#");
                for (int f2 = f+1; f2 < 10; f2++)
                    Console.Write("_");
                Console.Write("]");
                Thread.Sleep(1000);
            }

            int x = 1;
            while(x<50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");
                Thread.Sleep(1000);
                x++;
            }
        }
    }
}