namespace PripravaNapoje;

class Program
{
    static void Main(string[] args)
    {
        PripravNapoj(new Caj());
        Console.WriteLine("----------------");

        PripravNapoj(new Kava());

        Console.WriteLine("Hotovo");
        Console.ReadKey();

    }

    static void PripravNapoj(Napoj napoj)
    {
        napoj.Priprava();
    }
}