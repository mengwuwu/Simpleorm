/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM.testClass
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/15 10:08:08
* 更新时间 : 2018/8/15 10:08:08
*************************************************************************************************
 * 该代码为自动生成代码，请勿编写任何有意义的信息
 * Copyright @ hongyichao 2017. All reghts reserved
*************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM.javaSqlLite
{
    public class SQLiteOpenHelper:IDisposable
    {
        private string name;
        private string path;
        private string version;

        public SQLiteOpenHelper(string name, string path, string version)
        {
            this.name = name;
            this.path = path;
            this.version = version;
        }
        public void Dispose()
        {
            
        }

        internal void ExecuteSQL(string sql)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<T> ExecuteQuery<T>(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
