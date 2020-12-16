using System;

namespace Enemies
{
    /// <summary>Defines a zombie.</summary>
    public class Zombie
    {
        // Private field health.
        private int health;

        // Private field name.
        private string name = "(No name)";

        /// <summary>Public property Name that gets and sets name.</summary>
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

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

        /// <summary>Returns the health of the Zombie instance.</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}