/*Créez une application console C# qui convertit des températures 
 * de l’unité Celsius vers l’unité Fahrenheit, et vice-versa.
*/


using System;

//Classe pour collecter des données
class CollecterDonnees
{
    //Méthode
    private void MenuChoix()
    {
        Console.WriteLine("Convertisseur de température ----------------- \nChoisissez: ");
        Console.WriteLine("1: pour convertir de Celsius vers Fahrenheit.");
        Console.WriteLine("2 : pour convertir de Fahrenheit vers Celsius.");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Entrez votre choix:");
    }

    //Méthode
    private bool ValiderChoix(char choix)
    {
        //Calculer
        bool resultat = false;
        if (choix == '1' || choix == '2')
        {
            resultat = true;
        }
        //Retourner résultat
        return resultat;
    }

    //Méthode
    public char CalculerChoix()
    {
        //Calculer
        char choix;
        do
        {
            //Afficher menu 
            this.MenuChoix();
            //Lire choix au clavier
            choix = Console.ReadKey().KeyChar;
        } while (ValiderChoix(choix) == false);
        //Retourner résultat
        return choix;
    }

    //Méthode
    private bool ValiderTemperature(string temp)
    {
        //Calculer
        bool resultat = false;
        try
        {
            double.Parse(temp);
            resultat = true;
        }
        catch
        {
            Console.WriteLine("Erreur! Valeur non numérique détectée.\n");
            resultat   = false;
        }
        //Retourner résultat
        return resultat;
    }

    //Méthode
    public double CalculerTemperature()
    {
        //Calculer
        string entree="";
        do
        {
            //Afficher message 
            Console.WriteLine();
            Console.WriteLine("Entrez la température à convertir: ");
            //Lire choix au clavier
            entree = Console.ReadLine();
        } while (ValiderTemperature(entree) == false);
        //Retourner résultat
        return double.Parse(entree);
    }
}

//Classe pour calculer des données
class CalculerDonnees
{
    //Constante
    const double RATIO_C_F = 9.0 / 5.0;  //Ratio conversion Celcius vers Fahrenheit.
    const double RATIO_F_C = 5.0 / 9.0;  //Ratio conversion Fahrenheit vers Celcius.
    const double TEMP_FUSION_F = 32;     //Température de congélation de l’eau en Fahrenheit.

    //Champ
    private char choix;
    private double temperature;

    //Méthode constructeur
    public CalculerDonnees(char choix, double temperature)
    {
        this.choix = choix;
        this.temperature = temperature;
    }

    //Méthode 
    private double CelciusVersFahrenheit(double celcius)
    {
        //Calculer 
        double fahrenheit = celcius * RATIO_C_F + TEMP_FUSION_F; 
        //Retourner résultat
        return fahrenheit;
    }

    //Méthode 
    private double FahrenheitVersCelcius(double fahrenheit)
    {
        //Calculer
        double celcius = (fahrenheit - TEMP_FUSION_F) * RATIO_F_C;
        //Retourner résultat
        return fahrenheit;
    }

    //Méthode
    public void ConvertirTemperature()
    {
        Console.WriteLine("\nRésultat de la Conversion:");
        if (choix == '1') {
            Console.Write(temperature + " degrés Celcius = ");
            Console.Write(CelciusVersFahrenheit(temperature).ToString("0.00") + " degrés Fahrenheit");    
        }
        else if (choix == '2')
        {
            Console.Write(temperature + " degrés Fahrenheit = ");
            Console.Write(FahrenheitVersCelcius(temperature).ToString("0.00") + " degrés Celcius");
        }
    }
}

//Classe principale (contenant le point d'entrée du programme)
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
            Console.WriteLine("\n\nVoulez-vous re-executer le programme? (O/N)");
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
            else
            {
                Console.WriteLine("Erreur détectée dans votre réponse!!!");
            }
        } while ((choix != 'O' && choix != 'o') && (choix != 'N' && choix != 'n'));
        //Retourner sortie
        return resultat;
    }

    //Méthode point d'entrée du programme (exécuté en premier)
    static void Main(string[] args)
    {
        //Réexécution
        do
        {
            //Entrees : collecter données
            CollecterDonnees entree = new CollecterDonnees();
            char choix = entree.CalculerChoix();
            double temperature = entree.CalculerTemperature();
            //Sorties : calculer données et afficher
            CalculerDonnees sortie = new CalculerDonnees(choix, temperature);
            sortie.ConvertirTemperature();
        } while (ReexecuterProgramme() == true);
        //Message de fin
        Console.WriteLine("\nAu revoir! A bientot!");
    }
}