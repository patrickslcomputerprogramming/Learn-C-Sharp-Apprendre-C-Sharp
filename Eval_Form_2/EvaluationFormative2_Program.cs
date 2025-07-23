class LettresConcatenees
{
    //Champ
    protected char[] liste_lettres;

    //Méthode constructeur
    public LettresConcatenees(char[] liste_lettres)
    {
        this.liste_lettres = liste_lettres;
    }

    //Une méthode qui calcule et renvoie le nombre de lettres inclus dans un tableau de lettres  
    protected int NombreLettres()
    {
        return liste_lettres.Length;
    }

    //Une méthode qui calcule et renvoie la concaténation des lettres inclus dans le tableau dans l’ordre de leur stockage, en partant par le premier indice, donc 0.
    protected string ConcatenerLettres()
    {
        int nombre_total_lettres = this.NombreLettres();
        string mot = "";
        for (int i = 0; i < nombre_total_lettres; i++)
        {
            mot = mot + this.liste_lettres[i];
        }
        return mot;
    }

    //Méthode pour afficher
    public virtual void AfficherInfomation()
    {
        //Afficher
        int nombre_total_lettres = this.NombreLettres();

        Console.Write("Lettres : ");
        for (int i = 0; i<nombre_total_lettres; i++){
            Console.Write(liste_lettres[i]);
            Console.Write((i < nombre_total_lettres-1) ? ", " : ".");
        }
        Console.WriteLine();
        Console.WriteLine("Nombre de lettres : " + this.NombreLettres());
        Console.WriteLine("Lettres concaténées dans l'ordre de stockage : " + this.ConcatenerLettres());
    }
}

class LettresConcateneesInverse : LettresConcatenees
{
    //Méthode constructeur
    public LettresConcateneesInverse(char[] liste_lettres) : base(liste_lettres)
    {
 
    }

    //Une méthode qui calcule et renvoie la concaténation des lettres inclus dans le tableau en sens inverse de l’ordre de leur stockage, en partant par le premier indice, donc 0.
    protected string ConcatenerLettresInverse()
    {
        int nombre_total_lettres = this.NombreLettres();
        string mot = "";
        for (int i = nombre_total_lettres - 1; i >= 0; i--)
        {
            mot = mot + this.liste_lettres[i];
        }
        return mot;
    }

    //Une méthode pour afficher qui efface la méthode de même nom dans la classe de base
    public override void AfficherInfomation()
    {
        //Appel de la méthode de même nom dans la classe de base pour afficher
        base.AfficherInfomation();
        //Afficher
        Console.WriteLine("Lettres concaténées dans l'ordre inverse de stockage : " + this.ConcatenerLettresInverse());
    }
}

class EstCeUnPalindrome : LettresConcateneesInverse
{
    //Méthode constructeur
    public EstCeUnPalindrome(char[] liste_lettres) : base(liste_lettres)
    {

    }

    //Méthode pour vérifier si c'est un palindrome ou pas
    private void PalindromeOuPas()
    {
        //Calculer
        string resultat = " n'est pas un palindrome";

        if (this.ConcatenerLettres() == this.ConcatenerLettresInverse())
        {
            resultat = " est un palindrome";
        }

        //Afficher
        Console.WriteLine("Le mot " + this.ConcatenerLettres() + resultat);
    }

    //Une méthode pour afficher qui efface la méthode de même nom dans la classe de base
    public override void AfficherInfomation()
    {
        //Appel de la méthode de même nom dans la classe de base pour afficher
        base.AfficherInfomation();
        //Afficher
        this.PalindromeOuPas();
    }
}

class Programme
{
   
    //Méthode point d'entrée du programme (exécuté en premier)
    static void Main(string[] args)
    {
        //Déclarer
        char[] tableau_lettres1 = { 'a', 'l', 'l', 'o' };

        LettresConcatenees lettres1 = new LettresConcatenees(tableau_lettres1);
        lettres1.AfficherInfomation();

        Console.WriteLine();
        LettresConcateneesInverse lettres2 = new LettresConcateneesInverse(tableau_lettres1);
        lettres2.AfficherInfomation();

        Console.WriteLine();
        EstCeUnPalindrome lettres3 = new EstCeUnPalindrome(tableau_lettres1);
        lettres3.AfficherInfomation();

        Console.WriteLine();

        //Déclarer
        char[] tableau_lettres2 = { 'm', 'a', 'd', 'a', 'm' };

        LettresConcatenees lettres4 = new LettresConcatenees(tableau_lettres2);
        lettres4.AfficherInfomation();

        Console.WriteLine();
        LettresConcateneesInverse lettres5 = new LettresConcateneesInverse(tableau_lettres2);
        lettres5.AfficherInfomation();

        Console.WriteLine();
        EstCeUnPalindrome lettres6 = new EstCeUnPalindrome(tableau_lettres2);
        lettres6.AfficherInfomation();

    }
}
