using System;
using System.Data;
using contracted.Models;
using contracted.Services;
using Dapper;

namespace contracted.Repositories
{
  public class JobsRepository
  {
      private readonly IDbConnection _db;

    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal Job Create(Job newJob)
    {
      string sql = @"
      INSERT INTO jobs
      (companyId, contractorId)
      VALUE
      (@CompanyId, @ContractorId);
      SELECT LAST_INSERT_ID();";
      newJob.Id = _db.ExecuteScalar<int>(sql, newJob);
      return newJob;

    }
  }
}