using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abctract_Class
{
    abstract class Animal //Định nghĩa 1 lớp trừu tượng
    {
        public string strName;
        public abstract void Sounding(); //Khai báo 1 phương thức trừu tượng bằng từ khoá abstract
    }
    class Duck : Animal //Định nghĩa lớp dẫn xuất hay gọi là kế thừa Animal
    {
        public override void Sounding()
        {
            Console.WriteLine("Cap cap cap...");
        }
    }
    //Định nghĩa lớp Dẫn xuất Dog
    class Dog : Animal
    {
        public override void Sounding()
        {
            Console.WriteLine("Gau gau guau...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // class duck.
            Duck objDuck = new Duck();
            objDuck.strName = "Donald";
            System.Console.WriteLine("Class Duck: {0}", objDuck.strName);
            objDuck.Sounding();

            //class dog. 
            Dog objDog = new Dog();
            objDog.strName = "Pluto";
            System.Console.WriteLine("Class Dog: {0}", objDog.strName);
            objDog.Sounding();

            System.Console.ReadLine();
        }
    }
}
