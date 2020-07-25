using System;
using static System.Console;

namespace NoasAKInheritance.Domain
{
    class Animal
    {
        public DateTime Birthdate { get; }

        public Gender Gender { get; }  

        public Animal( DateTime birthdate, Gender gender)
        {
            Birthdate = birthdate;
            Gender = gender;            
        }
        public void Speak()
        {
            WriteLine($"I'm a {Gender} and my birthdate is {Birthdate}");
        }
    }
   
    // Vi har skapat upp en ny typ Gender som innehåller Male eller Female
    enum Gender
    {
        Female,
        Male
    }
}
