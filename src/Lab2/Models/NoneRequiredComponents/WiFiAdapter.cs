namespace Itmo.ObjectOrientedProgramming.Lab2.Models.NoneRequiredComponents;
public sealed class WiFiAdapter
{
    public WiFiAdapter(string version, bool builtInBluetoothModule, string versionPCI, float powerConsumprion)
    {
        Version = version;
        BuiltInBluetoothModule = builtInBluetoothModule;
        VersionPCI = versionPCI;
        PowerConsumption = powerConsumprion;
    }

    public string Version { get; init; }
    public bool BuiltInBluetoothModule { get; init; }
    public string VersionPCI { get; init; }
    public float PowerConsumption { get; init; }
}
