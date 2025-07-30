using System;
using System.Globalization;
using System.Net;

//Class
class DevinetteProvincesTerritoiresCanada
{
    private string[] mots = { "ALBERTA", "COLOMBIE-BRITANNIQUE", "ILE-DU-PRINCE-EDOUARD", "MANITOBA", "NOUVEAU-BRUNSWICK", "NOUVELLE-ECOSSE", "ONTARIO", "QUEBEC", "SASKATCHEWAN", "TERRE-NEUVE-ET-LABRADOR", "TERRITOIRES DU NORD-OUEST", "NUNAVUT", "YUKON" };
    private string motSecret;
    private char[] motAffiche;
    private int vies = 6;

    public void Deviner()
    {
        //Sélectionne aléatoirement un mot dans la liste des noms des provinces et territoires du Canada.
        Random rnd = new Random();
        motSecret = mots[rnd.Next(mots.Length)];
        //Affiche le mot sélectionné masqué avec un trait de soulignement(underscore) pour remplacer chaque lettre.  
        motAffiche = new char[motSecret.Length];
        for (int i = 0; i < motSecret.Length; i++)
            motAffiche[i] = '_';

        //Boucle pour exécuter les 6 vies du joueur au besoin
        while (vies > 0 && new string(motAffiche) != motSecret)
        {

            Console.Clear();
            Console.WriteLine($"DEVINER LE NOM DE L'UN " +
                $"DES 10 PROVINCES OU DE L'UN DES 3 TERRITOIRES " +
                $"DU CANADA SELECTIONNE ALEATOIREMENT");
            Console.WriteLine($"Nombre de vies restantes: {vies}");
            Console.WriteLine("NOM à deviner: " + string.Join(" ", motAffiche));
            Console.Write("Devinez une lettre du NOM: ");

            char lettre = Console.ReadKey().KeyChar;
            Console.WriteLine();

            bool lettreCorrecte = false;
            for (int i = 0; i < motSecret.Length; i++)
            {
                if (motSecret[i] == lettre)
                {
                    motAffiche[i] = lettre;
                    lettreCorrecte = true;
                }
            }

            if (!lettreCorrecte)
            {
                vies--;
                Console.WriteLine("Incorrect !");
            }
        }

        Console.Clear();
        if (vies > 0) Console.WriteLine($"Gagné ! Le mot était: {motSecret}");
        else Console.WriteLine($"Perdu ! Le mot était: {motSecret}");
    }
}

//Class
class Utilisateurs
{
    //Champ
    private string adresseFichierComptes;

    //Méthode Constructeur
    public Utilisateurs(string adresseFichierComptes)
    {
        this.adresseFichierComptes = adresseFichierComptes;
    }

    //Valider utilisateur
    protected bool NomEtCodeSontIlsValides(string nom, string code)
    {
        bool resultat = false;
        if (File.Exists(adresseFichierComptes) == true)
        {
            try
            {
                foreach (string ligne in File.ReadLines(adresseFichierComptes))
                {
                    if (ligne == nom + " " + code)
                    {
                        resultat = true;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Problème de connexion au fichier des comptes. Réessayez plus tard! \nDescripion de l'erreur: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("Le fichier des comptes n'est pas trouvé! Réessayez plus tard!");
        }
        return resultat;
    }
}

//Class
class Authentification: Utilisateurs
{
    public Authentification(string adresseFichierComptes): base(adresseFichierComptes)
    {

    }

    public void Authentifier()
    {
        bool connexion = false;
        do
        {
            //Message bienvenue
            Console.WriteLine("=======================================================");
            Console.WriteLine("Bienvenue dans le Jeu ' Deviner nom Province Canada' ");
            Console.WriteLine("=======================================================");

            //Lire données connexion utilisateur
            Console.Write("Utilisateur  : ");
            string nom = Console.ReadLine();
            Console.Write("Mot de Passe : ");
            string code = Console.ReadLine();

            //Appeler méthode de connexion
            if (this.NomEtCodeSontIlsValides(nom, code)==true)
            {
                Console.WriteLine();
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Utilisateur ou Mot de Passe incorrect. Réessayez!");
            }
        } while (connexion == false);
    }
}

class Programme
{
    static void Main()
    {
        //Connecter un utilisateur
        //Adresse fichier des comptes pour la connexion
        string adresseFichier = "C:\\Users\\LSP\\source\\repos\\ManipulationDeFichiers\\ManipulationDeFichiers\\info_connexion.txt";
        Authentification connexion = new Authentification(adresseFichier);
        connexion.Authentifier();

        string choix;

        do
        {
            new DevinetteProvincesTerritoiresCanada().Deviner();
            Console.Write("Pressez la touche 1, 2 ou 3 : \n1-Pour Rejouer \n2-Pour Se Déconnecter \n3-Pour Quitter\n");
            //Validation non effectuée, mais pourrait pour accepter uniquement des données valides
            choix = Console.ReadLine();
            if (choix == "2")
            {
                Main();
            }
        } while (choix=="1");
        Console.Write("Au revoir!");
    }
}

