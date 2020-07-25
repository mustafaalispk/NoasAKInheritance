﻿using System;
using static System.Console;
namespace NoasAKInheritance.Domain
{
    class Panda : Animal
    {
        public Panda(DateTime birthdate, Gender gender)
            :base (birthdate, gender)
        {

        }
        public override void Speak()
        {
            WriteLine($"I'm a {Gender} panda and my birthdate is {Birthdate}");
        }
    }
   
}
