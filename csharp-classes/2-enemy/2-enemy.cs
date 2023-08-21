using System;
using System.Collections.Generic;

namespace Enemies
{
    /// new class Zombie
    public class Zombie
    {
        /// Public field to store the health of the Zombie.
        public int health;


        /// Public constructor to initialize the Zombie object with default values.
        public Zombie()
        {
            health = 0;
        }

        /// Constructor to initialize the Zombie
        public Zombie(int value)
        {

            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
    }
}
