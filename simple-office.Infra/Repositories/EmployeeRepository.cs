using Microsoft.Extensions.Configuration;
using simple_office.Domain.Interfaces.Dapper;
using simple_office.Domain.Interfaces.Repositories;
using simple_office.Domain.Models;
using System.Data;

namespace simple_office.Infra.Repositories
{
    public sealed class EmployeeRepository : CrudRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ISqlQueryHelper<Employee> sqlQueryHelper, IConfiguration configuration) : base(sqlQueryHelper, configuration)
        {
        }
    }
}
