using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        string var = "테스트";
        static void Main(string[] args)
        {
            var name = "오" + "정" + "민";
            Console.Write("개행이 안되는 요놈");
            Console.WriteLine("개행이 되는 요놈");

            //string do = "변수명 안되는거";
            //string var = "변수명 안되는거";
            //var 273alpha = "숫자이름";
            var 한글변수명 = "된다";
            //var 🧡 = "안됨";

            // 인라인 주석
            /*
             여러줄 주석
             */

            // 강제 형변환
            long longNumber = 2147483647L + 2122500000L;
            int intNumber = (int) longNumber; // 의미 : 컴파일러야 여기에 대한 피해는 내가 책임질게
                                              // 감당할만한 범위안에 값을 넣으면 똑바로 나온다. 
                                              // => 강제 형변환을 했을 때 무조건 피해가 오는 것은 아니다
            Console.WriteLine(intNumber);

            // 자동 형변환
            intNumber = 100;
            longNumber = intNumber;
            Console.WriteLine(longNumber);

            // int -> long, float, double;
            // long -> float, double; ★
            // char -> int, long, float, double;
            // float -> double

            // Widening Casting 자동 형변환
            // byte -> short -> char -> int -> long -> float -> double

            // Narrowing Casting 강제 형변환 (큰 쪽에서 작은 쪽)
            // double -> float -> long -> int -> char -> short -> byte

            // int.Parse() / long.Parse()
            // float.Parse() / double.Parse()
            string numberString = "52273";
            intNumber = int.Parse(numberString); // parse : 변환한다
            Console.WriteLine(intNumber);

            try
            {
                Console.WriteLine(int.Parse("52.273"));
                Console.WriteLine(int.Parse("오십일"));
                Console.WriteLine(int.Parse("Seven"));
            }catch(FormatException e)
            {
                Console.WriteLine("숫자로 변경할 수 없습니다.");
            }catch(Exception e)
            {
                Console.WriteLine("알 수 없는 오류 : " + e.Message);
            }

            // 다른 자료형을 문자열로 변환
            Console.WriteLine((10).ToString());
            Console.WriteLine((52.237).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            // 반올림하고 잘라서 나옴
            double number = 52.273103;
            Console.WriteLine(number.ToString("0.0")); //52.3
            Console.WriteLine(number.ToString("0.00")); //52.27
            Console.WriteLine(number.ToString("0.000"));
            Console.WriteLine(number.ToString("0.0000"));

            Console.WriteLine(52 + "");
            Console.WriteLine(52 + 3 + "");//55
            Console.WriteLine("" + 52 + 3);//523
            Console.WriteLine(52 + "" + 3);//523

            number = 273;
            string outputA = number + "";
            Console.WriteLine(number);

            char ch = 'a';
            string outputB = ch + "";
            //string outputC = ch;
            //string outputD = 3;
            Console.WriteLine(outputB);

            // string to bool 변환  (대소문자 상관없이 바꿔준다)
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("trUe"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));

            // 최댓값 최솟값은 상수로!
            Console.WriteLine(-1 * int.MaxValue);
            //Console.WriteLine(-1 * int.MinValue); 
            Console.WriteLine(-1L * int.MinValue);
            


        }
    }
}
