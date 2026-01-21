namespace Exercices;

/// <summary>
/// Classe qui regroupe les méthodes des exercices à faire.
/// </summary>
class Program
{
    /// <summary>
    /// Execute les méthodes des exercies
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        // Efface toute la consoe et le buffer (le scroll)
        Console.WriteLine("\u001b[3J\u001b[H\u001b[2J");

        Espacer(1);
        Exercice1();

        Espacer(2);
        Exercice2(5, 98);

        Espacer(3);
        int nb_ex3 = Exercice3(5, 98);
        Console.WriteLine(nb_ex3);

        Espacer(4);
        double nb_ex4 = Exercice4();
        Console.WriteLine(nb_ex4);

        Espacer(5);
        int nb_ex5 = Exercice5();
        Console.WriteLine(nb_ex5);

        Espacer(6);
        int nb_ex6 = Exercice6();
        Console.WriteLine(nb_ex6);

    }

    /// <summary>
    /// Affiche un espacement entre deux exercices et affiche le numero de l'exercices
    /// </summary>
    /// <param name="numExe"></param>
    public static void Espacer(int numExe)
    {
        Console.WriteLine("\n- - - - - - - - - - - -");
        Console.WriteLine($"Exercice {numExe}\n");
    }


    #region Fait

    /// <summary>
    /// Affiche un message à la console.
    /// </summary>
    public static void Exercice1()
    {
        Console.WriteLine("Allô p2");
    }

    /// <summary>
    /// Affiche deux nombre entier à la console.
    /// </summary>
    /// <param name="nb1">Premier nombre entier</param>
    /// <param name="nb2">Deuxième nombre entier</param>
    public static void Exercice2(int nb1, int nb2)
    {
        Console.WriteLine($"Premier entier : {nb1}");
        Console.WriteLine($"Deuxième entier : {nb2}");
    }


    /// <summary>
    /// Additione deux nombres entiers ensemble et retourne le résultat.
    /// </summary>
    /// <param name="nb1">Premier nombre entier</param>
    /// <param name="nb2">Deuxième nombre entier</param>
    /// <returns>Nombre entier résulatant de l'addition des deux nombres.</returns>
    public static int Exercice3(int nb1, int nb2)
    {
        return nb1 + nb2;
    }

    /// <summary>
    /// Demande un nombre a l'utilisateur et le retourne en double.
    /// </summary>
    /// <returns>Le nombre rentrer par l'utilisateur</returns>
    public static double Exercice4()
    {
        Console.Write("Entrer un nombre : ");
        double.TryParse(Console.ReadLine(), out double nb);
        return nb;
    }

    /// <summary>
    /// Demande a l'utilisateur d'entrer un nombre et le valide selon des conditions.
    /// </summary>
    /// <returns>
    ///     -1 si ce n'est pas un nombre, si il est vide, si il est inférieure a 0 <\br>
    ///     Le nombre si il est valide et supérieure a 0.
    /// </returns>
    public static int Exercice5()
    {
        Console.Write("Entrer un nombre : ");
        if (int.TryParse(Console.ReadLine(), out int nb) && nb > 0)
        {
            return nb;
        }
        else
        {
            return -1;
        }
    }
    #endregion

    /// <summary>
    /// Demande un nombre a l'utilisateur tant qu'il n'est pas suprérieur a 10.
    /// </summary>
    /// <returns>Le nombre quand il sera supérieur a 10</returns>
    public static int Exercice6()
    {
        bool valide = false;
        int nb = -1;
        while (!valide)
        {
            Console.Write("Entrer un nombre supérieur a 10 : ");
            if (int.TryParse(Console.ReadLine(), out nb) && nb > 10)
            {
                valide = true;
            }
        }
        return nb;
    }


}
