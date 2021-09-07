using System;
using contracted.Models;
using contracted.Repositories;

namespace contracted.Services
{
  public class JobsService
  {
      private readonly JobsRepository _repo;

    public JobsService(JobsRepository repo)
    {
      _repo = repo;
    }

    internal Job Create(Job newJob)
    {
      return _repo.Create(newJob);
    }
    internal Job GetById(int id)
    {
      Job found = _repo.GetById(id);
      if( found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }
    internal void Delete(int id)
    {
      _repo.Delete(id);
      
    }
  }
}