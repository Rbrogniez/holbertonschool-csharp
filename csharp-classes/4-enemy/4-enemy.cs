using System;


namespace Enemies
{
    /// new class Zombie
    public class Zombie
    {
        /// private field to store the health of the Zombie.
        private int health;
        private string name = "(No name)";

        /// private field to store the Name of the Zombie
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
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

        /// Returns the health of the Zombie
        public int GetHealth()
        {
            return health;
        }
    }
}
