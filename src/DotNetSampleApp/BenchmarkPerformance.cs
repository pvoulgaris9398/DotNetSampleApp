using BenchmarkDotNet.Attributes;

namespace DotNetSampleApp
{
    [Config(typeof(AntiVirusFriendlyConfig))]
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchmarkPerformance
    {
        [Params(100, 200)]
        public int N;

        private string _countries = "";
        private int _index;
        private int _numberOfCharactersToExtract;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _countries = "India, USA, UK, Australia, Netherlands, Belgium";
            _index = _countries.LastIndexOf(",", StringComparison.Ordinal);
            _numberOfCharactersToExtract = _countries.Length - _index;
        }

        [Benchmark]
        public void SubString()
        {
            for (int i = 0; i < N; i++)
            {
                var data = _countries.Substring(_index + 1, _numberOfCharactersToExtract - 1);
            }
        }

        [Benchmark(Baseline = true)]
        public void Span()
        {
            for (int i = 0; i < N; i++)
            {
                var data = _countries.AsSpan().Slice(_index + 1, _numberOfCharactersToExtract - 1);
            }
        }
    }
}
