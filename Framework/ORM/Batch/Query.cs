/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM.Batch
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/15 14:49:41
* 更新时间 : 2018/8/15 14:49:41
*************************************************************************************************
 * 该代码为自动生成代码，请勿编写任何有意义的信息
 * Copyright @ hongyichao 2017. All reghts reserved
*************************************************************************************************/
using Framework.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM.Batch
{
    /*
     * 暂时只考虑单表查询的方式,类似Inner Join之类后期维护
     * 以对象的方式去组成一个sql树,最终通过树形对象来拼接sql
     * 如 select id from a,
     * 那么首先有FromClass
     *  */
    public abstract class Query
    {
        protected IDataEntity DataEntity;
        protected DBTableTree TableTreeQuery;
        protected Query QueryList;
        public Query(IDataEntity entity)
        {
            DataEntity = entity;
            TableTreeQuery = new DBTableTree();
        }
        public abstract Query Select(params String[] selectValue);
        public abstract Query Get(String name, String value);
        public abstract Query As(String asName);
        public abstract Query Delete();//本身想解析出专门的一个解析类
        public abstract Query Update();//本身想解析出专门的一个解析类
        public abstract Query Insert();//本身想解析出专门的一个解析类
        public abstract String All();
        public abstract Query Where(String name, String value);
        public abstract Query LeftJoin(IDataEntity other);
        public abstract String End();
    }
}
