using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Animal
    {
        public int Age { get; set; }
        public Animal() { this.Age = 0; }
        public void Eat() { Console.WriteLine("냠냠 먹습니다"); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다"); }
    }
    class Dog : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
    }
    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }
    class Program
    {
        abstract class AbstractParent
        {
            public abstract void Test();
        }
        class AbstractChild : AbstractParent
        {
            public override void Test() { } // new하면 안되고, override 키워드를 넣어야한다.
        }

        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }

            // [자바와 큰 차이]
            // 자식에서 오버라이드를 할 때에는(오버라이드를 당할 때) virtual이라는 키워드를 붙여준다.
            /*
            public virtual void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
            */
        }
        class Child : Parent
        {
            public new string variable = "shadowing"; // new를 쓰면 안쓸때와 달리 초록색밑줄이 안나타난다. ('하이딩'하겠다고 선언)
            public new void Method() //하이딩 => C#에서는 오버라이딩할때는 표시를 한다
            {
                Console.WriteLine("자식의 메서드");
            }
            
            // [자바와 큰 차이]
            // 오버라이드 할 때 override라는 키워드를 붙인다. => 오버라이드하고 싶은 것만 허용한다는 장점? (부분적으로 허용)
            /*
            public override void Method() //하이딩 => C#에서는 오버라이딩할때는 표시를 한다
            {
                Console.WriteLine("자식의 메서드");
            }
            */
        }
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();

            //Console.WriteLine((new Child()).variable);
            //Console.WriteLine(((Parent)(new Child())).variable);
            /*
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Cat(), new Dog()
            };
            foreach(var item in Animals)
            {
                item.Eat();
                item.Sleep();
                ((Cat)item).Meow();
            }
            */
        }
    }
}
