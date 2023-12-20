﻿using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Decompositors;
public class WiFiAdaperDecompositor : IWiFiBuilder
{
    private string? _version;
    private bool _builtInBluetooth;
    private string? _versionPCI;
    private float _powerConsumption;
    private WiFiAdapter _adapter;

    public WiFiAdaperDecompositor(WiFiAdapter adapter)
    {
        _adapter = adapter;
        _version = _adapter.Version;
        _builtInBluetooth = _adapter.BuiltInBluetoothModule;
        _versionPCI = _adapter.VersionPCI;
        _powerConsumption = _adapter.PowerConsumption;
    }

    public WiFiAdapter Build()
    {
        var wifiAdapter = new WiFiAdapter(
            version: _version,
            builtInBluetoothModule: _builtInBluetooth,
            versionPCI: _versionPCI,
            powerConsumption: _powerConsumption);
        ValidateComponents.IsWiFiAdapterValid(wifiAdapter);
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