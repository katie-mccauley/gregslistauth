using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using gregslistauth.Models;

namespace gregslistauth.Repositories
{
  public class CarsRepository
  {

    private readonly IDbConnection _db;
    public CarsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal List<Car> GetAll()
    {
      string sql = "SELECT * FROM cars;";
      return _db.Query<Car>(sql).ToList();
    }

    internal Car GetById(int id)
    {
      string sql = "SELECT * FROM cars WHERE id = @id";
      Car car = _db.QueryFirstOrDefault<Car>(sql, new { id });
      return car;
    }

    internal Car CreateCar(Car newCar)
    {
      string sql = @"
      INSERT INTO cars
      (name, description, year)
      VALUES
      (@Name, @Description, @Year);
      SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newCar);
      newCar.Id = id;
      return newCar;
    }

    internal void Delete(int id)
    {
      string sql = @"
      DELETE FROM cars WHERE id = @id LIMIT 1;";
      _db.Execute(sql, new { id });
    }

    internal void EditCar(Car original)
    {
      string sql = @"
      UPDATE cars 
      SET 
        name = @Name, 
        description= @Description, 
        year = @Year
      WHERE id = @Id;
      ";
      _db.Execute(sql, original);
    }
  }

}