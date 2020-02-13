using System;
using static System.Console;

namespace Enemies
{
    /// <summary>
    /// Namespace for types of Enimies.
    /// </summary>
    class Zombie
    {
        public int health;

        /// <summary>
        /// Create a zombie with default health of 0
        /// </summary>
        public Zombie() { health = 0; }

        /// <summary>
        /// Create a zombie with defined health.
        /// </summary>
        /// <param value = "int value to set zombie health to"></param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new System.ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }

    }
}