using System;
using static System.Console;

namespace NoasAKInheritance.Domain
{
    abstract class Animal
    {
        public DateTime Birthdate { get; }

        public Gender Gender { get; }  

        public Animal( DateTime birthdate, Gender gender)
        {
            Birthdate = birthdate;
            Gender = gender;            
        }
        // I virtual kan ge standard beetende men vi kan overrida den i ärvande klassen.
        // I abstract metoden, vi ger inte standard beetende men vi måste overrida den.
        public abstract void Speak();

        public virtual void Eat()
        {
            WriteLine("Animal is eating....");
        }
    }
   
    // Vi har skapat upp en ny typ Gender som innehåller Male eller Female
    enum Gender
    {
        Female,
        Male
    }
}
