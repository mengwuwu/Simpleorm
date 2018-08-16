/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM.Sql
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/15 13:57:06
* 更新时间 : 2018/8/15 13:57:06
*************************************************************************************************
 * 该代码为自动生成代码，请勿编写任何有意义的信息
 * Copyright @ hongyichao 2017. All reghts reserved
*************************************************************************************************/
using Framework.ORM.javaSqlLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM.Sql
{
    class SqliteDbConnection : IDbConnection
    {
        private SQLiteOpenHelper sQLiteOpenHelper;
        Object IDbConnection.GetDbConnection()
        {
            return GetDbConnection();
        }
        public SQLiteOpenHelper GetDbConnection()
        {
            var item = DBInitial.DBNameModel;
            if (item == null) throw new ArgumentException("执行的数据库不能为空");
            sQLiteOpenHelper = new SQLiteOpenHelper(item.Name, item.Path, item.Version);
            return sQLiteOpenHelper;
        }
        public void Dispose()
        {
            sQLiteOpenHelper.Dispose();
        }

        public void Execute(string sql)
        {
            sQLiteOpenHelper.ExecuteSQL(sql);
        }

        public IEnumerable<T> ExecuteQuery<T>(string sql)
        {
            return sQLiteOpenHelper.ExecuteQuery<T>(sql);
        }
    }
}
