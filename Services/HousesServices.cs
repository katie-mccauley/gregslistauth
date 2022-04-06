using System;
using System.Collections.Generic;
using gregslistauth.Models;
using gregslistauth.Repositories;

namespace gregslistauth.Services
{
  public class HousesService
  {
    private readonly HousesRepository _repo;

    public HousesService(HousesRepository repo)
    {
      _repo = repo;
    }

    internal List<House> GetAll()
    {
      List<House> houses = _repo.GetAll();
      return houses;
    }
  }
}