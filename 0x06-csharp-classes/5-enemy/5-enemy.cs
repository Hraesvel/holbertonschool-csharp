using System;
using static System.Console;


namespace Enemies
{

    /// <summary>
    /// Namespace for types of Enimies.
    /// </summary>
    class Zombie
    {
        private int health;
        private string name = "(No name)";

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

        /// <summary>
        /// Get the current health of a zombies instance.
        /// </summary>
        /// <returns>
        /// int value 
        ///</returns>
        public int GetHealth() { return health; }

        /// <summary>
        /// Get Or Set the name of a zombie instance.
        /// </summary>
        /// <value> The Name property gets/sets the value of the string field, name</value>
        public string Name {
            get => name;
            set => name = value;
        }

        override public string ToString(){
            return string.Format("Zombie Name: {0} / Total Health: {1}",
            this.Name,
            this.GetHealth()
            );
        }
    }
}