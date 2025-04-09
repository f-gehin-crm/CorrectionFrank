namespace DenombrementLettre
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                int[] tabfrequences = new int[26];
                char[] tabalphabet = new char[26];
                string phraseSaisie;
                char lettre;


                char test;


                for (int i = 0; i < tabfrequences.Length; i++)
                {
                    tabfrequences[i] = 0;
                }

                lettre = 'a';
                for (int i = 0; i < tabalphabet.Length; i++)
                {
                    tabalphabet[i] = lettre;
                    lettre++;
                }
                Program.Affichertableau(tabalphabet);

                do
                {
                    Console.WriteLine("Veuillez saisir un texte d'au moins 120 caractères ! ");
                    phraseSaisie = (Console.ReadLine()).Trim().ToLower();


                } while (phraseSaisie.Length < 120);



                phraseSaisie = Program.filtreaccent(phraseSaisie);

                // Console.WriteLine(phraseSaisie );

                for (int i = 0; i < tabalphabet.Length; i++)
                {
                    test = tabalphabet[i];
                    for (int j = 0; j < phraseSaisie.Length; j++)
                    {
                        if (phraseSaisie[j].Equals(test))
                        {
                            tabfrequences[i] += 1;
                        }


                    }



                }
                AffichertableauNb(tabfrequences);


                Console.WriteLine(" Voici la  frequence d'apparition des lettres presentent dans la phrase saisie !");

                for (int i = 0; i < tabfrequences.Length; i++)
                {

                    if (tabfrequences[i] > 0)
                    {

                        Console.WriteLine($"la lettre : {tabalphabet[i]} est présente : {tabfrequences[i]}  fois !");

                    }

                }

            }


            public static void Affichertableau(char[] _untab)
            {
                Console.Write("\n [ ");
                foreach (char element in _untab)
                {
                    Console.Write(element + " ");
                }
                Console.Write("]\n");
            }

            public static void AffichertableauNb(int[] _untab)
            {
                Console.Write("\n [ ");
                foreach (int element in _untab)
                {
                    Console.Write(element + " ");
                }
                Console.Write("]\n");
            }



            static public string filtreaccent(string _Phrase)
            {
                _Phrase = _Phrase.Replace(" ", string.Empty);
                _Phrase = _Phrase.Replace("è", "e");
                _Phrase = _Phrase.Replace("é", "e");
                _Phrase = _Phrase.Replace("ê", "e");
                _Phrase = _Phrase.Replace("ë", "e");
                _Phrase = _Phrase.Replace("à", "a");
                _Phrase = _Phrase.Replace("ù", "u");
                _Phrase = _Phrase.Replace("î", "i");
                _Phrase = _Phrase.Replace("ô", "o");
                _Phrase = _Phrase.Replace("œ", "oe");
                _Phrase = _Phrase.Replace("â", "a");
                _Phrase = _Phrase.Replace("ï", "i");
                _Phrase = _Phrase.Replace("'", "");
                _Phrase = _Phrase.Replace(",", "");
                _Phrase = _Phrase.Replace(";", "");
                _Phrase = _Phrase.Replace("-", "");
                _Phrase = _Phrase.Replace(".", "");
                return _Phrase;

            }
        }
    }
   
