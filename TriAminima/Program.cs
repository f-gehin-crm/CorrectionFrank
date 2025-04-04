namespace TriAminima
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

                int nbcase = 0;
                int[] tabNombres;
                Console.WriteLine("Veuillez saisir le nombre de valeurs à intégrer au tableau :");
                nbcase = int.Parse(Console.ReadLine());
                tabNombres = new int[nbcase];
                for (int i = 0; i < tabNombres.Length; i++)
                {
                    Console.WriteLine("Veuillez saisir le nombre numero {0}/ {1} du tableau :", i + 1, nbcase);
                    tabNombres[i] = int.Parse(Console.ReadLine());

                }

                Program.AfficherTableau(tabNombres);
                TrierTableau(ref tabNombres);
                Console.WriteLine("talbleau trié par ordre croissant :");
                AfficherTableau(tabNombres);



            }

            public static void AfficherTableau(int[] _montab)
            {

                Console.Write("tableau:  \n[ ");

                foreach (int element in _montab)
                {
                    Console.Write(element + " ");
                }
                Console.Write("] \n");

            }
            public static void TrierTableau(ref int[] _montab)
            {
                int temp;

                int min;
                for (int i = 0; i < _montab.Length; i++)
                {
                    min = i;
                    for (int j = i + 1; j < _montab.Length; j++)
                    {
                        if (_montab[j] < _montab[min])
                        {
                            min = j;
                        }
                    }
                    temp = _montab[i];
                    _montab[i] = _montab[min];
                    _montab[min] = temp;


                }


            
        }
    }
}
