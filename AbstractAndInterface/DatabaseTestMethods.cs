using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    public abstract class BaseDb
    {
        public BaseDb()
        {
            
        }

        public abstract string GetDbVersion();
        public DataTable ExecuteSql(string sql)
        {
            return new DataTable();
        }
    }

    public class MySqlDb : BaseDb
    {
        public override string GetDbVersion() => "MySql Database";

        public string GenerateSql(int id)
        {
            return $"SLECET * FROM USERS WHERE ID = {id}";
        }
    }

    public class SqlServerDb: BaseDb
    {
        public override string GetDbVersion() => "SqlServer 2019";

        public string GenerateSql(int id)
        {
            return $"SLECET * FROM USERS WHERE ID = {id}";
        }
    }

    public class OracleDb: BaseDb
    {
        public override string GetDbVersion() => "Oracle 18c";

        public string GenerateSql(int id)
        {
            return $"SLECET * FROM USERS WHERE USER_ID = {id}";
        }
    }
}
