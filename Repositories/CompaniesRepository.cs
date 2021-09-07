using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using contracted.Models;
using Dapper;

namespace contracted.Repositories
{
  public class CompaniesRepository
  {
      private readonly IDbConnection _db;

    public CompaniesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Company> GetAll()
    {
      string sql = "SELECT * FROM companies;";
      return _db.Query<Company>(sql).ToList();
    }

    internal Company Create(Company newCompany)
    {
      string sql = @"
      INSERT INTO companies
      (name)
      VALUES
      (@Name);
      SELECT LAST_INSERT_ID();";
      newCompany.Id = _db.ExecuteScalar<int>(sql, newCompany);
      return newCompany;
    }
  }
}