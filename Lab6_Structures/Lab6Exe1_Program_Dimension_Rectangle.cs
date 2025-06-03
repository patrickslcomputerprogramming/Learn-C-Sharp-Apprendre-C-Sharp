struct Dimensions
{
    private int largeur;
    private int hauteur;

    public Dimensions(int l, int h)
    {
        largeur = l;
        hauteur = h;
    }

    public void Afficher()
    {
        Console.WriteLine($"Largeur: {largeur}, Hauteur: {hauteur}");
    }
}

struct Rectangle
{
    private string nom;
    private Dimensions taille; // Structure imbriquée

    public Rectangle(string le_nom, Dimensions la_taille)
    {
        nom = le_nom;
        taille = la_taille;
    }

    public void AfficherRectangle()
    {
        Console.WriteLine("Nom : " + nom);
        taille.Afficher();
    }
}

class LireEntrees
{
    public int LireNombreSuperieurAZero()
    {
        //Declarer variables
        string donnees_clavier;
        int nbr_mult;
        do
        {
            //Lire des données : entrées
            Console.Write("Entrez un nombre supérieur à 0\n");
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

    public string LireTexte()
    {
        //Declarer variables
        string donnees_clavier;
        
        //Lire des données : entrées
        Console.Write("Entrez un texte\n");
        donnees_clavier = Console.ReadLine();

        //Envoyer les données de sortie
        return donnees_clavier;
    }
}


class Program
{
    static void Main()
    {

        //Recevoir la longueur du rectangle
        Console.Write("Entrez la longueur du rectangle - - - - - - - - - - - - -\n");
        int longueur = new LireEntrees().LireNombreSuperieurAZero();

        //Recevoir la largeur du rectangle
        Console.Write("Entrez la longueur du rectangle - - - - - - - - - - - - -\n");
        int largeur = new LireEntrees().LireNombreSuperieurAZero();

        //Recevoir le nom du rectangle
        Console.Write("Entrez le nom du rectangle - - - - - - - - - - - - -\n");
        string nom = new LireEntrees().LireTexte();

        //Afficher les informations
        Console.WriteLine("\n\nInformation sur le rectangle -----------------");
        Dimensions dim = new Dimensions(longueur, largeur);
        Rectangle rect = new Rectangle(nom, dim);
        rect.AfficherRectangle();
    }
}
