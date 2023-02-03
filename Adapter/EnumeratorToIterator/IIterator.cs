namespace EnumeratorToIterator;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
    void Remove(T item);
}