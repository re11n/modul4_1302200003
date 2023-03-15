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

