// Program.cs

// Importer les espaces de nom (namespace)
using System;

// Déclarer une classe
class CollecterDonnees
{
    // Méthodes
    public int ChiffreOuNombre()
    {
        //Declarer variables
        int entier;
        //Lire des données : entrées
        Console.Write("Entrez un chiffre ou un nombre entier: ");
        entier = int.Parse(Console.ReadLine());
        //Envoyer les données de sortie
        return entier;
    }
}

// Déclarer une classe
class TypeSigneEntier
{
    //Déclarer des champs
    private int nombreUtilisateur;

    //Déclarer la méthode constructeur
    public TypeSigneEntier(int nb){
        nombreUtilisateur = nb;
    }

    //Déclarer une méthode
    public string TypeEntier(){
        //Déclarer des variables
        string typeNombre;
        
        //Calculer type nombre
        if (nombreUtilisateur >= -9 && nombreUtilisateur <= 9) {
            typeNombre = "chiffre";
        }
        else{
            typeNombre = "nombre";
        }

        //Envoyer les données de sortie
        return typeNombre;
    }

    //Déclarer une méthode
    public string signeEntier(){
        //Déclarer des variables
        string signeNombre;

        //Calculer signe nombre
        if (nombreUtilisateur == 0 || nombreUtilisateur > 0){
            signeNombre = "positif";
        }
        else{
            signeNombre = "négatif";
        }

        //Envoyer les données de sortie
        return signeNombre;
    }
}

// Déclarer une classe
class ProgrammePrincipal
{
    // Méthode Main
    static void Main()
    {
        // Lire les entrées
        CollecterDonnees lire = new CollecterDonnees();
        int nbr = lire.ChiffreOuNombre();

        // Calculer 
        TypeSigneEntier calculer = new TypeSigneEntier(nbr);
        string type_nbr = calculer.TypeEntier();
        string signe_nbr = calculer.signeEntier();

        //Afficher des données : sortie
        Console.WriteLine($"\n'{nbr}' est un '{type_nbr}' qui est '{signe_nbr}'.");
    }
}
