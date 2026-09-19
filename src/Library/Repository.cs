//------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Ucu.Poo.Repositories
{
  /// <summary>
  /// Esta clase representa un repositorio genérico de elementos.
  /// </summary>
  /// <typeparam name="T">El tipo de los elementos almacenados.</typeparam>
  public class Repository<T>
  {
    private List<T> lst = new List<T>();

    /// <summary>
    /// Agrega un elemento al repositorio.
    /// </summary>
    /// <param name="item">El elemento a agregar.</param>
    public void Add(T item)
        {
            if (item != null)
            {
                this.lst.Add(item);
            }
        }

    /// <summary>
    /// Elimina un elemento del repositorio.
    /// </summary>
    /// <param name="item">El elemento a remover.</param>
    public void Remove(T item)
        {
            this.lst.Remove(item);
        }

    /// <summary>
    /// Busca un elemento en el repositorio que cumpla con un criterio
    /// específico.
    /// </summary>
    /// <param name="criteria">El criterio por el cual buscar.</param>
    /// <returns>El elemento encontrado que cumple el criterio especificado o
    /// null si no se encuentra ninguno.</returns>
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