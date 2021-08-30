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
        static void Main(string[] args)
        {
            Products p = new Products();
            Console.WriteLine(p[2]);
            Console.WriteLine((new Products())[2]);

            Wanted<string> wantedString = new Wanted<string>("스트링");
            Wanted<int> wantedInt = new Wanted<int>(3);
            Wanted<Student> wantedStudent = new Wanted<Student>(new Student());
        }
    }
}
