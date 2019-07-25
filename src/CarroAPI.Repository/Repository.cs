using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using Microsoft.Extensions.Logging;
using CarroAPI.Repository;
using CarroAPI.Domain;

namespace CarroAPI.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : CarroAPI.Domain.IEntity
    {
        private readonly ILogger<Repository<T>> _logger;

        public Repository(ILogger<Repository<T>> logger)
        {
            _logger = logger;
        }

        public void Add(T obj)
        {
            throw new NotImplementedException();
        }

        public Carro FindByKey(Guid key)
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query(string query)
        {
            SqlConnection conn = null;
            try
            {
                conn = CarroAPI.Repository.Utilities.ConnectionFactory.GetConnection();

                var result = conn.Query<T>(query);

                return result.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
            finally
            {
                if ((conn != null) && (conn.State != ConnectionState.Closed))
                {
                    conn.Close();
                }
            }
        }
    }
}