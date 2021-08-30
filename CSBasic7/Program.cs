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
        class PointClass
        {
            public int x;
            public int y;
            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            //public string testB = "init";

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.testA = "";
            }
            public Point(int x, int y, string a)
            {
                this.x = x;
                this.y = y;
                this.testA = a;
            }
        }

        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
        static void Main(string[] args)
        {
            PointClass pcA = new PointClass(10, 20); //new 키워드를 할 때 공간이 잡히게 된다.
            PointClass pcB = pcA; //pcA가 가리키고 있는 주소값을 가지게 된다.
            pcB.x = 100;
            pcB.y = 200; 
            Console.WriteLine(pcA.x + "/" + pcA.y); // 100/200
            Console.WriteLine(pcB.x + "/" + pcB.y); // 100/200
            Console.WriteLine();

            Point pA = new Point(10, 20); //Point pA를 하는 순간(변수를 선언할 때) 공간이 잡히게 된다.
            Point pB = pA; // pA의 값을 가지게 된다.
            pB.x = 100;
            pB.y = 200;
            Console.WriteLine(pA.x + "/" + pA.y); // 10/20
            Console.WriteLine(pB.x + "/" + pB.y); // 100/200
            Console.WriteLine();

            Point point = new Point(10, 10);
            Point point2 = new Point();
            //point.x = 10;
            //point.y = 10;
            Console.WriteLine(point2.x); //위에서 초기화안하면 오류가 난다.
            Console.WriteLine(point2.y);

            int x = 0;
            int y = 0;
            int vx = 100;
            int vy = 100;
            Console.WriteLine("현재 좌표: (" + x + "," + y + ")");
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + "," + y + ")");

            Console.Write("숫자 입력: ");
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
