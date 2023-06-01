using System;

namespace InheritancePrac
{
    /// <summary>
    /// 고양이 클래스
    /// </summary>
    public class Cat : Animal
    {
        public Cat()
        {
        }

        public Cat(int age) : base(age)
        {
        }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다");
        }

    }
}