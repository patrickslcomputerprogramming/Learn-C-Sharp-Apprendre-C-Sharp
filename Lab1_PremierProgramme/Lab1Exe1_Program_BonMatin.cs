// Program.cs

// Importer les espaces de nom (namespace) 
using System; 

// Déclarer une classe 
class Demonstration
{
    // Déclarer la méthode Main: point d'entrée 
    static void Main(string[] args)
    {
        //Afficher des données : sorties 
        Console.WriteLine("Bon matin de Québec!");
        Console.WriteLine("Zone: " + TimeZoneInfo.Local);
        Console.WriteLine("Date: " + DateTime.Now);
    }
}
