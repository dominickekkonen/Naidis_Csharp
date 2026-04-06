using Naidis_csharp;
using System.Collections;

namespace Naidis_csharp
{
    internal class osa5_funktsioonid
    {
        public static void array_naide()
        {
            ArrayList nimed = new ArrayList();
            {
                nimed.Add("Kati");
                nimed.Add("Mati");
                nimed.Add("Juku");
                if (nimed.Contains("Mati"))
                    Console.WriteLine("Mati olemas");
                Console.WriteLine("Nimesid kokku: " + nimed.Count);
                nimed.Insert(1, "Sass");
                Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
                Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));
                nimed.Sort();
                foreach (string nimi in nimed)
                    Console.WriteLine(nimi);
            }
        }
        public static void Tuple()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }
        public static void LinkedList()
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);
            Console.WriteLine("-----------------------------");
            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            loetelu.Remove(555);
            LinkedListNode<int> a = loetelu.Find(5);
            loetelu.AddBefore(a, 11);

            loetelu.AddAfter(a, 22);
            Console.WriteLine("-----------------------------");
            foreach (int arv in loetelu)
                Console.WriteLine(arv);
        }
        public static void sonatlik()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>();
            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            riigid.ContainsKey(1);
            riigid.ContainsValue("Itaalia");

            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            string pealinn = riigid[2];
            riigid[2] = "Eestimaa";
            riigid.Remove(3);

        }




    }



    public class Person
    {
        public string Name { get; set; }


        public Person(string name)
        {
            Name = name;
        }

        public Person()
        {
        }

        public static void sonatlikKlassiga()
        {
            Dictionary<char, Person> inimesed = new Dictionary<char, Person>();
            inimesed.Add('k', new Person() { Name = "Kadi" });
            inimesed.Add('m', new Person() { Name = "Mait" });

            foreach (var entry in inimesed)
                Console.WriteLine($"{entry.Key} - {entry.Value.Name}");
        }
        public static void List_klassiga()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }
        public static void Remove_Listist()
        {
            List<Person> people = new List<Person>();
            people.Remove(new Person() { Name = "Kadi" });

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        public static void Insert_Listisse()
        {
            List<Person> people = new List<Person>();
            people.Insert(1, new Person() { Name = "Kadi" });
            people.Remove(new Person() { Name = "Mirje" });
            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }
        public static void kustuta_objekt()
        {

            List<Person> people = new List<Person>();

            foreach (Person p in people)
                Console.WriteLine(p.Name);
            Person p1 = new Person() { Name = "Kadi" };
            people.Add(p1);

            Console.WriteLine($"Person 1 index on: {people.FindIndex(p => p.Name == "Kadi")}");
            people.Remove(p1);
            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }
        public static void remove_objekt2()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });

            people.Remove(new Person("Lisa"));
        }
        public static void remove_lamda_abil()
        {
            List<Person> people = new List<Person>();
            Person p1 = new Person() { Name = "Kadi" };
            people.Add(p1);
            int i = people.FindIndex(p => p.Name == "Kadi");
            people.RemoveAt(i);
            Console.WriteLine($"Person kustutanud on: {i}; {p1.Name}");
        }

        public static void list_sort_ja_remove()
        {
            List<string> people = new List<string>() { "Kadi", "Anna" };
            people.Sort();

            foreach (string p in people)
                Console.WriteLine(p);
            int nimi1 = people.BinarySearch("Kadi");
            Console.WriteLine(nimi1);

            Console.WriteLine("Sisesta nimi: ");
            string nimi = Console.ReadLine();
            people.Remove(nimi);
            foreach (string p in people)
                Console.WriteLine(p);

            //people.Sort((a, b) => a.Length.CompareTo(b.Length));
            //foreach (string p in people)
            //    Console.WriteLine(p);
        }
    }
}
// OSA 5 ÜLESANDED

