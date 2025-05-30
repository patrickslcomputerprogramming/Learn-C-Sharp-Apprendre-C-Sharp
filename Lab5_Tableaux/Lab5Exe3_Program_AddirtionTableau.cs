using System;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Sockets;
using System.Text;

class LireNombres
{
    private int SuperieurAZero()
    {
        //Declarer variables
        string donnees_clavier;
        int nbr_lu;
        do
        {
            //Lire des données : entrées
            Console.Write("Entrez un nombre entier plus grand que 0 : \n");
            donnees_clavier = Console.ReadLine();
            try
            {
                nbr_lu = int.Parse(donnees_clavier);
                if (nbr_lu <= 0)
                {
                    Console.Write("Erreur! Nombre inférieure ou égale à 0 détectée.\n\n");
                }
            }
            catch
            {
                Console.Write("Erreur! Valeur non numérique détectée.\n\n");
                nbr_lu = 0;
            }
        } while (nbr_lu <= 0);

        //Envoyer les données de sortie
        return nbr_lu;
    }

    protected int[] nNombres(int n)
    {
        int[] liste_nombre = new int[n];

        for (int i = 0; i < n; i++)
        {
            liste_nombre[i] = SuperieurAZero();
        }
        return liste_nombre;
    }
}

class CombinerNombres : LireNombres
{
    int[] tous_les_nombres;
    public CombinerNombres(int quantite)
    {
        tous_les_nombres = nNombres(quantite);
    }
    private int Addition()
    {
        int somme = 0;
        foreach (int i in tous_les_nombres)
            somme = somme + i;
        return somme;
    }

    private int Multiplication()
    {
        int produit = 1;
        foreach (int i in tous_les_nombres)
            produit = produit * i;
        return produit;
    }

    public void AfficherResultat() {
        Console.WriteLine();
        Console.WriteLine ("Nombres lus : ");
        foreach (int i in tous_les_nombres)
            Console.Write(i + "  ");
        Console.WriteLine();
        Console.WriteLine("Somme = " + Addition());
        Console.WriteLine("Produit = " + Multiplication());
    }
}

class Programme
{
    static void Main()
    {
        do
        {
            Console.WriteLine();
            int n_nombres = 3;
            CombinerNombres calculer = new CombinerNombres(n_nombres);
            calculer.AfficherResultat();
            Console.WriteLine();
            Console.Write("Rejouer ? (o/n) ");
        } while (Console.ReadKey().Key == ConsoleKey.O);
    }
}