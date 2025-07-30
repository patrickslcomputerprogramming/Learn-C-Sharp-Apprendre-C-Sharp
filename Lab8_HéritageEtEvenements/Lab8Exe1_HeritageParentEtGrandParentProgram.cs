//Program.cs

//Importer les espaces de nom (namespace)
using System;
using System.Globalization;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

//A. Une classe de base nommée CompterNombres
class CompterNombres
{
    //Champ
    protected int[]? liste_nombres = null;

    //1.Une méthode « constructeur » qui reçoit un tableau d'entiers en argument et l'affecte à un champ. 
    public CompterNombres(int[] liste_nombres)
    {
        this.liste_nombres = liste_nombres;
    }

    //2.Une méthode qui calcule et renvoie le nombre d'entiers inclus dans le tableau stocké dans le champ.  
    protected int Quantite() {
        return this.liste_nombres.Length;
    }

    //3.Une méthode qui identifie et renvoie l'entier du tableau stocké dans le champ dont la valeur est la plus grande (maximum).  
    private int Maximum()
    {
        return this.liste_nombres.Max();
    }

    //4.Une méthode qui identifie et renvoie l'entier du tableau stocké dans le champ dont la valeur est la moins grande (minimum).
    private int Minimum()
    {
        return this.liste_nombres.Min();
    }

    //5.Une méthode qui utilise le champ et les méthodes précédentes afin d'afficher les informations qu'elles ont calculées. Retrouvez ci-dessous un exemple de la sortie de cette méthode :  
    public void AfficherCompterNombres()
    {
        //Afficher Nombres
        Console.WriteLine ("Nombres saisis : " + string.Join(",", this.liste_nombres));
        //Afficher Quantité de nombres
        Console.WriteLine("Quantité de nombre : " + this.Quantite());
        //Afficher Nombre maximum
        Console.WriteLine("Nombre maximum : " + this.Maximum());
        //Afficher Nombre minimum
        Console.WriteLine("Nombre minimum  : " + this.Minimum());
    }

}

//B.Une classe dérivée nommée CombinerNombres, qui est une sous-classe de CompterNombres, et inclut les membres indiqués ci-dessous. 
class CombinerNombres : CompterNombres
{

    //Méthode constructeur
    public CombinerNombres(int[] liste_nombres) : base(liste_nombres)
    {

    }

    //1.Une méthode qui calcule et renvoie la somme (résultat d’une addition) des entiers inclus dans le tableau reçu en argument par le constructeur de la classe parente CompterNombres. 
    protected double Somme()
    {
        return this.liste_nombres.Sum();
    }

    //2.Une méthode qui calcule et retourne le produit (résultat d’une multiplication) des entiers inclus dans le tableau reçu en argument par le constructeur de la classe parente CompterNombres. 
    private double Produit()
    {
        int taille = this.Quantite();
        int produit = 1;
        for (int i = 0; i < taille; i++)
        {
            produit = produit * this.liste_nombres[i];
        }
        return produit;
    }

    //3.Une méthode qui appelle les méthodes précédentes afin d'afficher les informations qu'elles ont calculées. Retrouvez ci-dessous un exemple de la sortie de cette méthode :  
    public void AfficherCombinerNombres()
    {
        //Afficher Nombres
        this.AfficherCompterNombres();
        //Afficher Somme des nombres 
        Console.WriteLine("Somme :" + this.Somme());
        //Afficher Produit des nombres 
        Console.WriteLine("Produit:" + this.Produit());
    }
}

//C.Une classe dérivée nommée ComparerNombres qui est une sous-classe de CombinerNombres et qui inclut les membres indiqués ci-dessous. 
class ComparerNombres : CombinerNombres
{ 
    //Méthode constructeur
    public ComparerNombres(int[] liste_nombres) : base (liste_nombres)
    {

    }
    //1.Une méthode qui calcule et retourne la moyenne des entiers (somme des nombres divisée par la quantité de nombres) inclus dans le tableau reçu en argument par le constructeur de la classe grand-parente CompterNombres. Pour calculer la moyenne, utilisez le nombre d'entiers calculé dans CompterNombres et la somme des entiers calculée dans CombinerNombres (moyenne = somme des entiers / nombre d'entiers).  
    private double Moyenne ()
    {
        return (this.Somme() / this.Quantite());
    }

    //2.Une méthode qui appelle la méthode précédente afin d'afficher les informations qu'elle a calculées. Retrouvez ci-dessous un exemple de la sortie de cette méthode :  
    public void AfficherComparerNombres()
    {
        //Afficher Nombres
        this.AfficherCombinerNombres();
        //Afficher Moyenne des nombres 
        Console.WriteLine("Moyenne :" + this.Moyenne().ToString("0.00"));
    }
}

// Déclarer la classe contenant la méthode Main
class ProgrammePrincipal
{
    // Déclar  compter.AfficherCombinerNombres();er la méthode Main: point d'entrée
    static void Main()
    {
        //Déclaration et initialisation
        int[] mes_nombres = { 4, 5, 1, 75, 100, 88 };

        //Objet et instanciation classe de base (parent et grand parent)
        Console.WriteLine("Classe CompterNombres ===============");
        new CompterNombres(mes_nombres).AfficherCompterNombres();
        Console.WriteLine();

        //Objet et instanciation classe dérivée (enfant et parent)
        Console.WriteLine("Classe CombinerNombres ===============");
        new CombinerNombres(mes_nombres).AfficherCombinerNombres();
        Console.WriteLine();

        //Objet et instanciation classe dérivée (enfant et parent)
        Console.WriteLine("Classe ComparerNombres ===============");
        new ComparerNombres(mes_nombres).AfficherComparerNombres();
        Console.WriteLine();
    }
}

