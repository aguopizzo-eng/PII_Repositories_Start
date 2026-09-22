//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Ucu.Poo.Repositories;

namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Repository<Car> repository = new Repository<Car>();
            
            Car car = new Car("Sandero", "Renault", 2015);
            Car car2 = new Car("Uno", "Fiat", 2000);

            repository.Add(car);
            repository.Add(car2);

            Car found1 = repository.Find(c => c.Model == "Sandero");
            Car found2 = repository.Find(c => c.Model == "Uno");

            Console.WriteLine($"{found1.Maker}");
            Console.WriteLine($"{found2.Maker}");
            

            Repository<Movie> catalog = new Repository<Movie>();

            Movie movie = new Movie("Avengers Endgame", 2018);
            Movie movie2 = new Movie("The Avengers", 2014);

            catalog.Add(movie);
            catalog.Add(movie2);

            Movie found3 = catalog.Find(c => c.Year == 2018);
            Movie found4 = catalog.Find(c => c.Year == 2014);

            Console.WriteLine($"{found3.Name}");
            Console.WriteLine($"{found4.Name}");

        }
    }
}