using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.NoEmit;

namespace DotNetSampleApp
{
    /// <summary>
    /// https://stackoverflow.com/questions/73475521/benchmarkdotnet-inprocessemittoolchain-complete-sample
    /// </summary>
    public class AntiVirusFriendlyConfig : ManualConfig
    {
        public AntiVirusFriendlyConfig()
        {
            _ = AddJob(Job.MediumRun
                .WithToolchain(InProcessNoEmitToolchain.Instance));
        }
    }
}
