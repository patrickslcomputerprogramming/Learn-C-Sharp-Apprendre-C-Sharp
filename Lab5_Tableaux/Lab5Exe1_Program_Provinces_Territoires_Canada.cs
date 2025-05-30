using System;
using System.Net;

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

class Programme
{
    static void Main()
    {
        do
        {
            new DevinetteProvincesTerritoiresCanada().Deviner();
            Console.Write("Rejouer ? (o/n) ");
        } while (Console.ReadKey().Key == ConsoleKey.O);
    }
}
