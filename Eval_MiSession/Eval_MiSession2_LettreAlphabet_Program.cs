/*
 * Créez une application console C# qui affiche toutes les lettres 
 * de l’alphabet français placées dans l’intervalle de deux lettres 
 * lues au clavier, qui sont espacés d’au moins de 7 autres lettres.
*/


using System;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

class Alphabet
{
    public static char[] Francais()
    {
        //Déclarer
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 
                            'h', 'i', 'j', 'k', 'l', 'm', 'n', 
                            'o', 'p', 'q', 'r', 's', 't', 'u', 
                            'v', 'w', 'x', 'y', 'z' };
        //Retourner sorties
        return alphabet;
    }
}

class CollecterDonnees
{
    //Champs
    private int ecart_entre_deux_lettres;

    //Méthode constructeur
    public CollecterDonnees(int ecart_entre_deux_lettres)
    {
        this.ecart_entre_deux_lettres = ecart_entre_deux_lettres;
    }
    private int CalculerNumeroLettre(char lettre)
    {
        int numero=0, i;

        for (i=0; i<26; i++)
        {
            if (lettre == Alphabet.Francais()[i])
            {
                numero = i; 
                break;
            }
        }
        return numero;
    }
    private bool ValiderUneLettre(char lettre, char lettre_min, char lettre_max)
    {
        //Calculer
        bool estUneLettre = false;
        bool resultat = true;
        foreach (char uneLettre in Alphabet.Francais())
        {
            //Si entree est une lettre
            if (uneLettre == lettre || uneLettre.ToString().ToUpper().ToCharArray()[0] == lettre)
            {
                //Convertit en minuscule
                lettre = lettre.ToString().ToLower().ToCharArray()[0];
                estUneLettre = true; 
                break;
            } 
        }
        if (estUneLettre == true && 
            (this.CalculerNumeroLettre(lettre) < this.CalculerNumeroLettre(lettre_min) || 
            this.CalculerNumeroLettre(lettre) > this.CalculerNumeroLettre(lettre_max))
            )
        {
            Console.WriteLine();
            Console.WriteLine("Erreur détectée. Lettre incorrect!");
            resultat = false;
        }
        else if (estUneLettre == false)
        {
            Console.WriteLine();
            Console.WriteLine("Erreur détectée. Vous n'avez pas entré une lettre!");
            resultat = false;
        }
 
        //Retourner sorties
        return resultat;
    }

    private char CollecterUneLettre(string msg, char lettre_min, char lettre_max)
    {
        char lettre;
        do
        {
            Console.WriteLine();
            Console.WriteLine(msg);
            lettre = Console.ReadKey().KeyChar;
        } while (this.ValiderUneLettre(lettre, lettre_min, lettre_max) == false);

        return lettre;
    }

    public int[] CollecterLesDeuxLettres()
    {
        //Lire premier nombre
        char lettre1_min = Alphabet.Francais()[0];
        char lettre1_max = Alphabet.Francais()[this.CalculerNumeroLettre('z') - (ecart_entre_deux_lettres + 1)];
        string msg_lettre1 = "Entrer une première lettre allant de « "+lettre1_min+" » à « "+lettre1_max+" ».";
        char lettre1 = this.CollecterUneLettre(msg_lettre1, lettre1_min, lettre1_max);
        //Convertit en minuscule
        lettre1 = lettre1.ToString().ToLower().ToCharArray()[0];
        Console.WriteLine();
        //Lire deuxième nombre
        char lettre2_min = Alphabet.Francais()[this.CalculerNumeroLettre(lettre1) + (ecart_entre_deux_lettres + 1)];
        char lettre2_max = Alphabet.Francais()[Alphabet.Francais().Length - 1];
        string msg_lettre2 = "Entrer une deuxième lettre allant de « " + lettre2_min + " » à « " + lettre2_max + " ».";
        char lettre2 = this.CollecterUneLettre(msg_lettre2, lettre2_min, lettre2_max);
        //Convertit en minuscule
        lettre2 = lettre2.ToString().ToLower().ToCharArray()[0];
        //Afficher
        Console.Write("\n\nVous avez saisi les lettres " + lettre1 + " et " + lettre2 + ".");
        //Retourner le premier et le deuxième nombre  
        return new int[] { this.CalculerNumeroLettre(lettre1), this.CalculerNumeroLettre(lettre2)};
    }
}

class CalculerDonnees
{
    //Champ
    private int numero_lettremin;
    private int numero_lettremax;

    //Méthode constructeur
    public CalculerDonnees(int[] numero_lettremin_lettremax)
    {
        this.numero_lettremin = numero_lettremin_lettremax.Min();
        this.numero_lettremax = numero_lettremin_lettremax.Max();
    }

    public int CalculerNombreDeLettres()
    {
        return (numero_lettremax - numero_lettremin) - 1;
    }

    public string CalculerToutesLesLettres()
    {
        string toutes_les_lettres = "";
        
        for (int i = numero_lettremin + 1; i < numero_lettremax; i++)
        {
            //char separateur = i < numero_lettremax ? ',' : '.';
            toutes_les_lettres += Alphabet.Francais()[i];
            toutes_les_lettres += i < numero_lettremax-1 ? ',' : '.';
        }
        //Retourner sortie 
        return toutes_les_lettres;
    }

    public void AfficherToutesLesLettres()
    {
        //Afficher 
        Console.WriteLine();
        Console.Write("Entre elles se trouvent " + this.CalculerNombreDeLettres() + " lettres");
        Console.Write(" qui sont " + this.CalculerToutesLesLettres());
        Console.WriteLine();
    }
}

class Programme
{ 
    //Methode pour réexécuter
    static bool ReexecuterProgramme()
    {
        //Calculer
        char choix = ' ';
        bool resultat = true;
        do
        {
            Console.WriteLine("\nVoulez-vous re-executer le programme? (O/N)");
            choix = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (choix == 'O' || choix == 'o')
            {
                resultat = true;
            }
            else if (choix == 'N' || choix == 'n')
            {
                resultat = false;
            }
            else {
                Console.WriteLine("Erreur détectée dans votre réponse!!!");
            }
        } while ((choix != 'O' && choix != 'o') && (choix != 'N' && choix != 'n'));
        //Retourner sortie
        return resultat; 
    }
    //Méthode point d'entrée du programme (exécuté en premier)
    static void Main(string[] args)
    {
        int distance_deux_lettres = 7;
        //Réexécution
        do
        {
            //Entrees : collecter données
            CollecterDonnees entree = new CollecterDonnees(distance_deux_lettres);
            int[] lettre1et2 = entree.CollecterLesDeuxLettres();
            //Sorties : calculer données et afficher
            CalculerDonnees sortie = new CalculerDonnees(lettre1et2);
            sortie.AfficherToutesLesLettres();
        } while (ReexecuterProgramme()==true);
        //Message de fin
        Console.WriteLine("\nAu revoir! A bientot!");
    }
}
