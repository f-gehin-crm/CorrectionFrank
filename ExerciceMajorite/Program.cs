namespace ExerciceMajorite
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                DateTime datenaissance;
                string chaineReponse;
                Console.WriteLine("veuillez entrer votre date de naissance S'il vous plait  au format? dd/mm/yyyy");
                chaineReponse = Console.ReadLine();
                string[] tabDate = chaineReponse.Split('/');
                datenaissance = new DateTime(int.Parse(tabDate[2]), int.Parse(tabDate[1]), int.Parse(tabDate[0]));

                ControleSaisie monControle = new ControleSaisie();


                bool estMajeur = monControle.Majorite(datenaissance);
                if (estMajeur)
                {
                    Console.WriteLine("vous êtes majeur vous pouvez entrer dnas l'application !!");
                }
                else
                {
                    Console.WriteLine("vous êtes mineur revenez nous voir plus tard !!");
                }



            }
        }

        class ControleSaisie
        {

            public bool Majorite(DateTime _maDate)
            {

                bool estMajeur;
                DateTime dateduJour = DateTime.Today;
                TimeSpan ecart = dateduJour.Subtract(_maDate);
                double nbannee = (ecart.Days) / 365.2425;
                if (nbannee >= 18)
                {

                    estMajeur = true;
                }
                else
                {
                    estMajeur = false;
                }



                return estMajeur;

            }



        }
    
}    
