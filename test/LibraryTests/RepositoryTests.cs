using NUnit.Framework;

namespace Ucu.Poo.Repositories.Tests
{
  [TestFixture]
  public class RepositoryTests
  {
    private Repository<Car> repository;

    [SetUp]
    public void SetUp()
    {
        this.repository = new Repository<Car>();
    }

    [Test]
    public void FindCar_AccessedThroughRepositoryClass_ReturnsCar()
    {
      Car car = new Car("Sandero", "Renault", 2015);
      
      repository.Add(car);

      Car found = repository.Find(c => c.Model == "Sandero");

      Assert.That(found, Is.SameAs(car));
    }

    [Test]
    public void RemoveCar_ExistingItem_CarIsNoLongerFound()
    {
      Car car = new Car("Sandero", "Renault", 2015);
      repository.Add(car);
      repository.Remove(car);

      Car found = repository.Find(c => c.Model == "Sandero");

      Assert.That(found, Is.Null);
    }

    [Test]
    public void Find_EmptyRepository_ReturnsNull()
    {
      Car found = repository.Find(c => c.Model == "Saveiro");

      Assert.That(found, Is.Null);
      
    }

    [Test]
    public void Add_NullItem_ItemIsNotAdded()
    {

      repository.Add(null);

      Car found = repository.Find(c => c.Model == "Sandero");

      Assert.That(found, Is.Null);
      
    }

    [Test]
    public void Find_WithNoCoincidence_ReturnsNull()
    {
      Car car = new Car("Sandero", "Renault", 2015);
      repository.Add(car);

      Car found = repository.Find(c => c.Model == "Saveiro");

      Assert.That(found, Is.Null);
    }
    

    [Test]
    public void Find_RepositoryOfAnotherType_ReturnsItem()
    {
      Repository<Movie> moviesRepository = new Repository<Movie>();

      Movie movie = new Movie("Avengers Endgame", 2018);

      moviesRepository.Add(movie);

      Movie found = moviesRepository.Find(c => c.Year == 2018);

      Assert.That(found, Is.SameAs(movie));
    }



  }
}