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
    private Hashtable Collecter()
    {
        //Créer la collection
        Hashtable infoEtudiant = new Hashtable();

        //Message 
        Console.WriteLine("Entrez les données de l'étudiant");
        //Lire au clavier et enregistrer numéro_identification 
        infoEtudiant["id"] = int.Parse(this.Lire(nom_info[0], "12345"));
        //Lire au clavier et enregistrer prenom 
        infoEtudiant["nom1"] = this.Lire(nom_info[1], "Jean");
        //Lire au clavier et enregistrer nom 
        infoEtudiant["nom2"] = this.Lire(nom_info[2], "Dupont");
        //Lire au clavier et enregistrer moyenne generale 
        infoEtudiant["moyenne"] = double.Parse(this.Lire(nom_info[3], "80"));
        //Lire au clavier et statut d'inscription 
        string info_inscription = this.Lire(nom_info[4], "O: pour OUI | N: pour NON");
        infoEtudiant["statut"] = info_inscription == "O" ? true : false;

        //Retourner la sortie
        return infoEtudiant;
    }

    //Méthode pour afficher
    public void Afficher()
    {
        Hashtable donnee_etudiant = this.Collecter();
        Console.WriteLine();
        Console.WriteLine("Les données enregistrées pour l'étudiant sont:");
        foreach (DictionaryEntry chaqueInfo in donnee_etudiant)
        {
            Console.WriteLine(chaqueInfo.Key + " : " + chaqueInfo.Value);
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
