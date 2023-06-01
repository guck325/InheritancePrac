﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
            //Dogs처럼 객체가 여러개가 있다는 것을 알려주는 게 좋다

            foreach ( var item in Dogs )
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            foreach ( var item in Cats )
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
        }
    }
}
