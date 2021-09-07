using System;
using System.Collections.Generic;
using contracted.Models;
using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CompaniesController :ControllerBase
    {
       private readonly CompaniesService _compS;

    public CompaniesController(CompaniesService compS)
    {
      _compS = compS;
    }
    [HttpGet]
    public ActionResult<List<Company>> Get()
    {
        try
        {
             List<Company> companies = _compS.Get();
             return Ok(companies);
        }
        catch (Exception err)
        {
            
            return BadRequest(err.Message);
        }
    }
    [HttpPost]
    public ActionResult<Company> Create([FromBody] Company newCompany)
    {
        try
        {
             Company company = _compS.Create(newCompany);
             return Ok(company);
        }
        catch (Exception err)
        {
            
            return BadRequest(err.Message);
        }
    }
  }
}