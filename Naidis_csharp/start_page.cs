using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    public class start_page
    {
        public static void Main(string[] args)
        {
            string text = "Tere tulemast c#-i mailmaa!";
            Console.WriteLine($"Oli loodud muutuja tekst,mis võrdub: {text}");
            Console.Write("mis on sinu nimi: ");
            string nimi = Console.ReadLine();
            Console.WriteLine("kui vana sa oled?: ");

            try
            {
                int vanus = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tere {nimi}, sa oled {vanus}, aastat vana");

                Console.Write("arv1: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("arv2: ");
                float b = float.Parse(Console.ReadLine());
                float vastus = Naidis_funktsioon.Summa(a, b);
                Console.WriteLine($"{a} + {b} = {vastus}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }



            Random rnd = new Random();
            int juhuslik_arv = rnd.Next(-5, 25);
            Console.WriteLine(Naidis_funktsioon.Kuu_nimetus(juhuslik_arv));
            juhuslik_arv = rnd.Next(-5, 25);
            text = Naidis_funktsioon.Kuu_nimetus(juhuslik_arv);
            Console.WriteLine(text);

            List<Isik> inimesed = new List<Isik>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sisesta nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                Isik uusIsik = new Isik();
                uusIsik.Nimi = nimi;
                uusIsik.Vanus = vanus;

                inimesed.Add(uusIsik);
            }

            Console.WriteLine("\nKõik inimesed tervitavad:\n");

            foreach (Isik isik in inimesed)
            {
                isik.Tervita();
            }


            Console.WriteLine("3. Osa. Kordused ja listid; missivid");
            Console.WriteLine("for: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Tere, {i}!");
            }

            Console.WriteLine("while: ");
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"Tere, {j + 1}");
                j++;
            }
            Console.WriteLine("Do: ");
            do
            {
                Console.WriteLine($"Tere, {11 - j}!");
                j--;
            } while (j != 0);

            int[] arvud = new int[5];


            for (int i = 1; i <= arvud.Length; i++)
            {

                Console.WriteLine($"sisesta {i}. arv: ");
                try
                {
                    arvud[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            Console.WriteLine("foreach abil: 0->4");
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"sisestatud arv: {arvud[i]}");
            }
            Console.WriteLine("foreach abil: 0<-4");
            for (int i = arvud.Length - 1; i > -1; i--)
            {
                Console.WriteLine($"sisestatud arv: {arvud[i]}");
            }
            // küsi mis pos muuda element ja mis väärtuseks, muuda element ja kuva masiiv
            */
            try
            {
                int[] arvud = new int[5];
                while (true)
                {
                    Console.WriteLine("1 - 3 Osa Funktsioonid");
                    Console.WriteLine("Vali mis osa sa tahad teha: \n1.osa\n2.osa\n3.osa");
                    int osavalik = int.Parse(Console.ReadLine());
                    int valik = int.Parse(Console.ReadLine());
                    switch (osavalik)
                    {
                        case 1:
                            Console.WriteLine("Vali 1.osa funktsioon: \n0. Välja\n1. MuudaElement\n2. Täida_massiiv\n3. foreach Funktisoon\n4. GenereeriRuudud\n5. Täida_Doublemassiiv\n");
                            switch (valik)
                            {
                                case 0:
                                    Console.Clear();
                                    break;
                                case 1:
                                    Naidis_funktsioon.MuudaElement(arvud);
                                    break;
                                case 2:
                                    Naidis_funktsioon.Täida_massiiv(arvud);
                                    break;
                                case 3:
                                    Naidis_funktsioon.foreachFunktisoon(arvud);
                                    break;
                                case 4:
                                    int[] masiiv1 = osa3.GenereeriRuudud(1, 10);
                                    Naidis_funktsioon.foreachFunktisoon(masiiv1);
                                    break;
                                case 5:
                                    double[] arvudMasiiv = Naidis_funktsioon.Täida_Doublemassiiv(new double[5]);
                                    var tulemus = osa3.arvuAnaluus(arvudMasiiv);
                                    Console.WriteLine($"summa: {tulemus.Item1}, keskmine: {tulemus.Item2}, Korrutis: {tulemus.Item3}");
                                    break;
                                default:
                                    Console.WriteLine("vali arv 1-5: ");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Vali 2.osa funktsioon: \n0. Välja\n1. Juku\n2. Pinginaabrid\n3. Pindala\n4. Soodus\n5. Temperatuur\n6. Pikkus\n7. Pood\n");
                            switch (valik)
                            {
                                case 0:
                                    Console.Clear();
                                    break;
                                case 1:
                                    osa2.Juku();
                                    break;
                                case 2:
                                    osa2.pinginabrid();
                                    break;
                                case 3:
                                    osa2.pindala();
                                    break;
                                case 4:
                                    osa2.soodus();
                                    break;
                                case 5:
                                    osa2.temp();
                                    break;
                                case 6:
                                    osa2.pikkus();
                                    break;
                                case 7:
                                    osa2.pood();
                                    break;
                                default:
                                    Console.WriteLine("vali arv 1-7: ");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Vali 3.osa funktsioon: \n0. Välja\n1. Osta elevandi\n2. Arvumäng\n3. Suurim neliarv\n4. Genereeri korrutustabel\n5. Arvud ruudud\n" +
                                "6. Positiivsed ja negatiivsed\n7. rohkem kui keskmine\n8. Suurim ja index\n9. inimese statistika\n10. Õpilastega mängimine\n11. Binaari osting\n12. Paari paaritud");
                            switch (valik)
                            {
                                case 0:
                                    Console.Clear();
                                    break;
                                case 1:
                                    osa3.ostsElevantAra();
                                    break;
                                case 2:
                                    osa3.arvumang();
                                    break;
                                case 3:
                                    osa3.SuurimNeliarv();
                                    break;
                                case 4:
                                    Console.WriteLine("Korrutustabel: ");
                                    osa3.GenereeriKorrutustabel(10, 10);
                                    break;
                                case 5:
                                    osa3.arvudRuudud();
                                    break;
                                case 6:
                                    osa3.Positiivsed_ja_negatiivsed();
                                    break;
                                case 7:
                                    osa3.rohkemkuiKeskmine();
                                    break;
                                case 8:
                                    osa3.suurimJaIndeks();
                                    break;
                                case 9:
                                    List<Inimene> Inimesed = new List<Inimene>();
                                    Inimene inimene1 = new Inimene("Vasya", 100);
                                    Inimesed.Add(inimene1);
                                    for (int i = 0; i < 5; i++)
                                    {
                                        Console.WriteLine($"Mis on {i + 1}. Nimi?:  ");
                                        string nimi = Console.ReadLine();
                                        Console.WriteLine($"Mis on {i + 1}. Inimese vanus?:  ");
                                        int vanus = int.Parse(Console.ReadLine());
                                        Inimene inimene = new Inimene(nimi, vanus);
                                        Inimesed.Add(inimene);

                                    }
                                    osa3.Statistika(Inimesed);
                                    var inimese = osa3.Statistika(Inimesed);
                                    Console.WriteLine($"vanuste arv: {inimese.Item1}");
                                    Console.WriteLine($"vanuste keskmine: {inimese.Item2}");
                                    Console.WriteLine($"vanim inimene: {inimese.Item3.Nimi}");
                                    Console.WriteLine($"noorim inimene: {inimese.Item4.Nimi}");
                                    break;
                                case 10
                                    string[] nimed = { "Anna", "Peeter", "Luara", "Markus", "Artur", "Sofia", "Rasmus", "Alina" };
                                    osa3.ÕpilastegaMängimine(nimed);
                                    break;
                                case 11
                                    osa3.binaariOsting();
                                    break;
                                case 12
                                    osa3.PaariPaaritud();
                                    break;
                                default:
                                    Console.WriteLine("vali arv 1-12: ");
                                    break;

                            }
                            break;
                        default:
                            Console.WriteLine("Teil on andud ainult 3 osad (võib sisestada ainult numbrid)")
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine()
            }
        }
    }
}
