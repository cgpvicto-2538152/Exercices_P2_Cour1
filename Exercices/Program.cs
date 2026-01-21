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

    #endregion

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
    
}
