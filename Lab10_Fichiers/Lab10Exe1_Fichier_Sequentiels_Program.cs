using System;
using System.IO;
using System.Xml.Linq;

//Classe pour vérifier si un fichier existe
class Fichier 
{ 
    //Champs
    protected string adresseFichier;

    //Methode constructeur
    public Fichier(string adresseFichier)
    {
        this.adresseFichier = adresseFichier;
    }

    //Méthode pour vérifier si un fichier existe
    protected bool EstCeQueFichierExiste()
    {
        return File.Exists(this.adresseFichier) ?  true: false;
    }
}

//Classe pour créer un nouveau fichier si le nom de fichier n'existe pas déjà 
class CreerFichier : Fichier
{
    //Methode constructeur
    public CreerFichier(string adresseFichier) : base(adresseFichier)
    {

    }

    //Méthode pour créer un fichier
    //Note : Le fichier créé peut se retrouver dans
    //C:\Users\LSP\source\repos\fileManipulation\fileManipulation\bin\Debug\net8.0
    public void Ajouter()
    {
        if (EstCeQueFichierExiste() == false)
        {
            try
            {
                FileStream fs = File.Create(this.adresseFichier); //Créer un filestream
                fs.Close(); //Fermer fichier
                Console.WriteLine("le fichier '" + this.adresseFichier + "' est créé avec succès");
            }
            catch (Exception e)
            {
                Console.WriteLine("Echec de création de fichier. \nDescripion de l'erreur: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("Echec de création de fichier. \nDescripion de l'erreur: Le nom du fichier indiqué existe déjà!");
        }
    }
}

//Classe pour ajouter du contenu dans un fichier qui existe
class AjouterContenu : Fichier
{
    //Champs
    private string? contenuFichier = null;

    //Méthode constructeur
    public AjouterContenu(string adresseFichier, string contenuFichier) : base(adresseFichier)
    {
        this.contenuFichier = contenuFichier;
    }

    //Méthode pour ajouter du contenu
    public void Ecrire()
    {
        if (EstCeQueFichierExiste() == true)
        {
            try {
                File.WriteAllText(this.adresseFichier, this.contenuFichier); //Ecrire puis fermer fichier
                Console.WriteLine("Le contenu a été ajouté dans le fichier avec succès!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Echec d'ajout de contenu. \nDescripion de l'erreur: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("Echec d'ajout de contenu. \nDescripion de l'erreur: Fichier indiqué n'existe pas!");
        }
    }
}

//Classe pour lire le contenu d'un fichier qui existe
class LireContenu : Fichier
{
    //Champs
    private string contenuFichier ;
    
    //Méthode constructeur
    public LireContenu(string adresseFichier) : base(adresseFichier)
    {
        
    }

    //Méthode pour sauvegarder le contenu d'un fichier
    private void Sauvegarder()
    {
        if (EstCeQueFichierExiste() == true)
        {
            try
            {
                this.contenuFichier = File.ReadAllText(this.adresseFichier); //Lire puis fermer fichier
            }
            catch (Exception e)
            {
                Console.WriteLine("Echec de sauvegarde de contenu. \nDescripion de l'erreur: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("Echec de sauvegarde de contenu. \nDescripion de l'erreur: Fichier indiqué n'existe pas!");
        }
    }

    //Méthode pour afficher le contenu
    public void Afficher()
    {
        this.Sauvegarder();
        if (this.contenuFichier != null)
            Console.WriteLine(this.contenuFichier);
    }
}


//Classe principale
class Programme
{
    static void Main()
    {
        string adresse = "letutoriel.txt";
        string contenu = "C# est un langage de programmation.";

        //Creer fichier
        Console.WriteLine("1-Créer un fichier");
        CreerFichier creation = new CreerFichier(adresse);
        creation.Ajouter();

        //Ecrire fichier
        Console.WriteLine();
        Console.WriteLine("2-Ecrire dans un fichier");
        AjouterContenu ajout = new AjouterContenu(adresse, contenu);
        ajout.Ecrire();

        //Lire fichier
        Console.WriteLine();
        Console.WriteLine("3-Lire dans un fichier");
        LireContenu lecture = new LireContenu(adresse);
        lecture.Afficher(); 
    }
}

