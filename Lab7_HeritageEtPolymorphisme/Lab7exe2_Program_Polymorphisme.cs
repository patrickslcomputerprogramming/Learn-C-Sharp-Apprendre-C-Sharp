//Program.cs

//Importer les espaces de nom (namespace)
using System;
using System.Globalization;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

//A-Créez une « classe » de base nommée Fruits qui permet de créer des objets correspondants à des fruits. 
class Fruits
{
    //Champ
    protected string nom_fruit;

    //1.Une « méthode constructeur » qui reçoit un paramètre nommé « nom_fruit » dont la valeur est affectée à un champ nommé « nom_fruit ».
    public Fruits (string nom_fruit)
    {
        this.nom_fruit = nom_fruit;
    }

    //2.Une « méthode » virtuelle qui retourne la couleur d’un fruit. 
    public virtual string CouleurFruit()
    {
        return "Affiche la couleur du fruit!";
    }
}

//B-Créez une « classe » dérivée de la classe Fruit nommée « Pomme » 
sealed class Pomme : Fruits
{
    //Champs
    private string couleur_fruit = "rouge";

    //Méthode constructeur  
    public Pomme(string nom_fruit) : base(nom_fruit) { }

    //1.Une « méthode » qui redéfinit la méthode virtuelle de la classe de base et retourne la couleur de la pomme.
    public override string CouleurFruit()
    {
        return this.couleur_fruit;
    }
}

//C-Créez une « classe » dérivée de la classe Fruit nommée « Melon » qui contient :
class Melon : Fruits
{
    //Champs
    private string couleur_fruit = "jaune" ;

    //Méthode constructeur 
    public Melon (string nom_fruit) : base(nom_fruit) { }

    //1.Une « méthode » qui redéfinit la méthode virtuelle de la classe de base et retourne la couleur de la pomme.
    public override string CouleurFruit()
    {
        return this.couleur_fruit;
    }

}

// Déclarer la classe contenant la méthode Main
class ProgrammePrincipal
{
    // Déclarer la méthode Main: point d'entrée
    static void Main()
    {
        //Démontrer que le polymorphisme permet à des objets de classes différentes d'être traités comme des objets d'une même classe de base en créant un objet pour tester les classes, suivant la notation polymorphique telle que montrée ci - dessous.
        //Utilisation polymorphique
        Fruits[] fruits = { 
            new Pomme("Pomme Cannelle"), 
            new Melon("Melon d’eau") 
        };

        //Utiliser une boucle foreach pour appeler le champ « nom_fruit » et la méthode virtuelle redéfinie dans les classes dérivées.
        foreach (var chaqueFruit in fruits) { 
            Console.WriteLine("Nom fruit : " + chaqueFruit);
            Console.WriteLine("Couleur fruit : " + chaqueFruit.CouleurFruit());
            Console.WriteLine();
        }
    }
}

