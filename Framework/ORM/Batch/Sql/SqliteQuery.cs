/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM.Batch.Sql
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/16 15:06:34
* 更新时间 : 2018/8/16 15:06:34
*************************************************************************************************
 * 该代码为自动生成代码，请勿编写任何有意义的信息
 * Copyright @ hongyichao 2017. All reghts reserved
*************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM.Batch.Sql
{
    /// <summary>
    /// 针对Sqlite类进行sql具体化,只关心sql拼接,而不会与数据库进行关联,
    /// 与数据库进行关联的操作拆分,作为Responitory层执行
    /// 这里没使用泛型的原因是,java中泛型不支持typeof初始化的操作
    /// </summary>
    public class SqliteQuery : Query
    {
        public SqliteQuery(IDataEntity entity) : base(entity)
        {
            
        }

        public override Query As(string asName)
        {
            this.TableTreeQuery.AsName = asName;
            return this;
        }

        public override String End()
        {
            StringBuilder sb = new StringBuilder();
            if(this.TableTreeQuery.AsName == null)
            {

            }
            return sb.ToString();
        }

        public override Query Get(string name, string value)
        {
            return Where(name, value);
        }
        public override String All()
        {
            return End();
        }

        public override Query LeftJoin(IDataEntity other)
        {
            SqliteQuery query = new SqliteQuery(other);
            QueryList = query;
            return query;
        }

        public override Query Select(params string[] selectValue)
        {

            this.TableTreeQuery.SelectQuery.Add(String.Join(",", selectValue));
            return this;
        }

        public override Query Where(string name, string value)
        {
            this.TableTreeQuery.WhereQuery.Add($"{name}={value}");
            return this;
        }
    }
}
