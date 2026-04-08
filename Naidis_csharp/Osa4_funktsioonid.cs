namespace Naidis_csharp
{
    internal class Osa4_funktsioonid
    {
        static List<string> kuude_list = new List<string>()
        {
            "jaanuar",
            "veebruar",
            "märts",
            "aprill",
            "mai",
            "juuni",
            "juuli",
            "august",
            "september",
            "oktoober",
            "november",
            "detsember"
        };

        public static void Faili_kirjutamine()
        {
            try
            {
                string path = @"..\..\..\Kuud.txt";//@"..\..\..\Kuud.txt"
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(lause);
                }
                Console.WriteLine("Uued laused on lisatud");

            }
            catch (Exception e)
            {
                Console.WriteLine("Mingi viga failiga");
            }

        }
        public static void Faili_lugemine()
        {
            try
            {
                string path = @"..\..\..\Kuud.txt";
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }

        public static void Ridade_lugemine(string file)
        {

            List<string> kuude_list = new List<string>();
            try
            {

                string path = @$"..\..\..\{file}";
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
                foreach (string i in kuude_list) Console.WriteLine(i);
            }

            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }

        }
        public static List<string> Ridade_lugemine_listiks(string file)
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = @$"..\..\..\{file}";
                if (File.Exists(path))
                {
                    // ReadAllLines handles the loop for you internally
                    string[] ridad = File.ReadAllLines(path);
                    kuude_list.AddRange(ridad);
                }
                else
                {
                    // This prevents the "nothing happens" problem
                    Console.WriteLine($"VIGA: Faili ei leitud! Otsisin siit: {path}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
            return kuude_list;
        }
        public static List<string> Listi_muutmine_kuvamine()
        {
            try
            {
                while (true)
                {
                    foreach (string k in kuude_list)
                    {
                        Console.WriteLine(k);
                    }
                    Console.Write("\nSisesta mida sa tahad kustuta: ");
                    string kuu = Console.ReadLine();
                    kuude_list.Remove($"{kuu}");
                    if (kuude_list.Count > 0)
                    {
                        kuude_list[0] = "Midagi oli siin";
                    }
                    Console.WriteLine("--------------Kustutasime kuu-----------");
                    foreach (string k in kuude_list)
                    {
                        Console.WriteLine(k);
                    }
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return kuude_list;
        }
        public static void Otsing_nimekirjast()
        {
            try
            {
                string otsitav = "";
                List<string> kuude_list = Ridade_lugemine_listiks("Kuud.txt");

                if (kuude_list == null || kuude_list.Count == 0)
                {
                    Console.WriteLine("Nimekiri on tühi. Ei saa midagi otsida.");
                    return;
                }
                while (true)
                {
                    Console.Write("Sisesta kuu nimi, mida tahad otsida: ");
                    otsitav = Console.ReadLine();
                    if (kuude_list.Contains(otsitav))
                    {
                        Console.WriteLine($"Kuu {otsitav} on olemas.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sellist kuud pole.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void Listi_salvestamine()
        {
            string path = @"..\..\..\Kuud.txt";
            File.WriteAllLines(path, kuude_list);
            Console.WriteLine("Andmed on salvestatud.");
        }
    }
}
