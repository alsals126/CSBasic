using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{
    class Products
    {
        private List<string> products = new List<string>();
        public Products()
        {
            products.Add("짜장면");
            products.Add("짬뽕");
            products.Add("탕수육");
            products.Add("마파두부");
            products.Add("나가사키짬뽕");
            products.Add("꽃빵");
        }
        public string this[int i]
        {
            get { return products[i]; }
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }

    class Wanted<T>
        //where T : Student //Student클래스만 사용할 수 있게 함
    {
        public T Value;
        public Wanted(T value)
        {
            this.Value = value;
        }
    }

    class Student { }
    class Program
    {
        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int vx = 100;
            int vy = 100;
            Console.WriteLine("현재 좌표: (" + x + "," + y + ")");
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + "," + y + ")");

            Console.WriteLine("숫자 입력: ");
            int output = int.MinValue; //사용자가 적지 않을 숫자로 초기화한다.
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("입력한 숫자: " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요!" + output);
            }

            Products p = new Products();
            Console.WriteLine(p[2]);
            Console.WriteLine((new Products())[2]);

            Wanted<string> wantedString = new Wanted<string>("스트링");
            Wanted<int> wantedInt = new Wanted<int>(3);
            Wanted<Student> wantedStudent = new Wanted<Student>(new Student());
        }
    }
}
