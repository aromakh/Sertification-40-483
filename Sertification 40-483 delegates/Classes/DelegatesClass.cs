using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sertification_40_483_delegates
{
    class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("Antient voice");
        }
    }

    class Cat : Animal
    {
        public override void Voice()
        {
            Console.Write("Miav");
        }
    }

    class CrezyCat : Cat
    {
        public override void Voice()
        {
            Console.Write("!!!Miaaaav!!!");
        }
    }

    delegate Animal TestDelegate(Cat cat);
    static class DelegatesClass
    {
        public static void Test()
        {
            TestDelegate testDelegate = CatAction;
            testDelegate += AnimalAction;
            testDelegate(new CrezyCat());
        }

        public static Cat CatAction(Cat cat)
        {
            cat.Voice();
            return cat;
        }

        public static Animal AnimalAction(Animal animal)
        {
            animal.Voice();
            return animal;
        }
    }


}
