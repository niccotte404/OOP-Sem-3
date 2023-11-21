namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface IMemoryComponent<TComponent>
    where TComponent : class
{
    public TComponent Build();
    public IMemoryComponent<TComponent> GetConnectionOption(string connectionOption);
    public IMemoryComponent<TComponent> GetMemoryAmount(int memoryAmount);
    public IMemoryComponent<TComponent> GetDatatransferSpeed(int datatransferSpeed);
    public IMemoryComponent<TComponent> GetPowerConsumprion(float powerConsumption);
}
