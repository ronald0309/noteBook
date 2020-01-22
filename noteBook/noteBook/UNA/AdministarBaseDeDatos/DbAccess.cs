using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace noteBook
{
    public abstract class DbAccess
    {
        public String ConnectionString
        {
            get;
            set;
        }
        public MySqlTransaction DbTransaction
        {
            get;
            set;
        }
        public MySqlConnection DbConnection
        {
            get;
            set;
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract DataTable QuerySQL(String query);
        public abstract long EjectSQL(String query);
        public abstract Boolean IsTransaction();
        public abstract void CommitTransaction();
        public abstract void RollbackTransaction();
        public abstract void BeginTransaction();
    }
}