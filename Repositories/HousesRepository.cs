using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using gregslistauth.Models;

namespace gregslistauth.Repositories
{
  public class HousesRepository
  {
    private readonly IDbConnection _db;

    public HousesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<House> GetAll()
    {
      string sql = "SELECT * FROM houses;";
      return _db.Query<House>(sql).ToList();
    }
  }
}