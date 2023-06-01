using System;
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

            Dog dog= new Dog();
            dog.Public();
            //dog.Protected();
            //dog.Privvate();

            List<Animal> Animals = new List<Animal>() { new Dog(), new Dog(), new Dog(), new Cat(), new Cat(), new Cat() };

           // List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            //List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            //Dogs처럼 객체가 여러개가 있다는 것을 알려주는 게 좋다
            //List<Object> Things = new List<Object>() { new Dog(), new Dog(), new Dog(), new Dog(), new Dog(), new Dog() };  이런식으로 가능


            foreach ( var item in Animals )
            {
                item.Eat();
                item.Sleep();

                var _dog = item as Dog;
                if(_dog != null ) { _dog.Bark(); }

                var _cat = item as Cat;
                if (_cat != null) { _cat.Meow(); }

                if (item is Dog)
                {
                    //var _dog = (Dog)item;
                    //_dog.Bark(); //여러개 호출

                    ((Dog)item).Bark();
                }else if(item is Cat) 
                {

                    ((Cat)item).Meow(); //한번 호출
                }

                
            }
            
        }
    }
}
