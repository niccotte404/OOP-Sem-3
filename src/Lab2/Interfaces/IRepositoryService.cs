﻿using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface IRepositoryService<TComponent>
    where TComponent : class
{
    public void Add(ICollection<TComponent> components, TComponent component);
    public bool IsExists(ICollection<TComponent> components, TComponent component);
    public void Remove(ICollection<TComponent> components, TComponent component);
    public void Update(ICollection<TComponent> components, TComponent oldComponent, TComponent newComponent);
}