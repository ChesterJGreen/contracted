using System;
using System.Collections.Generic;
using contracted.Models;
using contracted.Repositories;

namespace contracted.Services
{
  public class ContractorsService
  {

private readonly ContractorsRepository _repo;

    public ContractorsService(ContractorsRepository repo)
    {
      _repo = repo;
    }

    internal List<Contractor> Get()
    {
      return _repo.GetAll();
    }

    internal Contractor Create(Contractor newContractor)
    {
        return _repo.Create(newContractor);
    }
  }
}