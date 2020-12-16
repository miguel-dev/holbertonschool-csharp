using System;

namespace Enemies
{
    /// <summary>Defines a zombie.</summary>
    public class Zombie
    {
        /// <summary>Gets or sets the health.</summary>
        public int health {get; set;}

        /// <summary>Initializes a new instance of Zombie</summary>
        public Zombie ()
        {
            health = 0;
        }
    }
}