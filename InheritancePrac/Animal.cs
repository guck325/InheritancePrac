using System;
namespace InheritancePrac
{
    public class Animal
    {
        /// <summary>
        /// 나이
        /// </summary>
        /// <value>나이</value>
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다");
        }
    }
}