namespace EnumeratorToIterator;

class Program
{
    static void Main(string[] args)
    {
        var oldData = new OldCollection();
        var adapter = new AdapterEnumeratorToIterator<string>(oldData);
        VypisIterator(adapter);

        Console.ReadKey();
    }

    private static void VypisIterator<T>(IIterator<T> data)
    {
        while (data.HasNext())
        {
            Console.WriteLine(data.Next());
        }
    }
}