﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Polymorphism
{
    abstract class Animal : IAnimal
    {
        //poate fi extinsa folosind override in clasele derivate
        public virtual void Walk()
        {
            Console.WriteLine("On 4 legs");
        }

        //Metodele abstracte trebuie obligatoriu implementate in clasele derivate
        public abstract void Speak();

        public void Eat()
        {
            Console.WriteLine("I eat what I want!");
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //clasa derivata
        //sealed specifica faptul ca acesta clasa nu poate fi clasa de baza
        sealed class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Miau");
            }
        }

        class Duck : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Quack");
            }

            //metoda nu mai este virtuala pentru clasele care mostenesc din Duck
            public sealed override void Walk()
            {
                Console.WriteLine("On 2 legs");
                //daca vrem sa apelam si metoda de baza folosim base
                //base.Walk();
            }

            //nu e comportament polimorfic
            //ascunde metoda din clasa de baza
            public new void Eat()
            {
                Console.WriteLine("I eat what ducks eat");
            }

            //overloading - 2 metode cu aceeasi denumire
            public void Eat(string food)
            {
                Console.WriteLine("Ducks eat:{0}", food);
            }
        }


    }
}
