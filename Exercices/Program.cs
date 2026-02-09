using System.Diagnostics;

namespace Exercices
{
    /// <include file='../Doc.xml' path='Doc/Exercice.cs/Class/Program'/>
    class Program
    {
        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Main'/>
        public static void Main(string[] args)
        {
            // Efface toute la consoe et le buffer (le scroll)
            Console.WriteLine("\u001b[3J\u001b[H\u001b[2J");

            #region Liste
            // Liste de prenom generer par IA
            string[] lstPrenom =
            {
                "Alice",
                "Bob",
                "Charlie",
                "Diana",
                "Ethan",
                "Fiona",
                "George",
                "Hannah",
                "Ian",
                "Julia",
                "Kevin",
                "Laura",
                "Michael",
                "Nina",
                "Oliver",
                "Paula",
                "Quentin",
                "Rachel",
                "Samuel",
                "Tina",
                "Ulysses",
                "Victoria",
                "William",
                "Xavier",
                "Yvonne",
                "Zachary"
            };
            // Liste de nom generer par IA
            string[] lstNom =
            {
                "Anderson",
                "Brown",
                "Clark",
                "Davis",
                "Evans",
                "Franklin",
                "Garcia",
                "Harris",
                "Iverson",
                "Johnson",
                "King",
                "Lewis",
                "Miller",
                "Nelson",
                "Owens",
                "Parker",
                "Quinn",
                "Roberts",
                "Smith",
                "Taylor",
                "Upton",
                "Vasquez",
                "Williams",
                "Xanders",
                "Young",
                "Zimmerman"
            };

            #endregion


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
            Exercice20(3, 7);

            Espacer(21);
            Exercice21(4, 4, 'S');

            Espacer(22);
            Exercice22(4, 4, 4, '4');

            Espacer(23);
            Exercice23(3);

            Espacer(24);
            Exercice24(4);

            Espacer(25);
            Exercice25(7);

            Espacer(26);
            Exercice26(7);

            Espacer(27);
            string forme = Exercice27(6);
            Console.WriteLine(forme);

            Espacer(28);
            int[] tab_ex28 = Exercice9(0, 1, 10);
            double nb_ex28 = Exercice28(tab_ex28);
            Console.WriteLine(nb_ex28);

            Espacer(29);
            int[] tab_ex29 = Exercice9(7, 1, 10);
            double nb_ex29 = Exercice29(tab_ex29);
            Console.WriteLine(nb_ex29);

            Espacer(30);
            Personne pers_ex30 = new("Alexis", "Bergeois", 19);
            Console.WriteLine($"{pers_ex30.Nom} {pers_ex30.Prenom} a {pers_ex30.Age} ans");
            pers_ex30.Vieillir();
            Console.WriteLine($"{pers_ex30.Nom} {pers_ex30.Prenom} a {pers_ex30.Age} ans");

            Espacer(31);
            Personne[] pers_ex31 = Exercice31(10, 10, 100, lstPrenom, lstNom);
            foreach (Personne personne in pers_ex31)
            { Console.WriteLine(personne.ToString()); }

            Espacer(32);
            Personne[] tabPersEx32 = Exercice31(10, 1, 25, lstPrenom, lstNom);
            double nbEx32 = Exercice32(tabPersEx32);
            Console.WriteLine(nbEx32);

            Espacer(33);
            Personne[] tabPersEx33 = Exercice31(10, 1, 56, lstPrenom, lstNom);
            Personne persEx33 = Exercice33(tabPersEx33);
            Console.WriteLine(persEx33);

            Espacer(34);
            int[] tab_ex34 = Exercice9(7, 1, 9);
            foreach (int nb in tab_ex34)
            { Console.Write($"{nb}  "); }
            Exercice34(tab_ex34, 0, 1);
            Console.WriteLine("\n0--1--2--3--4--5--6");
            foreach (int nb in tab_ex34)
            { Console.Write($"{nb}  "); }

            Espacer(35);
            int[] tab_ex35 = [1, 2, 3, 4, 5, 6, 7];
            foreach (int nb in tab_ex35)
            { Console.Write($"{nb}  "); }
            Exercice35(tab_ex35);
            Console.WriteLine("\n0--1--2--3--4--5--6");
            foreach (int nb in tab_ex35)
            { Console.Write($"{nb}  "); }

            Espacer(36);
            int[] tab_ex36 = [1, 2, 3, 4, 5, 6, 7];
            foreach (int nb in tab_ex36)
            { Console.Write($"{nb}  "); }
            Exercice36(tab_ex36);
            Console.WriteLine("\n0--1--2--3--4--5--6");
            foreach (int nb in tab_ex36)
            { Console.Write($"{nb}  "); }

            Espacer(37);
            char[] chars = { 'S', 'i', 'm', 'o', 'n' };
            int nb_ex37 = Exercice37(chars, 'o');
            Console.WriteLine(nb_ex37);

            Espacer(38);
            int[] tabEx38 = [1, 2, 3, 4, 5, 4, 7];
            foreach (int nb in tabEx38)
            { Console.Write($"{nb}  "); }
            int nbEx38 = Exercice38(tabEx38);
            Console.WriteLine("\n0--1--2--3--4--5--6");
            Console.WriteLine(nbEx38);

            Espacer(39);
            int[] tabEx39a = [1, 3, 3, 4, 5, 4, 7];
            foreach (int nb in tabEx39a)
            { Console.Write($"{nb}  "); }
            int[] tabEx39b = Exercice39(tabEx39a);
            Console.WriteLine("\n0--1--2--3--4--5--6");
            foreach (int nb in tabEx39b)
            { Console.Write($"{nb}  "); }

            Espacer(40);
            int[] tabEx40a = [1, 2, 3];
            int[] tabEx40b = [4, 5, 6];
            int[] tabEx40c = Exercice40(tabEx40a, tabEx40b);
            Console.Write($"Tab 1 : ");
            foreach (int nb in tabEx40a)
            { Console.Write($"{nb}  "); }
            Console.Write("\nTab 2 : ");
            foreach (int nb in tabEx40b)
            { Console.Write($"{nb}  "); }
            Console.WriteLine("\nTab fusionner : ");
            foreach (int nb in tabEx40c)
            { Console.Write($"{nb}  "); }

            Espacer(40);
            int[] tabEx40 = Exercice12(10, 1, 10);
            foreach (int nb in tabEx40)
            { Console.Write($"{nb}  "); }
            int[] tabEx40resultat = Exercice41(tabEx40);
            Console.WriteLine();
            foreach (int nb in tabEx40resultat)
            { Console.Write($"{nb}  "); }

            Espacer(42);
            int[] tabEx42 = Exercice42(11);
            foreach (int nb in tabEx42)
            { Console.Write($"{nb}  "); }

            Espacer(43);
            int[] tabEx43a = [1, 2, 3, 4, 5, 6, 7];
            foreach (int nbEx43 in tabEx43a)
            { Console.Write($"{nbEx43} "); }
            int[] tabEx43b = Exercice43(tabEx43a, 10);
            Console.WriteLine();
            foreach (int nbEx43 in tabEx43b)
            { Console.Write($"{nbEx43} "); }

            Espacer(44);
            int[] tabEx44a = [1, 2, 3, 4, 5, 6, 7];
            foreach (int nbEx44 in tabEx44a)
            { Console.Write($"{nbEx44} "); }
            int[] tabEx44b = Exercice44(tabEx44a, 3);
            Console.WriteLine();
            foreach (int nbEx44 in tabEx44b)
            { Console.Write($"{nbEx44} "); }

            Espacer(45);
            int[] tabEx45a = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int nbEx45 in tabEx45a)
            { Console.Write($"{nbEx45} "); }
            Exercice45(tabEx45a, 11);
            Console.WriteLine();
            foreach (int nbEx45 in tabEx45a)
            { Console.Write($"{nbEx45} "); }

