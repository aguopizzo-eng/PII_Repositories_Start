//------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------
using System;

namespace Ucu.Poo.Repositories
{
  public interface Repository<T>
  {
    void Add(T obj);
    void Remove(T obj);
    T Find(Predicate<T> criteria);

  }
}