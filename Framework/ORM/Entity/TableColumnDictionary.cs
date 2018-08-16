/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM.Entity
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/15 15:17:55
* 更新时间 : 2018/8/15 15:17:55
*************************************************************************************************
 * 该代码为自动生成代码，请勿编写任何有意义的信息
 * Copyright @ hongyichao 2017. All reghts reserved
*************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM.Entity
{
    /*
     * 针对实体进行反射出每个字段,并进行保存
     * 在第二次执行的时候就不需要再反射出代码了
     */
    public class TableColumnDictionary:Dictionary<Type, List<PropertyAttributeMapper>>
    {
        public TableColumnDictionary()
        {
            var items = DBInitial.DBTableName;
            foreach(var item in items)
            {
                this.Add(item, GetTypeProperty(item));
            }
        }
        private List<PropertyAttributeMapper> GetTypeProperty(Type type)
        {
            FieldInfo[] items = type.GetFields();
            List<PropertyAttributeMapper> list = new List<PropertyAttributeMapper>();
            foreach (var item in items)
            {
                PropertyAttributeMapper mapper = new PropertyAttributeMapper();
                mapper.Name = item.Name;
                mapper.Attributes.AddRange(item.GetCustomAttributes<DbOperatorAttribute>());//只反射出自定义的特性
                list.Add(mapper);
            }
            return list;
        }
        public DbOperatorAttribute Find(String attName, String columnName = "Id")
        {

            return null;
        }
    }
}
