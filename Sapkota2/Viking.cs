


using System;

namespace VikingNS
{
    /// <summary>
    /// Represents an individual Viking and its current state.
    /// </summary>
    public class Viking : IView
    {
        // Auto-properties
        public string Name { get; set; }
        public Global.Status Status { get; set; }
        public int Health { get; set; }
        public Global.Weapon Weapon { get; set; }
        public bool Shield { get; set; }

        // Default / Parameterized constructor
        public Viking(
            string name = "Bjorn",
            Global.Status status = Global.Status.KARL,
            int health = 150,
            Global.Weapon weapon = Global.Weapon.AXE,
            bool shield = false)
        {
            Name = name;
            Status = status;
            Health = health;
            Weapon = weapon;
            Shield = shield;
        }

        // Copy constructor
        public Viking(Viking other)
        {
            Name = other.Name;
            Status = other.Status;
            Health = other.Health;
            Weapon = other.Weapon;
            Shield = other.Shield;
        }

        // Interface method: Horizontal view
        public void ViewH()
        {
            Console.WriteLine($"{Name} {Status} {Health} {Weapon} {Shield}");
        }

        // Interface method: Vertical view
        public void ViewV()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Weapon: {Weapon}");
            Console.WriteLine($"Shield: {Shield}");
        }
    }
}
