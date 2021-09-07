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

    internal void Delete(int id)
    {
      _repo.Delete(id);
      
    }
  }
}