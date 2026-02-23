


using VikingNS;

class Program
{

    static void Main()
    {
        // Print teammates
        Console.WriteLine("Group-Krishmas Sapkota");
        Console.WriteLine("Caleb Dudgeon");
        Console.WriteLine("Noah Franke");

        // Default Viking
        Viking v1 = new Viking();
        v1.ViewH();
        v1.ViewV();

        // Overridden Viking
        Viking v2 = new Viking("Ragnar", Global.Status.JARL, 250, Global.Weapon.SWORD, true);
        v2.ViewH();
        v2.ViewV();

        // Copy constructor
        Viking v3 = new Viking(v2);
        v3.ViewH();
    }
}
