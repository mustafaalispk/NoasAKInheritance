using System;

namespace NoasAKInheritance.Domain
{
    class NoasArk
    {
        // Här har vi Array av lista med till Animal eller lista med reference till animal 
        private Animal[] animalList;

        private ushort nextAvailableCage;

        // Här vi skapar upp NoasArk, hur många numberOfCages har vi på botten
        // då skapar vi upp här många referenser till här listan---> numberOfCages.
        public NoasArk(ushort numberOfCages)
        {
            animalList = new Animal[numberOfCages];
        }

        // Vi har en method som heter Load(), den ska lasta på ett djur.
        public void Load(Animal animal)
        {            
            animalList[nextAvailableCage++] = animal;
            
        }
    }
}
