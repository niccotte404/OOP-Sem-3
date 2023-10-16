using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface IRepositoryService<TComponent>
    where TComponent : class
{
    public void Add(TComponent component);
    public bool IsExists(TComponent component);
    public void Remove(TComponent component);
    public void Update(TComponent oldComponent, TComponent newComponent);
    public IReadOnlyCollection<TComponent> SelectComponent(TComponent componentHelper);
}
