﻿using System;
using static System.Console;
namespace NoasAKInheritance.Domain
{
    class Rabbit : Animal
    {
        public Rabbit(DateTime birthdate, Gender gender)
            :base (birthdate, gender)
        {

        }

        public override void Speak()
        {
            WriteLine($"I'm a {Gender} rabbit and my birthdate is {Birthdate}");
        }

        public override void Eat()
        {
            base.Eat();

            WriteLine("Eating a carrot");
           
        }
    }
}
