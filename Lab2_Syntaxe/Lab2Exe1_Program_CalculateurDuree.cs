// Program.cs

// Importer les espaces de nom (namespace)
using System;

// Déclarer une classe
class CalculateurTempsJeu
{
    // Champs
    private int dureeEnSecondes;

    // Méthode 1 : Constructeur 
    public CalculateurTempsJeu()
    {
        LireSecondes();
        ConvertirSecondes();
    }

    // Méthode 2 : Lire secondes
    private void LireSecondes()
    {
        Console.Write("Entrez le temps de jeu en secondes : ");
        dureeEnSecondes = int.Parse(Console.ReadLine());
        Console.WriteLine($"Temps de jeu enregistré : " +
            $"{dureeEnSecondes} secondes");
    }

    // Méthode 3 : Convertir et afficher le temps en heures, minutes et secondes 
    private void ConvertirSecondes()
    {
        int heures = dureeEnSecondes / 3600;
        int secondesRestantes = dureeEnSecondes % 3600;
        int minutes = secondesRestantes / 60;
        int secondes = secondesRestantes % 60;
        Console.WriteLine($"Temps de jeu converti : " +
            $"{heures} heures - " +
            $"{minutes} minutes - " +
            $"{secondes} secondes");
    }
}

class ProgrammePrincipal
{
    // Méthode Main (point d'entrée)
    static void Main()
    {
        CalculateurTempsJeu jeu = new CalculateurTempsJeu();
    }
}
