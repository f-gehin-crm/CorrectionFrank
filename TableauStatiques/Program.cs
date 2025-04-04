namespace TableauStatiques
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                double[] tabnombres;


                int nb;
                string reponse;
                bool test = true;

                double somme;
                do
                {
                    Console.WriteLine("veuillez saisir combien de nombre pour le  calcul de la moyenne : nb");
                    if (int.TryParse(Console.ReadLine(), out nb))
                    {
                        tabnombres = new double[nb];

                        Console.WriteLine("Veuillez saisir les  " + nb + "nombres séparé par un espace ");
                        string[] tabchaine = (Console.ReadLine()).Split(' ');
                        for (int i = 0; i < tabchaine.Length; i++)
                        {
                            tabnombres[i] = double.Parse(tabchaine[i]);


                        }
                        //tabnombres = Array.ConvertAll(tabchaine, double.Parse);

                        somme = 0;
                        foreach (double item in tabnombres)
                        {
                            somme += item;
                        }
                        double moyenneA = somme / nb;


                        Console.WriteLine("La moyenne arythmétique des N : {0:#,###} nombres est de  : {1: #,###.00}", nb, moyenneA);
                        Console.ReadLine();

                    }
                    else
                    {
                        test = false;
                    }

                } while (!test);




            
        }
    }
}
   
