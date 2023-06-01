using System;

namespace InheritancePrac
{
    /// <summary>
    /// 고양이 클래스
    /// </summary>
    public class Cat
    {
        /// <summary>
        /// 고양이 나이
        /// </summary>
        /// <value>나이</value>
        public int Age { get; set; }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다");
        }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }
    }
}