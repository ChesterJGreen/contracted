using System;
using System.Collections.Generic;
using contracted.Models;
using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ContractorsController : ControllerBase
    {
        private readonly ContractorsService _contS;

    public ContractorsController(ContractorsService contS)
    {
      _contS = contS;
    }

    [HttpGet]
    public ActionResult<List<Contractor>> Get()
    {
        try
        {
             List<Contractor> contractors = _contS.Get();
             return Ok(contractors);
        }
        catch (Exception err)
        {
            
            return BadRequest(err.Message);
        }
    }
    [HttpPost]
    public ActionResult<Contractor> Create([FromBody] Contractor newContractor)
    {
        try
        {
             Contractor created = _contS.Create(newContractor);
             return Ok(created);
        }
        catch (Exception err)
        {
            
            return BadRequest(err.Message);
        }
    }
  }
}