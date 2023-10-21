using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders;
public class WiFiAdaperBuilder : IWiFiBuilder
{
    private WiFiAdapter _wifiAdapter;
    private string? _version;
    private bool _builtInBluetooth;
    private string? _versionPCI;
    private float _powerConsumption;

    public WiFiAdaperBuilder()
    {
        _wifiAdapter = new WiFiAdapter(
            version: _version,
            builtInBluetoothModule: _builtInBluetooth,
            versionPCI: _versionPCI,
            powerConsumption: _powerConsumption);
    }

    public WiFiAdapter Build()
    {
        WiFiAdapter wifiAdapter = _wifiAdapter;
        return wifiAdapter;
    }

    public IWiFiBuilder GetWifiBluetoothModule(bool builtInBluetoothModule)
    {
        _builtInBluetooth = builtInBluetoothModule;
        return this;
    }

    public IWiFiBuilder GetWifiPowerConsumption(float powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public IWiFiBuilder GetWifiVersion(string version)
    {
        _version = version;
        return this;
    }

    public IWiFiBuilder GetWifiVersionPCI(string versionPCI)
    {
        _versionPCI = versionPCI;
        return this;
    }
}
