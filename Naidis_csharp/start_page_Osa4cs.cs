namespace Naidis_csharp
{
    internal class start_page_Osa4cs

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("4. Osa Funktsioonid\n========================");
            Console.WriteLine("1. Faili kirjutamine\n2. Faili lugemine\n3. Ridade lugemine\n4. Ridade lugemine listiks\n5. Listi muutmine\n6. Otsing nimekirjas\n7. Listi salvestamine\n0. Välja");
            int valik = int.Parse(Console.ReadLine());
            string fail = "";
            List<string> list = new List<string>();
            switch (valik)
            {
                case 0:
                    Console.Clear();
                    break;
                case 1:
                    Osa4_funktsioonid.Faili_kirjutamine();
                    break;
                case 2:
                    Osa4_funktsioonid.Faili_lugemine();
                    break;

                case 3:
                    Console.Write("Sisesta failinimi: ");
                    fail = Console.ReadLine();
                    Osa4_funktsioonid.Ridade_lugemine(fail);
                    break;
                case 4:
                    Console.Write("Sisesta failinimi: ");
                    fail = Console.ReadLine();
                    Osa4_funktsioonid.Ridade_lugemine_listiks(fail);
                    break;

                case 5:
                    Osa4_funktsioonid.Listi_muutmine_kuvamine();
                    break;
                case 6:
                    Osa4_funktsioonid.Otsing_nimekirjast();
                    break;
                case 7:
                    Osa4_funktsioonid.Listi_salvestamine();
                    break;
                default:
                    Console.Write("sisesta kehtiv number (1-7): ");
                    break;
            }
        }
    }
}
