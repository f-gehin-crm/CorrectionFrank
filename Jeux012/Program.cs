namespace Jeux012
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                int scoreBot = 0;
                int scoreJoueur = 0;
                int nbBot;
                int nbJoueur;
                bool continuer;
                int diff;

                do
                {
                    do
                    {
                        Console.WriteLine(" veuillez saisir un chiffre entre 0 et 2 :");
                        continuer = int.TryParse(Console.ReadLine(), out nbJoueur);


                    } while (continuer == false || nbJoueur >= 3);
                    Random aleas = new Random();
                    nbBot = aleas.Next(0, 3);
                    diff = Math.Abs(nbJoueur - nbBot);
                    switch (diff)
                    {
                        case 2:
                            if (nbJoueur > nbBot)
                            {
                                scoreJoueur++;
                                Console.WriteLine($"Le joueur gagne un point {scoreJoueur}");
                            }
                            else
                            {
                                scoreBot++;


                                Console.WriteLine($" la machine gagne un point {scoreBot}");
                            }


                            break;
                        case 1:

                            if (nbJoueur < nbBot)
                            {
                                scoreJoueur++;
                                Console.WriteLine($"Le joueur gagne un point {scoreJoueur}");
                            }
                            else
                            {
                                scoreBot++;


                                Console.WriteLine($" la machine gagne un point {scoreBot}");
                            }

                            break;

                        case 0:
                            Console.WriteLine($"egalité aucun joueur ne marque un point : joueur : {scoreJoueur}  et bot machine :{scoreBot} ");
                            break;


                        default:

                            break;
                    }






                } while (scoreBot < 10 && scoreJoueur < 10 && nbJoueur >= 0);

                if (nbJoueur < 0)
                {
                    Console.WriteLine($"vous avez decidé  d'arrêter la partie  et votre score est {scoreJoueur} et celui de l'ordinateur est: {scoreBot}");

                }
                else if (scoreBot == 10)
                {
                    Console.WriteLine(" L'ordinateur a gagné !");
                }
                else
                {

                    Console.WriteLine("Bravo vous avez gagné! ");
                }



            
        }
    }
}
