// Program.cs

// Importer les espaces de nom (namespace)
using System;

// Déclarer une classe
class CollecterDonnees
{
    // Méthodes
    public string NomItem()
    {
        //Declarer variables
        string nomItem;
        //Lire des données : entrées
        Console.Write("Entrez le nom du jeu acheté: \n");
        nomItem = Console.ReadLine();
        //Envoyer les données de sortie
        return nomItem;
    }

    public int QuantiteItem()
    {
        //Declarer variables
        int quantiteItem;
        //Lire des données : entrées
        Console.Write("Entrez la quantité du jeu acheté: \n");
        quantiteItem = int.Parse (Console.ReadLine());
        //Envoyer les données de sortie
        return quantiteItem;
    }

    public double PrixUnitaireItem()
    {
        //Declarer variables
        double prixUnitaireItem;
        //Lire des données : entrées
        Console.Write("Entrez le prix unitaire du jeu acheté en $CA: \n");
        prixUnitaireItem = double.Parse(Console.ReadLine());
        //Envoyer les données de sortie
        return prixUnitaireItem;
    }
}


// Déclarer une classe
class CalculatricePrix
{
    // Champs privés
    private int quantiteArticle;
    private double prixUnitaireArticle;
    // Constantes
    const double TPS_TAUX = 0.05; //Taux de la Taxe de Vente Harmonisé du Canada 
    const double TVQ_TAUX = 0.09975; //Taux de la Taxe de Vente du Québec 

    // Méthode Constructeur 
    public CalculatricePrix(int qp, double pup)
    {
        quantiteArticle = qp;
        prixUnitaireArticle = pup;
    }

    // Méthodes
    public double SousTotal()
    {
        //Déclarer des variables
        double sousTot;
        //Calculer
        sousTot = quantiteArticle * prixUnitaireArticle;
        //Envoyer les données de sortie
        return sousTot;
    }

    public double TaxeTPS()
    {
        //Déclarer des variables
        double tps;
        //Calculer
        tps = SousTotal() * TPS_TAUX;
        //Envoyer les données de sortie
        return tps;
    }

    public double TaxeTVQ()
    {
        //Déclarer des variables
        double tvq;
        //Calculer
        tvq = SousTotal() * TVQ_TAUX;
        //Envoyer les données de sortie
        return tvq;
    }

    public double Total()
    {
        //Déclarer des variables
        double tot;
        //Calculer
        tot = SousTotal() + TaxeTVQ() + TaxeTPS();
        //Envoyer les données de sortie
        return tot;
    }
}


// Déclarer la classe contenant la méthode Main
class Programme
{
    // Déclarer la méthode Main: point d'entrée
    static void Main()
    {
        //Créer un objet 
        CollecterDonnees lecture = new CollecterDonnees();
        //Appeler des methodes avec un objet
        string nom = lecture.NomItem();
        int quantite = lecture.QuantiteItem();
        double prix_unitaire = lecture.PrixUnitaireItem();

        //Créer un objet 
        CalculatricePrix calcul = new CalculatricePrix(quantite, prix_unitaire);
        //Appeler des methodes avec un objet
        double sous_total = calcul.SousTotal();
        double taxe_TPS = calcul.TaxeTPS();
        double taxe_TVQ = calcul.TaxeTVQ();
        double total = calcul.Total();

        //Afficher données : sorties
        Console.WriteLine("\nSommaire de l'achat");
        Console.WriteLine("Nom article: " + nom);
        Console.WriteLine("Quantité article: " + quantite);
        Console.WriteLine("Prix unitaire article: " + prix_unitaire.ToString("C2"));
        Console.WriteLine("Sous-total: " + sous_total.ToString("C2"));
        Console.WriteLine("Taxe TPS: " + taxe_TPS.ToString("C2"));
        Console.WriteLine("Taxe TVQ: " + taxe_TVQ.ToString("C2"));
        Console.WriteLine("Total: " + total.ToString("C2"));
    }
}


