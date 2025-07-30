// Importation de l’espace de noms
using System.Collections;

//1.Une classe nommée par exemple « LireAuClavier » qui contient une méthode permettant de lire au clavier des informations.
class LireAuClavier
{
    protected string Lire(string information, string exemple)
    {
        Console.WriteLine("Entrez l'information : " + information + " (exemple: " + exemple + ")");
        return Console.ReadLine();
    }
}

//2.Une sous classe de la classe « LireAuClavier », nommée par exemple « CollecterDonnees », qui contient une méthode permettant d’enregistrer dans une ArrayList différentes informations sur un étudiant.
class CollecterDonnees : LireAuClavier
{
    string[] nom_info = { "Numéro identification", "Prénom", "Nom", "Moyenne générale sur 100", "Statut d'inscription" };
    private ArrayList Collecter()
    {
        //Créer la collection
        ArrayList infoEtudiant = new ArrayList();

        //Message 
        Console.WriteLine("Entrez les données de l'étudiant");
        //Lire au clavier et enregistrer numéro_identification 
        int numero_identification = int.Parse(this.Lire(nom_info[0], "12345"));
        infoEtudiant.Add(numero_identification);
        //Lire au clavier et enregistrer prenom 
        string prenom = this.Lire(nom_info[1], "Jean");
        infoEtudiant.Add(prenom);
        //Lire au clavier et enregistrer nom 
        string nom = this.Lire(nom_info[2], "Dupont");
        infoEtudiant.Add(nom);
        //Lire au clavier et enregistrer moyenne generale 
        double moyenne_generale = double.Parse(this.Lire(nom_info[3], "80"));
        infoEtudiant.Add(moyenne_generale);
        //Lire au clavier et statut d'inscription 
        string info_inscription = this.Lire(nom_info[4], "O: pour OUI | N: pour NON");
        bool statut_inscription = info_inscription == "O" ? true : false;
        infoEtudiant.Add(statut_inscription);

        //Retourner la sortie
        return infoEtudiant;
    }

    //Méthode pour afficher
    public void Afficher()
    {
        int i = 0;
        ArrayList donnee_etudiant = this.Collecter();
        Console.WriteLine();
        Console.WriteLine("Les données enregistrées pour l'étudiant sont:");
        foreach (var chaqueInfo in donnee_etudiant)
        {
            Console.WriteLine(nom_info[i] + " : " + chaqueInfo);
            i++;
        }
    }

}

//0.Classe principale
class Program
{
    static void Main()
    {
        //Objet et instanciation de méthode
        CollecterDonnees collect = new CollecterDonnees();
        collect.Afficher();
    }
}
