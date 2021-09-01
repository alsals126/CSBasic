﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic8
{
    class Program 
    {
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            //인터페이스를 상속받고 이 메서드를 넣으니 오류가 나지 않는다.
            public int CompareTo(object obj)
            {
                //return Price.CompareTo((obj as Product).Price); //가격으로 정렬(오름차순)
                //return -1 * Price.CompareTo((obj as Product).Price); //가격으로 정렬(내림차순)
                //return Name.CompareTo((obj as Product).Name); //이름으로 정렬(오름차순)
                return -1 * Name.CompareTo((obj as Product).Name); //이름으로 정렬(내림차순)
            }

            public override string ToString()
            {
                return Name + ":" + Price + "원";                                                                                                                                           
            }
        }
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마", Price=1500},
                new Product() { Name = "사과", Price = 2400 },
                new Product() { Name = "바나나", Price = 1000 },
                new Product() { Name = "배", Price = 3000 }
            };
            list.Sort();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}