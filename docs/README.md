# KvalitetsIT.Prometheus.NetRuntime

Small library that can be used to expose the .NET runtime metrics to Prometheus.

A new metric called `dotnet_runtime_version` will be exposed with the runtime version as a label.

## Usage

To expose the .NET runtime version to Prometheus just call below static method in your application. A good place
could be just before `app.UseHttpMetrics()` in your `Program.cs` file.

```csharp
KvalitetsIT.Promtheus.NetRuntime.RuntimeVersionMetrics.AddRuntimeVersionMetric();
```