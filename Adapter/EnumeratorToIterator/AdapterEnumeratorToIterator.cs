namespace EnumeratorToIterator;

public class AdapterEnumeratorToIterator<T> : IIterator<T>
{
    public AdapterEnumeratorToIterator(IEnumerator<T> enumerator)
    {
        Enumerator = enumerator;
    }

    public IEnumerator<T> Enumerator { get; set; }

    public bool HasNext()
    {
        return Enumerator.HasMoreElements();
    }

    public T Next()
    {
        return Enumerator.NextElement();
    }

    public void Remove(T item)
    {
        throw new NotSupportedException("Metoda Remove neni podporovana vlozenym objektem");
    }
}