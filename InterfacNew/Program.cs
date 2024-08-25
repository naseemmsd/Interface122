using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNew
{
    public interface IAnimal
    {
        void Speak();
        void Eat();
        

    }
    public class Cat : IAnimal
    {
        public void Speak()
        {

            Console .WriteLine ("Meowwwwwwwww---");
        }
        public void Eat()
        {
            {

                Console.WriteLine("Cats Like Meat");
            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            IAnimal ManoBilli = new Cat();
            ManoBilli.Speak();
            Console.WriteLine();

            ManoBilli.Eat();
            Console.ReadLine();
        }
    }
   
}
