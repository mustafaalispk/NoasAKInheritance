using NoasAKInheritance.Domain;
using System;
using static System.Console;


namespace NoasAKInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            NoasArk noasArk = new NoasArk(numberOfCages: 20);
               
            Tiger tiger = new Tiger(stripeCount: 10, birthdate: new DateTime(2010, 11, 10), gender: Gender.Female);
          
            Panda panda = new Panda(birthdate: new DateTime(2016, 1, 1), gender: Gender.Male);              

            Rabbit rabbit = new Rabbit(birthdate: new DateTime(2016, 1, 1), gender: Gender.Male);

            noasArk.Load(tiger);

            noasArk.Load(panda);

            noasArk.Load(rabbit);

            noasArk.RollCall();

            tiger.Eat();

            rabbit.Eat();

        }
    }
}

