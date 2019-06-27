using System;

namespace Interface_Class
{
    public interface IAnimal
    {
      void run();  
    }

    public class Dog : IAnimal{
        public void run(){
            Console.WriteLine("the dog runs");
        }
    }

    public class Cat : IAnimal{
        public void run(){
            Console.WriteLine("the cat runs away and meows");
        }
    }

    class Program{
        static void Main(string[]args){
            IAnimal[] animals= new IAnimal[3];
            animals[0]=new Cat();
            animals[1]=new Dog();
            animals[2]=new Cat();

            foreach (IAnimal a in animals){
                a.run();
            }
        }
    }
}