            Espacer(46);
            int[] tabEx46a = { 0, 1, 2, 1, 2, 2, 3, 4, 5 };
            int[] tabEx46b = Exercice46(tabEx46a);
            Console.WriteLine("\n0--1--2--3--4--5--6--7");
            foreach (int nbEx46 in tabEx46b)
            { Console.Write($"{nbEx46}  "); }

            Espacer(47);
            int[] tabEx47a = { 1, 2, 1, 2, 2, 3, 4, 5, 4 };
            int tabEx47b = Exercice47(tabEx47a);
            Console.WriteLine("\n0--1--2--3--4--5--6--7");
            Console.WriteLine($"{tabEx47b}");

            Espacer(48);
            int[] tabEx48 = Exercice48(10);
            foreach (int nbEx48 in tabEx48)
            { Console.Write($"{nbEx48}  "); }

            Espacer(49);
            int[] tabEx49a = { 1, 3, 5 };
            int[] tabEx49b = { 2, 4, 6 };
            int[] tabEx49c = Exercice49(tabEx49a, tabEx49b);
            foreach (int nbEx49 in tabEx49c)
            { Console.Write($"{nbEx49}  "); }

            Espacer(50);
            int[] tabEx50 = Exercice12(12, 1, 13);
            Exercice50(tabEx50);
            foreach (int nbEx50 in tabEx50)
            { Console.Write($"{nbEx50}  "); }

