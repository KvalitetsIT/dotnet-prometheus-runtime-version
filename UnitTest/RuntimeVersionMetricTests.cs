using KvalitetsIT.Prometheus.NetRuntime;

namespace UnitTests;

public class Tests
{
    [Test]
    public void TestGaugeValueAndLabels()
    {
        var gauge = RuntimeVersionMetric.AddRuntimeVersionMetric();
        Assert.That(gauge, Is.Not.Null);
        Assert.That(gauge.Value, Is.EqualTo(1.0));
        Assert.That(gauge.Name, Is.EqualTo("dotnet_runtime_version"));
        Assert.That(gauge.Help, Is.EqualTo("The version of the .NET runtime that the application is running on."));
        Assert.That(gauge.ToString(), Is.EqualTo("dotnet_runtime_version{(4) version, major, minor, build}"));
    }
}