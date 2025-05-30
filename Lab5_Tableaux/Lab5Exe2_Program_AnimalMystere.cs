using System;

class QuizAnimaux
{
    private string[] animaux = { "lion", "éléphant", "loup", "serpent" };
    private string[][] indices = {
        new string[] { "Je suis le roi de la jungle.", "J'ai une crinière.", "Je rugis." },
        new string[] { "Je suis le plus grand mammifère terrestre.", "J'ai une trompe.", "Je viens d'Afrique." },
        new string[] { "Je suis un mammifère carnivore, semblable au chien.", "Je vis en meute.", "Je hurle." },
        new string[] { "Je suis un reptile sans membres, au corps long et cylindrique.", "Je me déplace en rampant.", "Je siffle." }
    };

    public void Jouer()
    {
        int score = 0;

        for (int i = 0; i < animaux.Length; i++)
        {
            Console.Clear();
            Console.WriteLine($"Question {i + 1}/{animaux.Length}");

            int indiceActuel = 0;
            while (indiceActuel < indices[i].Length)
            {
                Console.WriteLine($"\nIndice {indiceActuel + 1}: {indices[i][indiceActuel]}");
                Console.Write("Votre réponse: ");
                string reponse = Console.ReadLine().ToLower();

                if (reponse == animaux[i])
                {
                    Console.WriteLine("Correct !");
                    score++;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect !");
                    indiceActuel++;
                }
            }

            if (indiceActuel == indices[i].Length)
                Console.WriteLine($"Dommage ! L'animal était: {animaux[i]}");

            Console.WriteLine($"Score: {score}/{animaux.Length}");
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
        }

        Console.Clear();
        Console.WriteLine($"Quiz terminé ! Score final: {score}/{animaux.Length}");
    }
}

class Programme
{
    static void Main()
    {
        do
        {
            new QuizAnimaux().Jouer();
            Console.Write("Rejouer ? (o/n) ");
        } while (Console.ReadKey().Key == ConsoleKey.O);
    }
}
