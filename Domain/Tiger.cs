using System;
using static System.Console;
namespace NoasAKInheritance.Domain
{
    class Tiger : Animal
    {
        public byte StripeCount { get; }
        public Tiger(byte stripeCount,DateTime birthdate, Gender gender)
            // Vi skapar upp här birthdate och Gender
            :base (birthdate, gender)
        {
            StripeCount = stripeCount;
        }
        public override void Speak()
        {
          WriteLine($"I'm a {Gender} tiger and my birthdate is {Birthdate}");
        }


    }
}
