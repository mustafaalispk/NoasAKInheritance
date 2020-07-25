using System;
using System.Collections.Generic;
using System.Text;

namespace NoasAKInheritance.Domain
{
    class Tiger : Animal
    {
        public Tiger(DateTime birthdate, Gender gender)
            // Vi skapar upp här birthdate och Gender
            :base (birthdate, gender)
        {

        }
    }
}
