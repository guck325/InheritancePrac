using System;

namespace InheritancePrac
{
    public class Dog : Animal
    {
        public string Color { get; set; }



        public void Bark()
        {
            Console.WriteLine("왈왈 짓습니다");
        }

        public void TestB()
        {
           // Private();
            Protected();
            Public();
        }
    }
}