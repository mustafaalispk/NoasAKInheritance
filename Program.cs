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
               
            Tiger tiger = new Tiger(birthdate: new DateTime(2010, 11, 10), gender: Gender.Female);
          
            Panda panda = new Panda(birthdate: new DateTime(2016, 1, 1), gender: Gender.Male);              

            Rabbit rabbit = new Rabbit(birthdate: new DateTime(2016, 1, 1), gender: Gender.Male);

            //noasArk.Load(tiger);

            //noasArk.Load(panda);

            //noasArk.Load(rabbit);

            //noasArk.RollCall();

            //tiger.Eat();

            rabbit.Eat();

            // Här vi anrppas Speak() för att kolla beetende på den.
            //animal.Speak();
            //    bool shouldNotExit = true;

            //    while (shouldNotExit)
            //    {
            //        WriteLine("1. Show registry"); ;

            //        WriteLine("2. Exit");

            //        ConsoleKeyInfo keyPressed = ReadKey(true);

            //        Clear();

            //        switch (keyPressed.Key)
            //        {
            //            case ConsoleKey.D1:
            //            case ConsoleKey.NumPad1:

            //                break;

            //            case ConsoleKey.D2:
            //            case ConsoleKey.NumPad2:

            //                break;
            //        }

            //        Clear();

            //    }
        }
    }
}

