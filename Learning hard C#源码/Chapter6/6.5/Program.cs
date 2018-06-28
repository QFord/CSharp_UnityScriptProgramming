using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClassVsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public abstract class Animal
    {
        public void EatFood()
        {
            // eat some food
        }
        public void Walk()
        {
            // walk
        }
    }

    public interface IAnimalShow
    {
        void Show();
    }

    public class Dog : Animal
    {
        
    }

    public class SpecialDog : Animal, IAnimalShow
    {
        public void Show()
        { 
        }
    }

}
