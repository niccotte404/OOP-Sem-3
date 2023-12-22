using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface IWiFiBuilder
{
    public WiFiAdapter Build();
    public IWiFiBuilder GetWifiVersion(string version);
    public IWiFiBuilder GetWifiBluetoothModule(bool builtInBluetoothModule);
    public IWiFiBuilder GetWifiVersionPCI(string versionPCI);
    public IWiFiBuilder GetWifiPowerConsumption(float powerConsumption);
}
