


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
        public short Health { get; set; }
        public Global.Weapon Weapon { get; set; }
        public bool Shield { get; set; }

        // Default constructor
        public Viking(
            string name = "Bjorn",
            Global.Status status = Global.Status.KARL,
            short health = 150,
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
                  
                  private string FormatEnum(Enum value)
                    {
                      string lower = value.ToString().ToLower();
                    return char.ToUpper(lower[0]) + lower.Substring(1);
                    }

        // Interface method: Horizontal view
        public void ViewH()
{
    Console.WriteLine($"{Name} {FormatEnum(Status)} {Health} {FormatEnum(Weapon)} {Shield}");
}

        // Interface method: Vertical view
        public void ViewV()
        {
           Console.WriteLine($"Name: {Name}");
           Console.WriteLine($"Status: {FormatEnum(Status)}");
           Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Weapon: {FormatEnum(Weapon)}");
            Console.WriteLine($"Shield: {Shield}");
        }
    }
}
