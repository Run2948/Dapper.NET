using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.Repository;
using System.Data.SqlClient;
using DapperExtensions;


namespace Quick.Repository.Base
{
    public class SqlRepository<T> : IRepository<T> where T : class
    {
        public virtual List<T> GetList()
        {
            using (var conn = ConnectionFactory.CreateSqlConnection())
            {
                return conn.GetList<T>().ToList();
            }

        }

        public virtual T Get(object id)
        {
            using (var conn = ConnectionFactory.CreateSqlConnection())
            {
                return conn.Get<T>(id);
            }
        }

        public virtual bool Update(T t)
        {
            using (var conn = ConnectionFactory.CreateSqlConnection())
            {
                return conn.Update(t);
            }
        }

        public virtual T Insert(T apply)
        {
            using (var conn = ConnectionFactory.CreateSqlConnection())
            {
                conn.Insert(apply);
                return apply;
            }
        }

        public virtual bool Delete(T t)
        {
            using (var conn = ConnectionFactory.CreateSqlConnection())
            {
                return conn.Delete(t);
            }
        }

    }
}
