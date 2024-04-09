using Prometheus;

namespace KvalitetsIT.Prometheus.NetRuntime;

public static class RuntimeVersionMetric
{
    public static Gauge AddRuntimeVersionMetric()
    {
        var version = Environment.Version;
        var gauge = Metrics
            .WithLabels(new Dictionary<string, string>
                {
                    { "version", version.ToString() }, 
                    { "major", version.Major.ToString() }, 
                    { "minor", version.Minor.ToString() }, 
                    { "build", version.Build.ToString() }, 
                }
            )
            .CreateGauge("dotnet_runtime_version", "The version of the .NET runtime that the application is running on.");
        
        gauge.Set(1.0);
            
        return gauge;
    }
}