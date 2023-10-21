namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
public sealed class WiFiAdapter
{
    public WiFiAdapter(string? version, bool builtInBluetoothModule, string? versionPCI, float powerConsumption)
    {
        Version = version;
        BuiltInBluetoothModule = builtInBluetoothModule;
        VersionPCI = versionPCI;
        PowerConsumption = powerConsumption;
    }

    public string? Version { get; init; }
    public bool BuiltInBluetoothModule { get; init; }
    public string? VersionPCI { get; init; }
    public float PowerConsumption { get; init; }
}
