/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/15 14:14:34
* 更新时间 : 2018/8/15 14:14:34
*************************************************************************************************
 * 该代码为自动生成代码，请勿编写任何有意义的信息
 * Copyright @ hongyichao 2017. All reghts reserved
*************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM
{
    public abstract class DBHelperBase
    {
        public abstract IDbConnection GetDbConnection();
        public virtual void Excute(String sql)
        {
            IDbConnection dbConnect = GetDbConnection();
            dbConnect.Execute(sql);
            dbConnect.Dispose();
        }
        public virtual IEnumerable<T> ExecuteQuery<T>(String sql)
        {
            IEnumerable<T> item;
            IDbConnection dbConnect = GetDbConnection();
            item = dbConnect.ExecuteQuery<T>(sql);
            dbConnect.Dispose();
            return item;
        }
    }
}
