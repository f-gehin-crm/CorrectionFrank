namespace AnnéeBisextile
{
    internal class Program
    {
        static void Main(string[] args)
           
            // TEST

            {
                string reponse;
                uint A;
                string choix;

                do
                {
                    Console.WriteLine("Veuillez saisir une annnée A entre  1900 et 2000 ?");
                    reponse = Console.ReadLine();
                    if (uint.TryParse(reponse, out A) == true)
                    {
                        if ((A % 4) == 0)
                        {
                            if ((A % 100) == 0)
                            {
                                if ((A % 400) == 0)
                                {
                                    Console.WriteLine("L'année A :" + A + " est  bissextile !");
                                }
                                else
                                {
                                    Console.WriteLine("L'année A :" + A + " n'est pas bissextile !");
                                }
                            }
                            else
                            {
                                Console.WriteLine("L'année A :" + A + " est  bissextile !");
                            }

                        }
                        else
                        {
                            Console.WriteLine("L'année A :" + A + " n'est pas bissextile !");
                        }





                    }
                    else
                    {
                        Console.WriteLine("saisie erronée veuillez recommencer !");
                    }
                    Console.WriteLine("voulez-vous recommencer avec une autre année ? oui/ non");
                    choix = (Console.ReadLine()).ToLower();

                } while (choix.Equals("oui"));

                Console.WriteLine("programme terminé!");



            }
        }
    }




       
    
