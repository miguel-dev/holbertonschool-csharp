using System;

namespace Enemies
{
    /// <summary>Defines a zombie.</summary>
    public class Zombie
    {
        // Gets or sets the health.
        private int health {get; set;}

        /// <summary>Initializes a new instance of Zombie.</summary>
        public Zombie ()
        {
            health = 0;
        }

        /// <summary>Initializes a new instance of Zombie.</summary>
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

        /// <summary>Returns the health of the Zombie instance</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}