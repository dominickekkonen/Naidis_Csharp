namespace Naidis_csharp
{
    public class Inimene_osa5
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; }
        public double Pikkus { get; set; }
        public double Kaal { get; set; }
        public int Aktiivsustase { get; set; }

        public Inimene_osa5(string nimi, int vanus, string sugu, double pikkus, double kaal, int aktiivsustase)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            Pikkus = pikkus;
            Kaal = kaal;
            Aktiivsustase = aktiivsustase;
        }
        public static Inimene_osa5 GetInimene()
        {
            while (true)
                try
                {
                    Console.Write("Sisesta oma nimi: ");
                    string nimi = Console.ReadLine();

                    Console.Write("Sisesta vanus: ");
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus < 0 && vanus > 100)
                    {
                        Console.WriteLine("Vanus peab olema vahemikus 0-100");
                        continue;
                    }

                    Console.Write("Sisesta sugu (mees/naine): ");
                    string sugu = Console.ReadLine().ToLower();
                    if (sugu != "mees" && sugu != "naine")
                    {
                        Console.WriteLine("Sugu peab olema 'mees' või 'naine'");
                        continue;
                    }

                    Console.Write("Sisesta pikkus (cm): ");
                    double pikkus = double.Parse(Console.ReadLine());
                    if (pikkus < 50 || pikkus > 250)
                    {
                        Console.WriteLine("Pikkus peab olema vahemikus 50-250 cm");
                        continue;
                    }

                    Console.Write("Sisesta kaal (kg): ");
                    double kaal = double.Parse(Console.ReadLine());
                    if (kaal < 20 || kaal > 300)
                    {
                        Console.WriteLine("Kaal peab olema vahemikus 20-300 kg");
                        continue;
                    }

                    Console.Write("Sisesta aktiivsustase (1-5): ");

                    int aktiivsustase = int.Parse(Console.ReadLine());
                    if (aktiivsustase < 1 || aktiivsustase > 5)
                    {
                        Console.WriteLine("Aktiivsustase peab olema vahemikus 1-5");
                        continue;
                    }
                    Inimene_osa5 kasutaja = new Inimene_osa5(nimi, vanus, sugu, pikkus, kaal, aktiivsustase);
                    return kasutaja;

                }
                catch (Exception)
                {

                    Console.WriteLine("Vale andmed");
                }
        }
    }
}

public class opilane
{


    public string Nimi { get; set; }
    public List<int> Hinded { get; set; }


    public opilane(string? nimi, List<int> hinded)
    {
        Nimi = nimi;
        Hinded = hinded;
    }
}


