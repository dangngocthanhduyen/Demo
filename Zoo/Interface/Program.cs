using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface itfFly //khai báo interface cho việc bay
    {
        void Fly();
    }
    public interface itfRun //khai báo interface cho việc chạy
    {
        void Run();
    }
    public class classBird : itfFly, itfRun //Lớp classBird được thừa kế 2 interfaces itfFly, itfRun
    {
        public void Fly()
        {
            Console.WriteLine("Bird flies by 2 wings");
        }
        public void Run()
        {
            Console.WriteLine("Bird runs by 2 legs");
        }
    }
    public class classPlane : itfFly, itfRun //Lớp classPlane thừa kế 2 interfaces itfFly, itfRun
    {
        public void Fly()
        {
            Console.WriteLine("The plane flies by engine");
        }
        public void Run()
        {
            Console.WriteLine("The plane runs by the wheel");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            classBird objBird = new classBird();
            objBird.Fly();
            objBird.Run();

            classPlane objPlane = new classPlane();
            objPlane.Fly();
            objPlane.Run();

            List < itfFly > listfly= new List<itfFly>();
            listfly.Add(objBird);
            listfly.Add(objPlane);
            foreach(var item in listfly)
            {
                item.Fly();
            }

            System.Console.ReadLine();
        }
    }
}
