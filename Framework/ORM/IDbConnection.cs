using Framework.ORM.javaSqlLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM
{
    public interface IDbConnection
    {
        Object GetDbConnection();
        void Execute(String sql);
        IEnumerable<T> ExecuteQuery<T>(String sql);
        void Dispose();
    }
}
