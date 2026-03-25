namespace Naidis_csharp
{
    internal class start_page_osa5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vali mida sa tahad teha:\n1 - Array näide,\n2 - Tuple,\n3 - List Klassiga,\n4 - Linked list," +
            "\n5 - Sonatlik,\n6 - Toidu salvestamine,\n7 - Kaal kalkulaator,\n8 - Maakonnad ja pealinnad,\n");
            int valik = int.Parse(Console.ReadLine());
            switch (valik)
            {

                case 1:
                    osa5_funktsioonid.array_naide();
                    break;
                case 2:
                    osa5_funktsioonid.Tuple();
                    break;
                case 3:
                    Person.List_klassiga();
                    break;
                case 4:
                    osa5_funktsioonid.LinkedList();
                    break;
                case 5:
                    osa5_funktsioonid.sonatlik();
                    break;
                case 6:
                    ulesanded.Toidu_salvestamine_faili();
                    break;
                case 7:
                    ulesanded.KaalKalkulaator(Inimene_osa5.GetInimene());
                    break;
                case 8:
                    ulesanded.Maakonnad_pealinnad();
                    break;
                case 9:
                    ulesanded.opilased();
                    break;
                default:
                    Console.WriteLine("Vali ainult täis numbrid ja mitte sõnad!");
                    break;
            }
        }
    }
}

