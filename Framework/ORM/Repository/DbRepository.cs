/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM.Repository
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/16 16:04:26
* 更新时间 : 2018/8/16 16:04:26
*************************************************************************************************
 * 该代码为自动生成代码，请勿编写任何有意义的信息
 * Copyright @ hongyichao 2017. All reghts reserved
*************************************************************************************************/
using Framework.ORM.Batch;
using Framework.ORM.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM.Repository
{
    public abstract class DbRepository
    {
        private DBHelperBase DBHelper;
        public DbRepository()
        {
            DBHelper = CreateDbService();
        }
        private DBHelperBase CreateDbService()
        {
            return new SqliteDBHelper();
        }
        public IEnumerable<T> All<T>()
        {
            String query = CreateQuery().All();
            return DBHelper.ExecuteQuery<T>(query);
        }
        public abstract Query CreateQuery();
    }
}
