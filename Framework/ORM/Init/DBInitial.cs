/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/15 10:24:37
* 更新时间 : 2018/8/15 10:24:37
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
    /// <summary>
    /// DB初始化引擎
    /// 在页面配置页面添加当前使用的数据库名及表名,可以使用异步进行
    /// </summary>
    public class DBInitial
    {
        private static DBTableName dbTbaleName;
        public static DBTableName DBTableName {
            get {
                if (DBNameModel.IsValid())
                { throw new ArgumentException("数据库表名一定存在"); }
                return dbTbaleName; }
            private set
            { dbTbaleName = value; }
        }
        public static DBNameModel DBNameModel { get; set; }
        public DBInitial()
        {
            DBTableName = new DBTableName();
        }
    }
}
