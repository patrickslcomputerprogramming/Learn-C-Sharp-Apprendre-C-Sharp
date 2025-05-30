// Program.cs

// Importer les espaces de nom (namespace)
using System;

// Déclarer une classe
class CalculateurScore
{
    // Méthode pour lire le pseudo
    public string LirePseudo()
    {
        Console.Write("Entrez votre pseudo : ");
        return Console.ReadLine();
    }

    // Méthode pour lire le nombre d'ennemis vaincus
    public int LireEnnemisVaincus()
    {
        Console.Write("Entrez le nombre d'ennemis vaincus : ");
        return int.Parse(Console.ReadLine());
    }

    // Méthode pour lire les points par ennemi
    public double LirePointsParEnnemi()
    {
        Console.Write("Entrez les points par ennemi vaincu : ");
        return double.Parse(Console.ReadLine());
    }

    // Méthode pour calculer le Score Brut
    public double CalculerScoreBrut(int ennemis, double points)
    {
        return ennemis * points;
    }

    // Méthode pour calculer le Bonus (10% du Score Brut)
    public double CalculerBonus(double scoreBrut)
    {
        return scoreBrut * 0.10;
    }

    // Méthode pour calculer le Score Total
    public double CalculerScoreTotal(double scoreBrut, double bonus)
    {
        return scoreBrut + bonus;
    }

    // Méthode Main
    static void Main()
    {
        CalculateurScore jeu = new CalculateurScore();

        // Lire les entrées
        string pseudo = jeu.LirePseudo();
        int ennemis = jeu.LireEnnemisVaincus();
        double pointsParEnnemi = jeu.LirePointsParEnnemi();

        // Calculs
        double scoreBrut = jeu.CalculerScoreBrut(ennemis, pointsParEnnemi);
        double bonus = jeu.CalculerBonus(scoreBrut);
        double scoreTotal = jeu.CalculerScoreTotal(scoreBrut, bonus);

        // Affichage
        Console.WriteLine("\n--- Résultats ---");
        Console.WriteLine($"Pseudo : {pseudo}");
        Console.WriteLine($"Ennemis vaincus : {ennemis}");
        Console.WriteLine($"Points par ennemi : {pointsParEnnemi:F2}");
        Console.WriteLine($"Score Brut : {scoreBrut:F2}");
        Console.WriteLine($"Bonus : {bonus:F2}");
        Console.WriteLine($"Score Total : {scoreTotal:F2}");
    }
}
