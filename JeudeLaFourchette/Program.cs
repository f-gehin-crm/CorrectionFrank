namespace JeudeLaFourchette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int max = 100;
                int min = 0;
                int compteur = 1;
                Random aleas = new Random();
                int nbOrdinateur = aleas.Next(0, 101);
                int nbJoueur;
                bool testinterval = false;

                do
                {
                    do
                    {
                        Console.WriteLine(" Veuillez entrer un nb entre " + min + " et " + max + " pour rechercher le nombre généré : c'est votre essai numero :" + compteur);
                        if (int.TryParse(Console.ReadLine(), out nbJoueur) && nbJoueur >= min && nbJoueur <= max)
                        {
                            testinterval = true;

                        }
                        compteur++;
                    } while (testinterval == false);


                    if (nbJoueur > nbOrdinateur)
                    {
                        //    compteur++;
                        max = nbJoueur;


                    }
                    else if (nbJoueur < nbOrdinateur)
                    {
                        //   compteur++;

                        min = nbJoueur;
                    }
                    else
                    {

                        Console.WriteLine("Bravo vous avez gagné en {0} le  nombre est  : {1}", compteur, nbJoueur);
                    }



                    testinterval = false;


                } while (nbJoueur != nbOrdinateur);



                Console.ReadKey();

            
        }
    }
}
