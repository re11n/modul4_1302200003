// See https://aka.ms/new-console-template for more information

public class Program
{

    public static void Main()
    {
        KodeBuah table_Kodepos = new KodeBuah();
        Console.WriteLine("Ketik Nama Buah");
        Console.Write("Buah :");
        string command = Console.ReadLine();
        table_Kodepos.getKodeBuah(command);

        Console.WriteLine("================== POSISI KARAKTER ================");
        PosisiKarakterGame posisi = new PosisiKarakterGame();
        posisi.kunci();
    }


}

public class KodeBuah
{
    Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"Apel", "A00"},
            {"Aprikot","B00" },
            {"Alpukat"  ,"C00" },
            {"Pisang"    ,"D00" },
            {"Paprika"  ,"E00"},
            {"Blackberry" ,"F00" },
            {"Ceri","H00"},
            {"Kelapa" ,"I00" },
            {"Jagung","J00"},
            {"Kurma"   ,"K00"},
            {"Durian"   ,"L00"},
            {"Anggur"   ,"M00"},
            {"Melon"   ,"N00"},
            {"Semangka"   ,"O00"}
    };
    public void getKodeBuah(string buah)
    {
        if (dic.ContainsKey(buah))
        {
            Console.WriteLine(buah + " : " + dic[buah]);
        }
        else
        {
            Console.WriteLine(buah + " tidak ditemukan");
        }
    }
}

public class PosisiKarakterGame
{
    enum State { Jongkok, Berdiri, Tengkurap, Terbang, Stop };
    public void kunci()
    {
        State state = State.Berdiri;

        String[] screenName = { "Jongkok", "Berdiri", "Tengkurap", "Terbang", "Stop" };
        do
        {
            Console.WriteLine("Posisi " + screenName[(int)state]);
            Console.Write("Enter Command : ");
            String command = Console.ReadLine();
            switch (state)
            {
                case State.Berdiri:
                    if (command == "TombolW")
                    {
                        state = State.Terbang;
                        Console.Write("Posisi take off\n");
                    }
                    break;
                case State.Terbang:
                    if (command == "TombolS")
                    {
                        state = State.Berdiri;
                    }
                    else if (command == "TombolX")
                    {
                        state = State.Jongkok;
                        Console.Write("Posisi landing\n");
                    }
                    break;
                case State.Jongkok:
                    if (command == "TombolS")
                    {
                        state = State.Tengkurap;
                    }
                    else if (command == "TombolW")
                    {
                        state = State.Berdiri;
                    }
                    break;
                case State.Tengkurap:
                    if (command == "TombolW")
                    {
                        state = State.Jongkok;
                    }
                    break;
            }
        } while (state == State.Stop);
    }
}