using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DesignPattern
{
    interface Sound
    {
        void Make();
    }

    interface Eat
    {
        void EatFood();
    }

    abstract class Animal : Sound
    {
        private bool isCute = true;
        public abstract void GetAnimal();

        public abstract void Make();

    }

    class Dog : Animal, Eat
    {
        public override void GetAnimal()
        {
            Console.WriteLine("This animal is Dog");
            Buddys();
            EatFood();
            Make();
        }

        public void Buddys()
        {
            Console.WriteLine("I have buddys");
        }

        public void EatFood()
        {
            Console.WriteLine("I eat meat and vegtables ");
        }

        public override void Make()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal, Eat
    {
        public override void GetAnimal()
        {
            Console.WriteLine("This animal is Cat");
            Organ();
            EatFood();
            Make();
        }

        public void Organ()
        {
            Console.WriteLine("I have mustache");
        }
        public void EatFood()
        {
            Console.WriteLine("I eat meat");
        }
        public override void Make()
        {
            Console.WriteLine("Meow");
        }
        public virtual void Bath() { }
    }

    class FlowerCat : Cat
    {
        public override void Bath()
        {

        }
    }
}
