using BenchmarkDotNet.Running;

namespace Vykon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<Md5VsSha256>();
            var summary2 = BenchmarkRunner.Run<DictSum>();
        }
    }
}