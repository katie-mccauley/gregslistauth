using Microsoft.AspNetCore.Mvc;
using gregslistauth.Models;
using gregslistauth.Services;
using System.Collections.Generic;
using System;

namespace gregslistauth.Controllers;
[ApiController]
[Route("/api/[controller]")]
public class HousesController : ControllerBase
{

  private readonly HousesService _cs;
  public HousesController(HousesService cs)
  {
    _cs = cs;
  }

  [HttpGet]
  public ActionResult<List<House>> GetAll()
  {
    try
    {
      List<House> houses = _cs.GetAll();
      return Ok(houses);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  // [HttpGet("{id}")]
  // public ActionResult<House> GetById(string id)
  // {
  //   try
  //   {
  //     House house = _cs.GetById(id);
  //     return Ok(house);
  //   }
  //   catch (Exception e)
  //   {
  //     return BadRequest(e.Message);
  //   }
  // }
  // [HttpDelete("{id}")]
  // public ActionResult<String> Delete(string id)
  // {
  //   try
  //   {
  //     _cs.Delete(id);
  //     return Ok("Delorted");
  //   }
  //   catch (Exception e)
  //   {
  //     return BadRequest(e.Message);
  //   }
  // }

  // [HttpPost]
  // public ActionResult<House> Create([FromBody] House newHouse)
  // {
  //   try
  //   {
  //     House house = _cs.CreateHouse(newHouse);
  //     return Ok(house);
  //   }
  //   catch (Exception e)
  //   {

  //     return BadRequest(e.Message);

  //   }
  // }
  // [HttpPut("{id}")]
  // public ActionResult<House> EditHouse(string id, [FromBody] House editHouse)
  // {
  //   try
  //   {
  //     editHouse.Id = id;
  //     House updated = _cs.EditHouse(editHouse);
  //     return Ok(updated);
  //   }
  //   catch (Exception e)
  //   {
  //     return BadRequest(e.Message);
  //   }
  // }
}