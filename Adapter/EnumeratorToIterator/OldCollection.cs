namespace EnumeratorToIterator
{
    public class OldCollection : IEnumerator<string>
    {
        private string[] pole = {"alfa", "beta", "gama"};
        private int current = -1;

        public bool HasMoreElements()
        {
            return current < (pole.Length - 1);
        }

        public string NextElement()
        {
            current++;
            return pole[current];
        }
    }
}