public class Toode
{
    static string Nimi { get; set; }
    static string Kalorid100g { get; set; }
    public Toode(string name, string kalorid100g)
    {
        Nimi = name;
        Kalorid100g = kalorid100g;
    }
}
public class ulesanded
{
    public static void Toidu_salvestamine_faili()
    {
        try
        {
            string retseptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tooded.txt");
            if (File.Exists(retseptPath))
            {
                Console.WriteLine("Olemasolevad toidud");
                foreach (string rida in File.ReadAllLines(retseptPath))
                    Console.WriteLine($"  - {rida}");
                Console.WriteLine();
            }
            Console.Write("Sisesta uus toidu nimi: ");
            string toit = Console.ReadLine();
            using (StreamWriter retseptWriter = new StreamWriter(retseptPath, true))
            {
                Console.Write("sisesta kaal:  ");
                string kaal = Console.ReadLine();

                retseptWriter.Write($"{toit};{kaal}");
                retseptWriter.Close();
            }
            if (string.IsNullOrWhiteSpace(toit))
            {

                Console.WriteLine($"{toit} lisatud!");
            }
            Console.WriteLine(" Kõik salvestatud!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    public static void KaalKalkulaator(Inimene_osa5 inimene)
    {
        List<string> list = new List<string>();
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tooded.txt");
            foreach (string rida in File.ReadAllLines(path))
                list.Add(rida);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        double bmr;
        if (inimene.Sugu.ToLower() == "M")
            bmr = 88.362 + (13.397 * inimene.Kaal) + (4.799 * inimene.Pikkus) - (5.677 * inimene.Vanus);
        else
            bmr = 447.593 + (9.247 * inimene.Kaal) + (3.098 * inimene.Pikkus) - (4.330 * inimene.Vanus);
        double[] kordajad = { 1.2, 1.375, 1.55, 1.725, 1.9 };
        double kordaja = kordajad[inimene.Aktiivsustase - 1];
        double paevaneKalorid = bmr * kordaja;
        Console.WriteLine($"Iga päev te peate sööma: \n{paevaneKalorid:F2} kcal");
        Console.Clear();
        double hommikusook = paevaneKalorid * 0.30;
        double lounasook = paevaneKalorid * 0.40;
        double ohtusook = paevaneKalorid * 0.30;
        Random rnd = new Random();
        List<string> toidud = list.OrderBy(x => rnd.Next()).ToList();
        string[] osad0 = toidud[0].Split(';');
        string[] osad1 = toidud[1].Split(';');
        string[] osad2 = toidud[2].Split(';');

        double kogus0 = hommikusook / double.Parse(osad0[1]) * 100;
        double kogus1 = lounasook / double.Parse(osad1[1]) * 100;
        double kogus2 = ohtusook / double.Parse(osad2[1]) * 100;
        Console.Clear();
        Console.WriteLine("Vali mida sa tahad: \n1 - Hommikusöök,\n2 - Lõunasöök,\n3 - Õhtusöök\n");
        int valik = int.Parse(Console.ReadLine());
        switch (valik)
        {
            case 1:
                Console.WriteLine($"Hommikusöök: {osad0[0]} {kogus0:F0}g  ({hommikusook:F0} kcal)");
                break;
            case 2:
                Console.WriteLine($"Lõunasöök:   {osad1[0]} {kogus1:F0}g  ({lounasook:F0} kcal)");
                break;
            case 3:
                Console.WriteLine($"Õhtusöök:    {osad2[0]} {kogus2:F0}g  ({ohtusook:F0} kcal)");
                break;
        }
    }
    public static void Maakonnad_pealinnad()
    {
        Dictionary<string, string> eesti = new Dictionary<string, string>();
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Eesti.txt");
        string[] data = new string[]
            {
                "Harjumaa;Tallinn",
                "Hiiumaa;Kärdla",
                "Pärnumaa;Pärnu",
                "Raplamaa;Rapla",
                "Ida-Virumaa;Jõhvi",
                "Jõgevamaa;Jõgeva",
                "Saaremaa;Kuressaare",
                "Tartumaa;Tartu",
                "Järvamaa;Paide",
                "Läänemaa;Haapsalu",
                "Valgamaa;Valga",
                "Viljandimaa;Viljandi",
                "Võrumaa;Võru",
                "Lääne-Virumaa;Rakvere",
                "Põlvamaa;Põlva"
            };
        File.WriteAllLines(path, data);
        try
        {
            foreach (string rida in File.ReadAllLines(path))
            {
                string[] osad = rida.Split(';');
                eesti.Add(osad[0], osad[1]);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        try
        {
            Console.WriteLine("kas sa tahad mängida Maakonnad_pealinnad (jah/ei)");
            string vastus = Console.ReadLine().ToLower();
            if (vastus == "jah")
            {
                string sisend = "";
                Random rnd = new Random();

                List<string> maakonnad = eesti.Keys.OrderBy(x => rnd.Next()).ToList();

                int kogemus = 0;
                foreach (string maakond in maakonnad)
                {
                    Console.WriteLine($"Mis on {maakond} keskus?");
                    sisend = Console.ReadLine().Trim();
                    sisend = char.ToUpper(sisend[0]) + sisend.Substring(1).ToLower();

                    if (sisend == eesti[maakond])
                    {
                        Console.WriteLine("Õige!");
                        kogemus++;
                    }
                    else
                    {
                        Console.WriteLine($"Vale! Õige vastus on {eesti[maakond]}");
                    }
                }
                double protsent = (double)kogemus / maakonnad.Count * 100;
                Console.WriteLine($"Tulemus: {kogemus}/{maakonnad.Count} = {protsent:F0}%");
                Console.Write("Sisesta maakond või linn: ");
                sisend = Console.ReadLine().Trim();
                sisend = char.ToUpper(sisend[0]) + sisend.Substring(1).ToLower(); // nagu .capitalize() Pythonis
                if (eesti.ContainsKey(sisend))
                {
                    Console.WriteLine($"{sisend} keskus on {eesti[sisend]}");
                }

                else if (eesti.ContainsValue(sisend))
                {
                    foreach (var paar in eesti)
                    {
                        if (paar.Value == sisend)
                        {
                            Console.WriteLine($"{sisend} asub maakonnas {paar.Key}");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{sisend} ei leitud!");
                    Console.Write("Kas soovid lisada? (jah/ei): ");
                    if (Console.ReadLine().ToLower() == "jah")
                    {
                        Console.Write("Sisesta maakond: ");
                        string maakond = Console.ReadLine();

                        Console.Write("Sisesta keskus: ");
                        string keskus = Console.ReadLine();

                        eesti.Add(maakond, keskus);
                        File.AppendAllText(path, $"{maakond};{keskus}");
                        Console.WriteLine("Lisatud!");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public static void opilased()
    {
        List<opilane> opilased = new List<opilane>();

        for (int i = 0; i < 3; i++)
        {
            try
            {
                while (true)
                {
                    List<int> hinded = new List<int>();
                    Console.Write("Sisesta õpilase nimi: ");
                    string nimi = Console.ReadLine();
                    for (int j = 0; j < 5; j++)
                    {

                        Console.Write("Sisesta õpilase hinded (1-5): ");
                        int hinne = int.Parse(Console.ReadLine());
                        if (hinne > 1 || hinne < 5)
                        {
                            hinded.Add(hinne);
                        }
                        else
                        {
                            Console.WriteLine("Hinded peab olema vahemikus 1-5");
                        }

                    }
                    opilane uus_opilane = new opilane(nimi, hinded);
                    opilased.Add(uus_opilane);
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Vale andmed");

            }

            opilased = opilased.OrderByDescending(o => o.Hinded.Average()).ToList();
            foreach (opilane opilane in opilased)
            {
                double keskmine = opilane.Hinded.Average();
                Console.WriteLine($"{opilane.Nimi} keskminehind: {keskmine}");

            }
            Console.WriteLine($"parim keskmine hind:  {opilased[0].Nimi} {opilased[0].Hinded.Average()} ");
        }
    }
}
