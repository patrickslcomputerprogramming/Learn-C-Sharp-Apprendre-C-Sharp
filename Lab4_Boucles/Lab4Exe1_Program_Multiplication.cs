//Program.cs

// Importer les espaces de nom (namespace)
using System;

//Class
class LireNombre
{
    public int LireMultiplicateur()
    {
        //Declarer variables
        string donnees_clavier;
        int nbr_mult;
        do {
            //Lire des données : entrées
            Console.Write("Entrez un nombre supérieur à 0 (multiplicateur): \n");
            donnees_clavier = Console.ReadLine();
            try
            {
                nbr_mult = int.Parse(donnees_clavier);
                if (nbr_mult <= 0)
                {
                    Console.Write("Erreur! Nombre inférieure ou égale à 0 détectée.\n\n");
                }
            }
            catch
            {
                Console.Write("Erreur! Valeur non numérique détectée.\n\n");
                nbr_mult = 0;
            }
        } while (nbr_mult<=0);

        //Envoyer les données de sortie
        return nbr_mult;
    }
    public int LireMultiplicandeMin()
    {
        //Declarer variables
        string donnees_clavier;
        int nbr_mult;
        do
        {
            //Lire des données : entrées
            Console.Write("Entrez un deuxième nombre supérieur à 0 (multiplicande minimum): \n");
            donnees_clavier = Console.ReadLine();
            try
            {
                nbr_mult = int.Parse(donnees_clavier);
                if (nbr_mult <= 0)
                {
                    Console.Write("Erreur! Nombre inférieure ou égale à 0 détectée.\n\n");
                }
            }
            catch
            {
                Console.Write("Erreur! Valeur non numérique détectée.\n\n");
                nbr_mult = 0;
            }
        } while (nbr_mult <= 0);

        //Envoyer les données de sortie
        return nbr_mult;
    }

    public int LireMultiplicandeMax(int valeur_min)
    {
        //Declarer variables
        string donnees_clavier;
        int nbr_mult;
        do
        {
            //Lire des données : entrées
            Console.Write("Entrez un troisième nombre supérieur à " + valeur_min + "(multiplicande maximum):\n");
            donnees_clavier = Console.ReadLine();
            try
            {
                nbr_mult = int.Parse(donnees_clavier);
                if (nbr_mult <= valeur_min)
                {
                    Console.Write("Erreur! Nombre inférieure ou égale à " + valeur_min + " détectée.\n\n");
                }
            }
            catch
            {
                Console.Write("Erreur! Valeur non numérique détectée.\n\n");
                nbr_mult = 0;
            }
        } while (nbr_mult == 0 || nbr_mult<=valeur_min);

        //Envoyer les données de sortie
        return nbr_mult;
    }
}

//Class
class CalculerNombre
{
    //Champs 
    private int multiplicateur;
    private int multiplicande_min;
    private int multiplicande_max;

    //Methode constructeur
    public CalculerNombre(int mult, int m_min, int m_max)
    {
        multiplicateur = mult;
        multiplicande_min = m_min;
        multiplicande_max = m_max;
        AfficherMultiplication();
    }
    private void AfficherMultiplication()
    {
        int i;
        int resultat;
        for (i = multiplicande_min; i <= multiplicande_max; i++)
        {
            resultat = i * multiplicateur;
            Console.WriteLine(i + " x " + multiplicateur + " = " + resultat);
        }
    }
}

class Principale
{
    // Méthode Main
    static void Main()
    {
        Console.WriteLine("Multiplication\n");

        //Objet LireNombre
        LireNombre lire = new LireNombre();
        int plicateur = lire.LireMultiplicateur();
        Console.WriteLine();
        int plicande_min = lire.LireMultiplicandeMin();
        Console.WriteLine();
        int plicande_max = lire.LireMultiplicandeMax(plicande_min);

        //Objet CalculerNombre
        Console.WriteLine("\nRésultats");
        CalculerNombre calculer = new CalculerNombre(plicateur, plicande_min, plicande_max);
    }
}