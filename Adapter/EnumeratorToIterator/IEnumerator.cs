namespace EnumeratorToIterator;

public interface IEnumerator<out T>
{
    bool HasMoreElements();
    T NextElement();
}