// Déclarer une classe
using System.Collections;

class CalculatricePrix
{
    // Champs privés
    private int quantiteArticle;
    private double prixUnitaireArticle;

    /*
    //Les propriétés ne sont pas trop importantes ici car on reçoit les valeurs des champs via la méthode constructeur
    //Propriétés
    public int QuantiteArticle
    {
        get { return quantiteArticle; }
        set { quantiteArticle = value; }
    }

    public double PrixUnitaireArticle
    {
        get { return prixUnitaireArticle; }
        set { prixUnitaireArticle = value; }
    }
    */

    // Constantes
    const double TPS_TAUX = 0.05; //Taux de la Taxe de Vente Harmonisé du Canada 
    const double TVQ_TAUX = 0.09975; //Taux de la Taxe de Vente du Québec 

    // Méthode Constructeur 
    public CalculatricePrix(int quantiteArticle, double prixUnitaireArticle)
    {
        this.quantiteArticle = quantiteArticle;
        this.prixUnitaireArticle = prixUnitaireArticle;
    }

    // Méthodes
    private double SousTotal()
    {
        //Déclarer des variables
        double sousTot;
        //Calculer
        sousTot = quantiteArticle * prixUnitaireArticle;
        //Envoyer les données de sortie
        return sousTot;
    }

    private double TaxeTPS()
    {
        //Déclarer des variables
        double tps;
        //Calculer
        tps = SousTotal() * TPS_TAUX;
        //Envoyer les données de sortie
        return tps;
    }

    private double TaxeTVQ()
    {
        //Déclarer des variables
        double tvq;
        //Calculer
        tvq = SousTotal() * TVQ_TAUX;
        //Envoyer les données de sortie
        return tvq;
    }

    private double Total()
    {
        //Déclarer des variables
        double tot;
        //Calculer
        tot = SousTotal() + TaxeTVQ() + TaxeTPS();
        //Envoyer les données de sortie
        return tot;
    }

    public Hashtable Calculer()
    {
        //Calculer
        Hashtable resultat = new Hashtable();
        resultat["sous-total"] = SousTotal().ToString("0.00");
        resultat["taxe-tvq"] = TaxeTVQ().ToString("0.00");
        resultat["taxe-tps"] = TaxeTPS().ToString("0.00");
        resultat["total"] = Total().ToString("0.00");
        //Envoyer les données de sortie
        return resultat;
    }
}

class Programme
{
    static void Main()
    {
        //Initialiser variables
        int quantite = 20;
        double prixUnitaire = 5;
        //Instancier une méthode avec un objet  
        Hashtable facture = new CalculatricePrix(quantite,prixUnitaire).Calculer();
        //Afficher le contenu d'une variable
        Console.WriteLine("SOUS TOTAL = "+facture["sous-total"]);
        Console.WriteLine("TAXE TPS = " + facture["taxe-tps"]);
        Console.WriteLine("TAXE TVQ = " + facture["taxe-tvq"]);
        Console.WriteLine("TOTAL = " + facture["total"]);
    }
}
