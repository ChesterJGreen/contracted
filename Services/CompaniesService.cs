using System;
using System.Collections.Generic;
using contracted.Models;
using contracted.Repositories;

namespace contracted.Services
{
  public class CompaniesService
  {
      private readonly CompaniesRepository _repo;

    public CompaniesService(CompaniesRepository repo)
    {
      _repo = repo;
    }

    internal List<Company> Get()
    {
      return  _repo.GetAll();
      
    }

    internal Company Create(Company newCompany)
    {
      Company company = _repo.Create(newCompany);
      if (company == null)
      {
          throw new Exception("Invalid Id");
      }
      return company;
    }

  }
}