using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Jobs;

namespace Vykon
{
    [SimpleJob(RuntimeMoniker.Net48, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]

    public class DictSum
    {
        private Dictionary<int, int> _dictionary = Enumerable.Range(0, 10_000).ToDictionary(i => i);

        private List<int> _list = new List<int>(100_000);

        [GlobalSetup]
        public void GlobalSetup()
        {
            Random random = new Random();
            
            for (int i = 0; i < 100_000; i++)
            {
                _list.Add(random.Next(1,10));
            }
        }

        [Benchmark]
        public int SumA()
        {
            Dictionary<int, int> dictionary = _dictionary;
            int sum = 0;

            for (int i = 0; i < 10_000; i++)
            {
                if (dictionary.TryGetValue(i, out int value))
                {
                    sum += value;
                }
            }

            return sum;
        }

        [Benchmark]
        public int SumB()
        {
            int sum = 0;

            for (int i = 0; i < 100_000; i++)
            {
                sum += _list[i];
            }

            return sum;
        }
    }
}