            Espacer(51);
            int[] tabEx51 = Exercice12(12, 1, 13);
            Exercice51(tabEx51);
            foreach (int nbEx51 in tabEx51)
            { Console.Write($"{nbEx51}  "); }

            Espacer(52);
            int[] tabEx52 = Exercice12(12, 1, 13);
            Exercice52(tabEx52);
            foreach (int nbEx52 in tabEx52)
            { Console.Write($"{nbEx52}  "); }

            Espacer(53);
            Personne[] personnes = Exercice31(13, 1, 14, lstPrenom, lstNom);
            Exercice53(personnes);
            foreach (Personne personne in personnes)
            { Console.WriteLine(personne); }

            Espacer(54);
            Personne persEx54a = Exercice31(13, 1, 14, lstPrenom, lstNom)[1]; // pour du random
            Personne persEx54b = Exercice31(13, 1, 14, lstPrenom, lstNom)[5]; // pour du random
            int resEx54 = Exercice54(persEx54a, persEx54b);
            Console.WriteLine($"{persEx54a}\n{persEx54b}");
            Console.WriteLine(resEx54);

            #endregion

        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Espacer'/>
        public static void Espacer(int numExe)
        {
            Console.WriteLine("\n- - - - - - - - - - - -");
            Console.WriteLine($"Exercice {numExe}\n");
        }


