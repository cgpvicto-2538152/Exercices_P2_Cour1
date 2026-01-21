

using System.Net;

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

        #region Test

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

        Espacer(7);
        int nb_ex7 = Exercice7(8, -2);
        Console.WriteLine(nb_ex7);

        Espacer(8);
        int[] tab_ex8 = Exercice8(6);
        Console.WriteLine(tab_ex8.Length);

        Espacer(9);
        int[] tab_ex9 = Exercice9(8, 2, 9);
        for (int i_ex9 = 0; i_ex9 < tab_ex9.Length; i_ex9++)
        { Console.Write($"{tab_ex9[i_ex9]}  "); }

        Espacer(10);
        int[] tab_ex10 = Exercice10(15, 18, 30);
        for (int i_ex10 = 0; i_ex10 < tab_ex10.Length; i_ex10++)
        { Console.Write($"{tab_ex10[i_ex10]}  "); }

        Espacer(11);
        int[] tab_ex11 = Exercice11(6, 7, 2);
        for (int i_ex11 = 0; i_ex11 < tab_ex11.Length; i_ex11++)
        { Console.Write($"{tab_ex11[i_ex11]}  "); }


        Espacer(12);
        int[] tab_ex12 = Exercice12(-1, -5, 2);
        for (int i_ex12 = 0; i_ex12 < tab_ex12.Length; i_ex12++)
        { Console.Write($"{tab_ex12[i_ex12]}  "); }

        Espacer(13);
        int[] tab_ex13 = Exercice9(8, 2, 9);
        int nb_ex13 = Exercice13(tab_ex13);
        Console.WriteLine(nb_ex13);

        Espacer(14);
        int[] tab_ex14 = Exercice9(8, 2, 9);
        int nb_ex14 = Exercice14(tab_ex14);
        Console.WriteLine(nb_ex14);

        Espacer(15);
        int[] tab_ex15 = Exercice9(8, 2, 9);
        int nb_ex15 = Exercice15(tab_ex15);
        Console.WriteLine(nb_ex15);

        Espacer(16);
        int[] tab_ex16 = Exercice9(8, 2, 9);
        int nb_ex16 = Exercice16(tab_ex16);
        Console.WriteLine(nb_ex16);

        Espacer(17);
        Exercice17();

        Espacer(18);
        Exercice18(5);

        Espacer(19);
        Exercice19(-6);

        Espacer(20);
        Exercice20(-1, 7);

        Espacer(21);
        Exercice21(4, 4,'S');


        #endregion

        Espacer(22);
        Exercice22(4,4,4,'4');



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

    /// <summary>
    /// Effectue la division de deux nombres et le modifie selon des contraintes
    /// </summary>
    /// <param name="nb1">Le premier nombre</param>
    /// <param name="nb2">Le deuxième nombre</param>
    /// <returns>
    ///     O si le nb2 est 0 <\br>
    ///     Le nombre de en sa valeur absolue (positive)
    /// </returns>
    public static int Exercice7(int nb1, int nb2)
    {
        if (nb2 == 0)
        {
            return 0;
        }
        else
        {
            return nb1 / nb2;
        }
    }

    /// <summary>
    /// Créer un tableau de la longueur rentrer en paramètre.
    /// </summary>
    /// <param name="longueur">La longueur voulu pour le tableau</param>
    /// <returns>L'instance du nouveau tableau</returns>
    public static int[] Exercice8(int longueur)
    {
        return new int[longueur];
    }

    /// <summary>
    /// Initialise un tableau d'une longueur donnée et le remplie aléatoirement avec un minimum et maximum entier donnée.
    /// </summary>
    /// <param name="longueur">La longueur du tableau</param>
    /// <param name="min">L'entier minimum (inclu) </param>
    /// <param name="max">L'entier maximum (exclu)</param>
    /// <returns>Retourne un tableau remplie de valeur aléatoire</returns>
    public static int[] Exercice9(int longueur, int min, int max)
    {
        Random rnd = new Random();
        int[] tab_rnd = new int[longueur];
        for (int i = 0; i < tab_rnd.Length; i++)
        {
            // Mélanger en ayant lu l'exercice 10 (corriger le +1 pour l'enlever)
            tab_rnd[i] = rnd.Next(min, max);
        }
        return tab_rnd;
    }

    /// <summary>
    /// Initialise un tableau d'une longueur donnée et le remplie aléatoirement avec un minimum et maximum entier donnée.
    /// </summary>
    /// <param name="longueur">La longueur du tableau</param>
    /// <param name="min">L'entier minimum (inclu)</param>
    /// <param name="max">L'entier maximum (inclu)</param>
    /// <returns>Retourne un tableau remplie de valeur aléatoire</returns>
    public static int[] Exercice10(int longueur, int min, int max)
    {
        Random rnd = new Random();
        int[] tab_rnd = new int[longueur];
        for (int i = 0; i < tab_rnd.Length; i++)
        {
            tab_rnd[i] = rnd.Next(min, max + 1);
        }
        return tab_rnd;
    }

    /// <summary>
    /// Initialise un tableau d'une longueur donnée et le remplie aléatoirement avec un minimum et maximum entier donnée.
    /// </summary>
    /// <param name="longueur">La longueur du tableau</param>
    /// <param name="min">L'entier minimum (inclu)</param>
    /// <param name="max">L'entier maximum (inclu)</param>
    /// <returns>Retourne un tableau remplie de valeur aléatoire</returns>
    public static int[] Exercice11(int longueur, int min, int max)
    {
        Random rnd = new Random();
        int[] tab_rnd = new int[longueur];

        if (min > max)
        {
            // int temp = min;
            // min = max;
            // min = temp;
            // - - - - - - - -
            // Utiliser le tuple pour échanger des valeurs (IDE0180)
            (max, min) = (min, max);
        }

        for (int i = 0; i < tab_rnd.Length; i++)
        {
            tab_rnd[i] = rnd.Next(min, max + 1);
        }
        return tab_rnd;
    }

    /// <summary>
    /// Initialise un tableau d'une longueur donnée et le remplie aléatoirement avec un minimum et maximum entier donnée.
    /// </summary>
    /// <param name="longueur">La longueur du tableau</param>
    /// <param name="min">L'entier minimum (inclu)</param>
    /// <param name="max">L'entier maximum (inclu)</param>
    /// <returns>Retourne un tableau remplie de valeur aléatoire</returns>
    public static int[] Exercice12(int longueur, int min, int max)
    {

        if (longueur < 0)
        { return []; }

        Random rnd = new Random();

        int[] tab_rnd = new int[longueur];

        if (min > max)
        {
            // int temp = min;
            // min = max;
            // min = temp;
            // - - - - - - - -
            // Utiliser le tuple pour échanger des valeurs (IDE0180)
            (max, min) = (min, max);
        }

        for (int i = 0; i < tab_rnd.Length; i++)
        {
            tab_rnd[i] = rnd.Next(min, max + 1);
        }
        return tab_rnd;
    }

    /// <summary>
    /// Fait la somme de tout les nombres d'un tableau de nombres.
    /// </summary>
    /// <param name="tab">Tableau de nombre entiers</param>
    /// <returns>Somme des nombres entier</returns>
    public static int Exercice13(int[] tab)
    {
        int total = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            total += tab[i];
        }
        return total;
    }

    /// <summary>
    /// Fait la somme de tout les nombres d'un tableau de nombres.
    /// </summary>
    /// <param name="tab">Tableau de nombre entiers</param>
    /// <returns>Somme des nombres entier</returns>
    public static int Exercice14(int[] tab)
    {
        int total = 0;
        foreach (int num in tab)
        {
            total += num;
        }
        return total;
    }

    /// <summary>
    /// Fait la somme de tout les nombres d'un tableau de nombres.
    /// </summary>
    /// <param name="tab">Tableau de nombre entiers</param>
    /// <returns>Somme des nombres entier</returns>
    public static int Exercice15(int[] tab)
    {
        int total = 0;
        int index = 0;
        while (index < tab.Length)
        {
            total += tab[index];
            index++;
        }
        return total;
    }

    /// <summary>
    /// Fait la somme de tout les nombres d'un tableau de nombres.
    /// </summary>
    /// <param name="tab">Tableau de nombre entiers</param>
    /// <returns>Somme des nombres entier</returns>
    public static int Exercice16(int[] tab)
    {
        int total = 0;
        int index = 0;
        // non proteger contre les arrays null, en raison que la 
        // do-while s'execute minimalement une fois avant de 
        // rencontrer une condition qui peut l'arreter
        do
        {
            total += tab[index];
            index++;
        } while (index < tab.Length);

        return total;
    }

    /// <summary>
    /// Affiche une forme sur la console
    /// </summary>
    public static void Exercice17()
    {
        Console.WriteLine("***\n***\n***");
    }

    /// <summary>
    /// Affiche une forme sur la console avec une largeur donnée
    /// </summary>
    /// <param name="largeur">Largeur de la forme voulu</param>
    public static void Exercice18(int largeur)
    {
        for (int i = 3; i > 0; i--)
        {
            for (int j = 0; j < largeur; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

    /// <summary>
    /// Affiche une forme sur la console avec une largeur donnée
    /// </summary>
    /// <param name="largeur">Largeur de la forme voulu</param>
    public static void Exercice19(int largeur)
    {
        if (largeur < 0)
        {
            largeur *= -1;
        }
        for (int i = 3; i > 0; i--)
        {
            int cpt = 0;
            while (cpt < largeur)
            {
                Console.Write("*");
                cpt++;
            }
            Console.Write("\n");
        }
    }

    /// <summary>
    /// Affiche une forme sur la console avec des grandeurs de coté donnée
    /// </summary>
    /// <param name="largeur">Largeur de la forme voulu</param>
    /// <param name="hauteur">Hauteur de la forme voulu</param>
    public static void Exercice20(int largeur, int hauteur)
    {
        if (largeur < 1 || hauteur < 0)
        {
            Console.WriteLine("Impossible d'afficher parce que dimension trop petite ( < 1 )");
            return;
        }
        for (int i = hauteur; i > 0; i--)
        {
            for (int j = largeur; j > 0; j--)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

    /// <summary>
    /// Affiche une forme sur la console avec des grandeurs de coté donnée
    /// </summary>
    /// <param name="largeur">Largeur de la forme voulu</param>
    /// <param name="hauteur">Hauteur de la forme voulu</param>
    /// <param name="charac">Caractère à afficher pour composer la forme</param>
    public static void Exercice21(int largeur, int hauteur, char charac)
    {
        if (largeur < 1 || hauteur < 0)
        {
            Console.WriteLine("Impossible d'afficher parce que dimension trop petite ( < 1 )");
            return;
        }
        for (int i = hauteur; i > 0; i--)
        {
            for (int j = largeur; j > 0; j--)
            {
                Console.Write($"{charac}");
            }
            Console.Write("\n");
        }
    }




    #endregion



    /// <summary>
    /// Affiche une forme sur la console avec des grandeurs de coté donnée
    /// </summary>
    /// <param name="largeur">Largeur de la forme voulu</param>
    /// <param name="hauteur">Hauteur de la forme voulu</param>
    /// <param name="nbs">Nombre de fois que la forme sera afficher</param>
    /// <param name="charac">Caractère à afficher pour composer la forme</param>
    public static void Exercice22(int largeur, int hauteur, int nbs, char charac)
    {
        if (largeur < 1 || hauteur < 0)
        {
            Console.WriteLine("Impossible d'afficher parce que dimension trop petite ( < 1 )");
            return;
        }
        for (int c = 0; c < nbs; c++)
        {
            for (int i = hauteur; i > 0; i--)
            {
                for (int j = largeur; j > 0; j--)
                {
                    Console.Write($"{charac}");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }




}
