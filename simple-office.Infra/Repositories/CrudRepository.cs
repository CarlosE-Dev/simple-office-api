using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using simple_office.Core.Dapper;
using simple_office.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_office.Infra.Repositories
{
    public class CrudRepository<T> : IDisposable, ICrudRepository<T> where T : class
    {
        protected readonly ISqlQueryHelper<T> _sqlQueryHelper;
        private readonly string _connectionString;

        public CrudRepository(ISqlQueryHelper<T> sqlQueryHelper, IConfiguration configuration)
        {
            _sqlQueryHelper = sqlQueryHelper;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async void Create(T obj)
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            try
            {
                await connection.ExecuteAsync(_sqlQueryHelper.Insert(), obj);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            try
            {
                return await connection.QueryAsync<T>(_sqlQueryHelper.SelectAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public async Task<T> GetById(int id)
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            try
            {
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add(_sqlQueryHelper.KeyField, id);
                var result = await connection.QueryAsync<T>(_sqlQueryHelper.SelectById(), dynamicParameters);
                return result.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public async void Delete(T obj)
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            try
            {
                await connection.QueryAsync<T>(_sqlQueryHelper.Delete(), obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public async void Update(T obj)
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            try
            {
                await connection.QueryAsync<T>(_sqlQueryHelper.Update(), obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
