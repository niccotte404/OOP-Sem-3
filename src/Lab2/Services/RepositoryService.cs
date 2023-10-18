using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;
public abstract class RepositoryService<TComponent> : IRepositoryService<TComponent>
    where TComponent : class
{
    public void Add(ICollection<TComponent> components, TComponent component)
    {
        if (components is null) return;
        components.Add(component);
    }

    public bool IsExists(ICollection<TComponent> components, TComponent component)
    {
        if (components is null) return false;
        return components.Contains(component);
    }

    public void Remove(ICollection<TComponent> components, TComponent component)
    {
        if (components is null) return;
        components.Remove(component);
    }

    public void Update(ICollection<TComponent> components, TComponent oldComponent, TComponent newComponent)
    {
        if (components is null) return;
        if (IsExists(components, oldComponent) == false) return;
        components.Remove(oldComponent);
        components.Add(newComponent);
    }

    public abstract IReadOnlyCollection<TComponent> SelectComponent(TComponent componentHelper);
}
