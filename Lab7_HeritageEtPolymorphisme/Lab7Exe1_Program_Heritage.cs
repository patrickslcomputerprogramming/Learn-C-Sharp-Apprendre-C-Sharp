// Program.cs

// Importer les espaces de nom (namespace)
using System;
using System.Globalization;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

//A-Créez une « classe » de base nommée Cercle qui permet de créer des objets correspondants à des cercles de tailles variées.
class Cercle
{
    //Champ
    private double rayon;

    //1.Une « méthode constructeur » qui reçoit un paramètre nommé « rayon » dont la valeur est affectée à un champ nommé « rayon ».
    public Cercle (double rayon)
    {
        this.rayon = rayon;
    }

    //2.Une méthode nommée « Surface » qui calcule et renvoie la surface à partir du rayon(surface = Math.PI * Rayon * Rayon).
    public double Surface ()
    {
        return Math.PI * this.rayon * this.rayon;
    }
}

//B - Créez une « classe » dérivée de la classe Cercle nommée « Cylindre » qui contient :
sealed class Cylindre : Cercle
{
    //Champs
    private double hauteur;

    //1.Une « méthode constructeur » qui reçoit le paramètre nommé « rayon » de la méthode constructeur de la classe de base; et un deuxième paramètre nommé « hauteur » dont la valeur est affectée à un champ nommé « hauteur ».
    public Cylindre(double rayon, double hauteur) : base(rayon)
    {
        this.hauteur = hauteur;
    }

    //2.Une méthode nommée « Volume » qui calcule et renvoie le volume à partir de la surface et de la hauteur (volume = surface * hauteur).
    public double Volume()
    {
        return this.Surface() * this.hauteur;
    }
}

// Déclarer la classe contenant la méthode Main
class ProgrammePrincipal
{
    // Déclarer la méthode Main: point d'entrée
    static void Main()
    {
        //D-Créez un objet pour tester la classe Cercle. Utilisez les données de test ci-dessous :  
	    //Entrées: rayon = 5 - Sorties : surface = 78.54
        double rayon_cercle = 5;
        Cercle cercle = new Cercle(rayon_cercle);
        //Appeler des methodes avec un objet
        double surface_cercle = cercle.Surface();
        //Afficher
        Console.WriteLine("Classe Cercle");
        Console.WriteLine("Rayon Cercle = " + rayon_cercle.ToString("0.00"));
        Console.WriteLine("Surface Cercle = " + surface_cercle.ToString("0.00"));

        //E-Créez un objet pour tester la classe Cylindre. Utilisez les données de test ci-dessous :  
	    //Entrées: rayon = 5   hauteur = 7 - Sorties : surface = 78.54   volume = 549.78
        double hauteur_cylindre = 7;
        Cylindre cylindre = new Cylindre(rayon_cercle, hauteur_cylindre);
        //Appeler des methodes avec un objet
        double surface_cylindre = cylindre.Surface();
        double volume_cylindre = cylindre.Volume();
        //Afficher
        Console.WriteLine();
        Console.WriteLine("Classe Cylindre");
        Console.WriteLine("Rayon Cylindre = " + rayon_cercle.ToString("0.00"));
        Console.WriteLine("Surface Cylindre = " + surface_cylindre.ToString("0.00"));
        Console.WriteLine("Volume Cylindre = " + volume_cylindre.ToString("0.00"));
    }
}

