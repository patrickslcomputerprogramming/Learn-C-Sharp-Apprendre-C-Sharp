// Program.cs

// Importer les espaces de nom (namespace)
using System;
using System.Drawing;

// class pour le jeu de devinette de nombre aléatoire généré automatiquement
class JeuDevinerNombreAleatoire
{
    //Champs
    private int nombreMin, nombreMax, nombreAleatoire, nombreEssais = 0;

    //Méthode constructeur
    public JeuDevinerNombreAleatoire(int nb_min = 0, int nb_max = 10)
    {
        //Collecter la limite des nombres aléatoires à générer  
        nombreMin = nb_min;
        nombreMax = nb_max;
        //Générer le nombre aléatoire
        GenererNombre();
        //Collecter le nombre de l'utilisateur
        //Comparer les 2 nombres
        //Compter le nombre d'essaies
        ComparerNombre();
    }

    //Methode pour générer un nombre aléatoire
    public void GenererNombre()
    {
        Random rnd = new Random();
        nombreAleatoire = rnd.Next(nombreMin, nombreMax+1);
    }
    
    // Méthodes pour lire un nombre au clavier
    public int LireNombre()
    {
        int nombreClavier;
        Console.WriteLine("Deviner le nombre que le programme vient de générer aléatoirement.");
        Console.WriteLine("Entrez un nombre entre " + nombreMin + " et " + nombreMax);
        nombreClavier = int.Parse(Console.ReadLine());
        //Envoyer les données de sortie
        return nombreClavier;
    }

    //Méthode pour comparer le nombre aléatoire et le nombre lu au clavier jusqu'à ce qu'ils soient égaux
    public void ComparerNombre()
    {
        //Compter nouvel essai
        nombreEssais++;

        //Lire au clavier nombre utilisateur
        int nombreUtilisateur = LireNombre();

        //Comparer nombre aléatoire et nombre utilisateur
        if (nombreUtilisateur == nombreAleatoire)
        {
            string message = (nombreEssais <= 3) ? "Génial !" : "Enfin !";
            Console.WriteLine($"{message} Trouvé en {nombreEssais} essais !\n");
        }
        else
        {
            Console.Write("Ton nombre est : ");
            Console.Write(nombreUtilisateur < nombreAleatoire ? "'Trop petit !'\n\n" : "'Trop grand !'\n\n");
            ComparerNombre();
        }
    }
}

//Class pour ré-exécuter le programme au besoin lorsqu'il arrive à sa fin 
class ReexecuterProgramme
{
    //Champs
    private char rejouer ;

    //Méthode constructeur
    public ReexecuterProgramme()
    {
        LireReponse();
        OuiOuNon();
    }

    // Méthodes pour lire un nombre au clavier
    private void LireReponse()
    {
        Console.Write("Voulez-vous rejouer ? (o/n) : ");
        rejouer = char.Parse(Console.ReadLine());
    }

    // Méthodes pour ré-éxecuter le programme
    private void OuiOuNon()
    {
        if (rejouer == 'o')
        {
            Console.Clear(); //Effacer l'écran
            ProgrammePrincipal.Main(); // Rappel de Main() pour recommencer (mauvaise pratique)
        }
        else
        {
            Console.Write("Au revoir et à bientôt!\n");
            //Environment.Exit(0); // Terminate and let an external process restart the app (mauvaise pratique)
        }
    }
}

//Class pour démarrer du programme
class ProgrammePrincipal
{
    //Point d'entrée du programme
    public static void Main()
    {
        Console.WriteLine("=== Jeu de Devinette ===");
        JeuDevinerNombreAleatoire jouer = new JeuDevinerNombreAleatoire();
        ReexecuterProgramme rejouer = new ReexecuterProgramme();
    }
}