        #region Fait

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice1'/>]
        public static void Exercice1()
        {
            Console.WriteLine("Allô p2");
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice2'/>
        public static void Exercice2(int nb1, int nb2)
        {
            Console.WriteLine($"Premier entier : {nb1}");
            Console.WriteLine($"Deuxième entier : {nb2}");
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice3'/>
        public static int Exercice3(int nb1, int nb2)
        {
            return nb1 + nb2;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice4'/>
        public static double Exercice4()
        {
            Console.Write("Entrer un nombre : ");
            if (double.TryParse(Console.ReadLine(), out double nb))
            {
                return nb;
            }
            else
            {
                throw new FormatException("Ce n'est pas un nombre");
            }
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice5'/>
        public static int Exercice5()
        {
            Console.Write("Entrer un nombre : ");
            string entrer = Console.ReadLine()!;
            if (entrer == null)
            {
                Debug.WriteLine("Entrée vide", "Exercice 5");
                return -1;
            }
            if (int.TryParse(entrer, out int nb))
            {
                if (nb <= 0)
                {
                    Debug.WriteLine("Nombre inférieure a 0", "Exercice 5");
                    return -1;
                }
                else
                { return nb; }
            }
            else
            {
                Debug.WriteLine("L'entrée n'est pas un nombre", "Exercice 5");
                return -1;
            }
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice6'/>
        public static int Exercice6()
        {
            bool valide = false;
            int nb = 0;
            while (!valide)
            {
                Console.Write("Entrer un nombre supérieur a 10 : ");
                if (int.TryParse(Console.ReadLine(), out nb))
                {
                    if (nb > 10)
                    {
                        valide = true;
                    }
                    else
                    {
                        Debug.WriteLine("Nombre inférieure a 10", "Exercice 6");
                    }
                }
                else
                {
                    Debug.WriteLine("L'entrée n'est pas un nombre", "Exercice 6");
                }
            }
            return nb;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice7'/>
        public static int Exercice7(int nb1, int nb2)
        {
            if (nb2 == 0)
            {
                Debug.WriteLine("Division par 0", "Exercice 7");
                return 0;
            }
            else
            {
                return nb1 / nb2;
            }
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice8'/>
        public static int[] Exercice8(uint longueur)
        {
            return new int[longueur];
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice9'/>
        public static int[] Exercice9(uint longueur, int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentOutOfRangeException(nameof(min), $"Le minimum {min} doit etre inferieur au maximum {max}");
            }
            Random rnd = new Random();
            int[] tabRnd = new int[longueur];
            for (int i = 0; i < tabRnd.Length; i++)
            {
                tabRnd[i] = rnd.Next(min, max);
            }
            return tabRnd;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice10'/>
        public static int[] Exercice10(uint longueur, int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentOutOfRangeException(nameof(min), $"Le minimum {min} doit etre inferieur au maximum {max}");
            }
            Random rnd = new Random();
            int[] tabRnd = new int[longueur];
            for (int i = 0; i < tabRnd.Length; i++)
            {
                tabRnd[i] = rnd.Next(min, max + 1);
            }
            return tabRnd;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice11'/>
        public static int[] Exercice11(uint longueur, int min, int max)
        {
            if (min > max)
            {
                Debug.WriteLine($"Le minimum {min} doit etre inferieur au maximum {max}, inversion des valeurs", "Exercice 11");
            }

            Random rnd = new Random();
            int[] tabRnd = new int[longueur];

            if (min > max)
            {
                // Utiliser le tuple pour échanger des valeurs (IDE0180)
                (max, min) = (min, max);
            }

            for (int i = 0; i < tabRnd.Length; i++)
            {
                tabRnd[i] = rnd.Next(min, max + 1);
            }
            return tabRnd;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice12'/>
        public static int[] Exercice12(int longueur, int min, int max)
        {

            if (longueur < 0)
            {
                Debug.WriteLine($"La longueur doit etre positive", "Exercice 12");
                return [];
            }

            if (min > max)
            {
                Debug.WriteLine($"Le minimum {min} doit etre inferieur au maximum {max}, inversion des valeurs", "Exercice 12");
            }

            Random rnd = new Random();

            int[] tabRnd = new int[longueur];

            if (min > max)
            {
                // Utiliser le tuple pour échanger des valeurs (IDE0180)
                (max, min) = (min, max);
            }

            for (int i = 0; i < tabRnd.Length; i++)
            {
                tabRnd[i] = rnd.Next(min, max + 1);
            }
            return tabRnd;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice13'/>
        public static int Exercice13(int[] tab)
        {
            if (tab is null)
            {
                throw new ArgumentNullException(nameof(tab), "Le tableau ne peut pas etre null");
            }

            if (tab.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tab));
            }

            int total = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                total += tab[i];
            }
            return total;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice14'/>
        public static int Exercice14(int[] tab)
        {
            if (tab is null)
            {
                throw new ArgumentNullException(nameof(tab), "Le tableau ne peut pas etre null");
            }
            if (tab.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tab));
            }
            int total = 0;
            foreach (int num in tab)
            {
                total += num;
            }
            return total;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice15'/>
        public static int Exercice15(int[] tab)
        {
            if (tab is null)
            {
                throw new ArgumentNullException(nameof(tab), "Le tableau ne peut pas etre null");
            }
            if (tab.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tab));
            }
            int total = 0;
            int index = 0;
            while (index < tab.Length)
            {
                total += tab[index];
                index++;
            }
            return total;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice16'/>
        public static int Exercice16(int[] tab)
        {
            if (tab is null)
            {
                throw new ArgumentNullException(nameof(tab), "Le tableau ne peut pas etre null");
            }
            if (tab.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tab));
            }

            int total = 0;
            int index = 0;

            do
            {
                total += tab[index];
                index++;
            } while (index < tab.Length);

            return total;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice17'/>
        public static void Exercice17()
        {
            Console.WriteLine("***\n***\n***");
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice18'/>
        public static void Exercice18(uint largeur)
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

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice19'/>
        public static void Exercice19(int largeur)
        {
            if (largeur < 0)
            {
                Debug.WriteLine($"La largeur doit etre positive {largeur} , conversion en valeur absolue", "Exercice 19");
                largeur = Math.Abs(largeur);
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

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice20'/>
        public static void Exercice20(int largeur, int hauteur)
        {
            if (largeur < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(largeur), "Impossible d'afficher parce que la largeur trop petite ( < 1 )");
            }
            if (hauteur < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(hauteur), "Impossible d'afficher parce que la hauteur trop petite ( < 1 )");
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

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice21'/>
        public static void Exercice21(int largeur, int hauteur, char charac)
        {
            if (largeur < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(largeur), "Impossible d'afficher parce que la largeur trop petite ( < 1 )");
            }
            if (hauteur < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(hauteur), "Impossible d'afficher parce que la hauteur trop petite ( < 1 )");
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

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice22'/>
        public static void Exercice22(int largeur, int hauteur, uint nbsFois, char charac)
        {
            if (largeur < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(largeur), "Impossible d'afficher parce que la largeur trop petite ( < 1 )");
            }
            if (hauteur < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(hauteur), "Impossible d'afficher parce que la hauteur trop petite ( < 1 )");
            }
            for (int c = 0; c < nbsFois; c++)
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

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice23'/>
        public static void Exercice23(int longueur)
        {
            if (longueur < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(longueur), "Impossible d'afficher parce que la longueur trop petite ( < 0 )");
            }
            for (int i = longueur; i >= 0; i--)
            {
                for (int j = i; j < longueur; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice24'/>
        public static void Exercice24(int longueur)
        {
            if (longueur < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(longueur), "Impossible d'afficher parce que la longueur trop petite ( < 0 )");
            }
            int cpt1 = 0;
            while (cpt1 < longueur)
            {
                int cpt2 = cpt1;
                while (cpt2 < longueur)
                {
                    Console.Write("*");
                    cpt2++;
                }
                if (cpt1 <= longueur - 2)
                {
                    Console.Write("\n");
                }
                cpt1++;
            }
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice25'/>
        public static void Exercice25(int longueur)
        {
            if (longueur <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(longueur), "Impossible d'afficher parce que la longueur trop petite ( <= 0 )");
            }
            int cpt1 = 0;
            do
            {
                int cpt2 = cpt1;
                do
                {
                    Console.Write("*");
                    cpt2++;
                } while (cpt2 < longueur);
                Console.Write("\n");
                cpt1++;
            } while (cpt1 < longueur);
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice26'/>
        public static void Exercice26(int longueur)
        {
            if (longueur < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(longueur), "Impossible d'afficher parce que la longueur trop petite ( < 0 )");
            }
            Exercice24(longueur);
            Console.CursorTop -= 1;
            Exercice23(longueur);
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice27'/>
        public static string Exercice27(int longueur)
        {
            if (longueur < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(longueur), "Impossible d'afficher parce que la longueur trop petite ( < 0 )");
            }
            string str = "";
            for (int i = longueur; i > 0; i--)
            {
                for (int j = i; j < longueur + 1; j++)
                {
                    str += "*";
                    if (longueur != j)
                    {
                        str += " ";
                    }
                }
                if (i > 1)
                {
                    str += "\n";
                }
            }
            return str;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice28'/>
        public static double Exercice28(int[] tab)
        {
            if (tab is null)
            {
                Debug.WriteLine("Le tableau est null", "Exercice 28");
                return 0;
            }
            if (tab!.Length == 0)
            {
                Debug.WriteLine("Le tableau est vide", "Exercice 28");
                return 0;
            }
            double total = 0;
            foreach (double num in tab!)
            {
                total += num;
            }
            return total / tab.Length;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice29'/>
        public static double Exercice29(int[] tab)
        {
            if (tab is null)
            {
                throw new ArgumentNullException(nameof(tab), "Le tableau ne peut pas etre null");
            }
            if (tab!.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tab));
            }
            double moyenne = Exercice28(tab);
            double[] ecarts = new double[tab.Length];
            double total = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                ecarts[i] = tab[i] - moyenne;
                if (ecarts[i] < 0)
                {
                    ecarts[i] *= -1;
                }
                total += ecarts[i];
            }
            return total / tab.Length;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice31'/>
        public static Personne[] Exercice31(int nbsPers, int ageMin, int ageMax, string[] prenom, string[] nom)
        {
            if (nbsPers < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(nbsPers), "Le nombre de personnes doit être positif");
            }
            if (ageMin < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ageMin), "L'âge minimum doit être positif");
            }
            if (ageMax < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ageMax), "L'âge maximum doit être positif");
            }
            if (ageMin > ageMax)
            {
                throw new ArgumentException("L'âge minimum doit être inférieur ou égal au maximum", "ageMin/ageMax");
            }
            if (prenom == null)
            {
                throw new ArgumentNullException(nameof(prenom), "Le tableau de prénoms ne peut pas être null");
            }
            if (prenom.Length == 0)
            {
                throw new ArgumentException("Le tableau de prénoms ne peut pas être vide", nameof(prenom));
            }
            if (nom == null)
            {
                throw new ArgumentNullException(nameof(nom), "Le tableau de noms ne peut pas être null");
            }
            if (nom.Length == 0)
            {
                throw new ArgumentException("Le tableau de noms ne peut pas être vide", nameof(nom));
            }
            Personne[] lstPers = new Personne[nbsPers];
            Random rng = new();

            for (int i = 0; i < nbsPers; i++)
            {
                lstPers[i] = new Personne(
                    prenom![rng.Next(prenom.Length)],
                    nom![rng.Next(nom.Length)],
                    rng.Next(ageMin, ageMax + 1)
                );
            }

            return lstPers;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice32'/>
        public static double Exercice32(Personne[] tab)
        {
            if (tab is null)
            {
                throw new ArgumentNullException(nameof(tab), "Le tableau ne peut pas etre null");
            }
            if (tab!.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tab));
            }

            int[] tabIntPersonnes = new int[tab.Length];

            for (int i = 0; i < tab.Length; i++)
            {
                tabIntPersonnes[i] = tab[i].Age;
            }

            return Exercice28(tabIntPersonnes);
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice33'/>
        public static Personne Exercice33(Personne[] tab)
        {
            if (tab is null)
            {
                throw new ArgumentNullException(nameof(tab), "Le tableau ne peut pas etre null");
            }
            if (tab!.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tab));
            }
            int plusHaut = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[plusHaut].Age < tab[i].Age)
                {
                    plusHaut = i;
                }
            }
            return tab[plusHaut];
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice34'/>
        public static void Exercice34(int[] tabInt, int pos1, int pos2)
        {
            if (tabInt is null)
            {
                throw new ArgumentNullException(nameof(tabInt), "Le tableau ne peut pas etre null");
            }
            if (tabInt.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt));
            }
            if (pos1 < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pos1), $"Position 1 est inferieur a 0 ( pos : {pos1})");
            }
            if (pos2 < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pos2), $"Position 2 est inferieur a 0 ( pos : {pos2})");
            }
            if (pos1 > tabInt.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(pos1), $"Position 1 est superieur a la longueur du tableau ( pos : {pos1})");
            }
            if (pos2 > tabInt.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(pos2), $"Position 2 est superieur a la longueur du tableau ( pos : {pos2})");
            }

            // Utilisation du tuple (IDE0180)
            (tabInt[pos1], tabInt[pos2]) = (tabInt[pos2], tabInt[pos1]);
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice35'/>
        public static void Exercice35(int[] tabInt)
        {
            if (tabInt is null)
            {
                throw new ArgumentNullException(nameof(tabInt), "Le tableau ne peut pas etre null");
            }
            if (tabInt.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt));
            }
            int[] tempTab = new int[tabInt.Length];

            for (int i = 0; i < tabInt.Length; i++)
            {
                tempTab[i] = tabInt[i];
            }

            for (int i = 0; i < tabInt.Length; i++)
            {
                tabInt[tabInt.Length - 1 - i] = tempTab[i];
            }
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice36'/>
        public static void Exercice36(int[] tabInt)
        {
            if (tabInt is null)
            {
                throw new ArgumentNullException(nameof(tabInt), "Le tableau ne peut pas etre null");
            }
            if (tabInt.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt));
            }
            int longueur = tabInt.Length;
            int milieu = longueur / 2;
            int milieuImpair = longueur % 2;

            int[] premParti = new int[milieu];
            int[] deuxParti = new int[milieu];

            for (int i = 0; i < milieu; i++)
            {
                premParti[i] = tabInt[i];
            }

            for (int i = 0; i < milieu; i++)
            {
                deuxParti[i] = tabInt[milieu + milieuImpair + i];
            }

            for (int i = 0; i < milieu; i++)
            {
                tabInt[i] = deuxParti[i];
            }

            if (milieuImpair == 1)
            {
                tabInt[milieu] = tabInt[milieu];
            }

            for (int i = 0; i < milieu; i++)
            {
                tabInt[milieu + milieuImpair + i] = premParti[i];
            }
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice37'/>
        public static int Exercice37(char[] tabC, char c)
        {
            if (tabC is null)
            {
                throw new ArgumentNullException(nameof(tabC), "Le tableau ne peut pas etre null");
            }
            if (tabC.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabC));
            }
            if (c == '\0')
            {
                throw new ArgumentException("Le caractere ne peut pas etre vide", nameof(c));
            }
            for (int i = 0; i < tabC.Length; i++)
            {
                if (tabC[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice38'/>
        public static int Exercice38(int[] tabInt)
        {
            if (tabInt is null)
            {
                throw new ArgumentNullException(nameof(tabInt), "Le tableau ne peut pas etre null");
            }
            if (tabInt.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt));
            }
            for (int i = 0; i < tabInt.Length; i++)
            {
                for (int j = i + 1; j < tabInt.Length; j++)
                {
                    if (tabInt[i] == tabInt[j])
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice39'/>
        public static int[] Exercice39(int[] tabInt)
        {
            if (tabInt is null)
            {
                throw new ArgumentNullException(nameof(tabInt), "Le tableau ne peut pas etre null");
            }
            if (tabInt.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt));
            }
            List<int> dejaVue = new List<int>();
            List<int> tabIndexDoublons = new List<int>();

            for (int i = 0; i < tabInt.Length; i++)
            {
                if (!dejaVue.Contains(tabInt[i]))
                {
                    dejaVue.Add(tabInt[i]);

                    // Vérifie s'il y a au moins un doublon
                    for (int j = i + 1; j < tabInt.Length; j++)
                    {
                        if (tabInt[i] == tabInt[j])
                        {
                            tabIndexDoublons.Add(i);
                            continue;
                        }
                    }
                }
            }
            return tabIndexDoublons.ToArray();
        }

        // / <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice40'/>
        public static int[] Exercice40(int[] tabInt1, int[] tabInt2)
        {
            if (tabInt1 is null)
            {
                throw new ArgumentNullException(nameof(tabInt1), "Le tableau ne peut pas etre null");
            }
            if (tabInt1.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt1));
            }
            if (tabInt2 is null)
            {
                throw new ArgumentNullException(nameof(tabInt2), "Le tableau ne peut pas etre null");
            }
            if (tabInt2.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt2));
            }
            int[] tabFusion = new int[tabInt1.Length + tabInt2.Length];
            int i = 0;
            for (int j = 0; j < tabInt1.Length; j++)
            {
                tabFusion[i] = tabInt1[j];
                i++;
            }
            for (int j = 0; j < tabInt2.Length; j++)
            {
                tabFusion[i] = tabInt2[j];
                i++;
            }
            return tabFusion;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice41'/>
        public static int[] Exercice41(int[] tabInt)
        {
            if (tabInt is null)
            {
                throw new ArgumentNullException(nameof(tabInt), "Le tableau ne peut pas etre null");
            }
            if (tabInt.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt));
            }
            int[] tabResultat = new int[2];
            for (int i = 0; i < tabInt.Length; i++)
            {
                if (tabInt[i] % 2 == 0)
                {
                    tabResultat[0] += tabInt[i];
                }
                else
                {
                    tabResultat[1] += tabInt[i];
                }
            }
            return tabResultat;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice42'/>
        public static int[] Exercice42(int longueur)
        {
            if (longueur < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(longueur), "Longueur inferieur a 0");
            }
            int[] tabPal = new int[longueur];
            int gauche = 0;
            int droite = longueur - 1;
            int valeur = 0;

            while (gauche <= droite)
            {
                tabPal[gauche] = valeur;
                tabPal[droite] = valeur;
                gauche++;
                droite--;
                valeur++;
            }

            return tabPal;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice43'/>
        public static int[] Exercice43(int[] tabInt, int decalage)
        {
            if (tabInt is null)
            {
                throw new ArgumentNullException(nameof(tabInt), "Le tableau ne peut pas etre null");
            }
            if (tabInt.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt));
            }
            if (decalage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(decalage), "Decalage inferieur a 0");
            }
            int[] tempTab = new int[tabInt.Length];

            for (int i = 0; i < tabInt.Length; i++)
            {
                if (i + decalage < tabInt.Length)
                {
                    tempTab[i + decalage] = tabInt[i];
                }
            }
            return tempTab;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice44'/>
        public static int[] Exercice44(int[] tabInt, int decalage)
        {
            if (tabInt is null)
            {
                throw new ArgumentNullException(nameof(tabInt), "Le tableau ne peut pas etre null");
            }
            if (tabInt.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt));
            }
            if (decalage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(decalage), "Decalage inferieur a 0");
            }
            int[] tabSortie = new int[decalage];
            int index = 0;
            for (int i = tabInt.Length - decalage; i < tabInt.Length; i++)
            {
                tabSortie[index] = tabInt[i];
                index++;
            }
            return tabSortie;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice45'/>
        public static void Exercice45(int[] tabInt, int decalage)
        {
            if (tabInt is null)
            {
                throw new ArgumentNullException(nameof(tabInt), "Le tableau ne peut pas etre null");
            }
            if (tabInt.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt));
            }
            if (decalage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(decalage), "Decalage inferieur a 0");
            }
            int longueur = tabInt.Length;
            decalage %= Math.Abs(longueur);

            int[] debutTab = Exercice44(tabInt, decalage);
            int[] finTab = Exercice43(tabInt, decalage);

            int index = 0;

            for (int i = 0; i < debutTab.Length; i++)
            {
                tabInt[index++] = debutTab[i];
            }
            for (int i = decalage; i < finTab.Length; i++)
            {
                tabInt[index++] = finTab[i];
            }
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice46'/>
        public static int[] Exercice46(int[] tabInt)
        {
            if (tabInt is null)
            {
                throw new ArgumentNullException(nameof(tabInt), "Le tableau ne peut pas etre nul");
            }
            if (tabInt.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabInt));
            }
            foreach (int num in tabInt)
            {
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(tabInt), "Un des elements du tableau est inferieur a 0");
                }
            }
            int longueur = tabInt.Max() + 1;
            int[] tabCompte = new int[longueur];

            for (int i = 0; i < tabInt.Length; i++)
            {
                tabCompte[tabInt[i]]++;
            }

            return tabCompte;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice47'/>
        public static int Exercice47(int[] tabInt)
        {
            if (tabInt is null)
            {
                Debug.WriteLine("Tableau null", "Exercice 47");
                return -1;
            }
            if (tabInt.Length == 0)
            {
                Debug.WriteLine("Longueur tableau nulle", "Exercice 47");
                return -1;
            }
            int[] tabCompte = Exercice46(tabInt);
            for (int i = 0; i < tabInt.Length; i++)
            {
                if (tabCompte[tabInt[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice48'/>
        public static int[] Exercice48(int longueur)
        {
            if (longueur < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(longueur), "Longueur inferieur a 0");
            }
            int[] suite = new int[longueur];
            suite[0] = 0;
            suite[1] = 1;

            for (int i = 2; i < longueur; i++)
            {
                suite[i] = suite[i - 2] + suite[i - 1];
            }

            return suite;
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice49'/>
        public static int[] Exercice49(int[] tab1, int[] tab2)
        {
            if (tab1 is null)
            {
                throw new ArgumentNullException(nameof(tab1), "Le tableau 1 ne peut pas etre null");
            }
            if (tab1.Length == 0)
            {
                throw new ArgumentException("Le tableau 1 ne peut pas etre vide", nameof(tab1));
            }
            if (tab2 is null)
            {
                throw new ArgumentNullException(nameof(tab2), "Le tableau 2 ne peut pas etre null");
            }
            if (tab2.Length == 0)
            {
                throw new ArgumentException("Le tableau 2 ne peut pas etre vide", nameof(tab2));
            }
            int[] tabSortie = new int[tab1.Length + tab2.Length];

            int cpt1 = 0;
            int cpt2 = 0;

            for (int i = 0; i < tabSortie.Length; i++)
            {
                if (cpt1 < tab1.Length && (cpt2 >= tab2.Length || tab1[cpt1] < tab2[cpt2]))
                {
                    tabSortie[i] = tab1[cpt1];
                    cpt1++;
                    Debug.WriteLine($"cpt1 = {cpt1}", "Exercice 49");
                }
                else
                {
                    tabSortie[i] = tab2[cpt2];
                    cpt2++;
                    Debug.WriteLine($"cpt2 = {cpt2}", "Exercice 49");
                }
                Debug.WriteLine($"i = {i}", "Exercice 49");
            }

            return tabSortie;
        }

        ///<include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice50'/>
        public static void Exercice50(int[] tab)
        {
            if (tab is null)
            {
                throw new ArgumentNullException(nameof(tab), "Le tableau ne peut pas etre null");
            }
            if (tab.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tab));
            }
            int n = tab.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        // Utiliser le tuple pour échanger des valeurs (IDE0180)
                        (tab[j], tab[j + 1]) = (tab[j + 1], tab[j]);
                    }
                }
            }
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice51'/>
        public static void Exercice51(int[] tab)
        {
            if (tab is null)
            {
                throw new ArgumentNullException(nameof(tab), "Le tableau ne peut pas etre null");
            }
            if (tab.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tab));
            }
            for (int i = 0; i < tab.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Utiliser le tuple pour échanger des valeurs (IDE0180)
                (tab[i], tab[minIndex]) = (tab[minIndex], tab[i]);
            }
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice52'/>
        public static void Exercice52(int[] tab)
        {
            if (tab is null)
            {
                throw new ArgumentNullException(nameof(tab), "Le tableau ne peut pas etre null");
            }
            if (tab.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tab));
            }
            for (int i = 1; i < tab.Length; i++)
            {
                int valeurAPlacer = tab[i];
                int j = i - 1;

                while (j >= 0 && tab[j] > valeurAPlacer)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }

                tab[j + 1] = valeurAPlacer;
            }
        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice53'/>
        public static void Exercice53(Personne[] tabPersonnes)
        {
            if (tabPersonnes is null)
            {
                throw new ArgumentNullException(nameof(tabPersonnes), "Le tableau ne peut pas etre null");
            }
            if (tabPersonnes.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide", nameof(tabPersonnes));
            }
            for (int i = 0; i < tabPersonnes.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < tabPersonnes.Length; j++)
                {
                    if (tabPersonnes[j].Age < tabPersonnes[minIndex].Age)
                    {
                        minIndex = j;
                    }
                }

                // Utiliser le tuple pour échanger des valeurs (IDE0180)
                (tabPersonnes[i], tabPersonnes[minIndex]) = (tabPersonnes[minIndex], tabPersonnes[i]);
            }

        }

        /// <include file='../Doc.xml' path='Doc/Exercice.cs/Methodes/Exercice54'/>
        public static int Exercice54(Personne pers1, Personne pers2)
        {
            if (pers1 is null)
            {
                throw new ArgumentNullException(nameof(pers1), "La personne 1 ne peut pas etre null");
            }
            if (pers2 is null)
            {
                throw new ArgumentNullException(nameof(pers2), "La personne 2 ne peut pas etre null");
            }
            if (pers1.Age == pers2.Age)
            {
                return 0;
            }
            else if (pers1.Age > pers2.Age)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        #endregion

    }
}