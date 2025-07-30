//Program.cs

//Importer les espaces de nom (namespace)
using System;
using System.Text.RegularExpressions;


// Déclare un délégué
public delegate void BatterieFaibleEventHandler();

//A – Créer une classe nommée Batterie ayant :
class Batterie
{
    //1.Un événement 
    public event BatterieFaibleEventHandler NiveauCritique;

    //2.Une méthode qui vérifie si niveau est inférieur à 20 pour déclencher l’événement.
    public void VerifierNiveau(int niveau)
    {
        if (niveau < 20)
        {
            NiveauCritique?.Invoke(); // Déclenche l’événement
        }
    }

}

//B – Créer une classe nommée AlerteSysteme 
class AlerteSysteme {
    //1.Une méthode qui affiche un message indiquant que le niveau de batterie est critique.
    public void AfficherAlerte()
    {
        Console.WriteLine("Attention : Niveau de charge de la batterie trop bas !");
    }
    

}


// Déclarer la classe contenant la méthode Main
class ProgrammePrincipal
{
    // Déclarer la méthode Main: point d'entrée
    static void Main()
    {
        //Crée un objet de la classe Batterie et un objet de la classe AlerteSysteme.
        Batterie mesurer = new Batterie();
        AlerteSysteme declencher = new AlerteSysteme();
        //Abonne la méthode AfficherAlerte à l’événement NiveauCritique.
        // Abonnement de la méthode Alerte à l'événement
        mesurer.NiveauCritique += declencher.AfficherAlerte;
        
        //Appelle la méthode VerifierNiveau() avec une valeur inférieure à 20.
        int niveau_charge_batterie = 10;
        Console.WriteLine("Niveau de charge de la batterie = " + niveau_charge_batterie + "%");
        mesurer.VerifierNiveau(niveau_charge_batterie); // Provoque un déclenchement d’événement si niveau < 20
        Console.WriteLine();
        
        //Appelle la méthode VerifierNiveau() avec une valeur supérieure à 20.
        niveau_charge_batterie = 30;
        Console.WriteLine("Niveau de charge de la batterie = " + niveau_charge_batterie + "%");
        mesurer.VerifierNiveau(niveau_charge_batterie); // Provoque un déclenchement d’événement si niveau < 20
    }
}

