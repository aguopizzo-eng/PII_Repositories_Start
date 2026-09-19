//------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Ucu.Poo.Repositories
{
  public class Repository<T>
  {
    private List<T> lst = new List<T>();

    public void Add(T item)
        {
            if (item != null)
            {
                this.lst.Add(item);
            }
        }

    public void Remove(T item)
        {
            this.lst.Remove(item);
        }

    public T Find(Predicate<T> criteria)
        {
            foreach (T item in this.lst)
            {
                if (criteria(item))
                {
                    return item;
                }
            }

            return default(T);
        }
  }
}