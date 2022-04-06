using System;
using System.Collections.Generic;
using gregslistauth.Models;
using gregslistauth.Repositories;

namespace gregslistauth.Services
{
  public class CarsService
  {
    private readonly CarsRepository _repo;

    public CarsService(CarsRepository repo)
    {
      _repo = repo;
    }

    internal Car GetById(int id)
    {
      Car car = _repo.GetById(id);
      if (car == null)
      {
        throw new Exception("Invalid Id");
      }

      return car;
    }

    internal List<Car> GetAll()
    {
      List<Car> cars = _repo.GetAll();
      return cars;
    }

    internal Car CreateCar(Car newCar)
    {
      return _repo.CreateCar(newCar);
    }

    internal void Delete(int id)
    {
      GetById(id);
      _repo.Delete(id);
    }

    internal Car EditCar(Car editcar)
    {
      Car original = GetById(editcar.Id);
      original.Name = editcar.Name;
      original.Description = editcar.Description;
      original.Year = editcar.Year;
      _repo.EditCar(original);
      return original;
    }
  }

}