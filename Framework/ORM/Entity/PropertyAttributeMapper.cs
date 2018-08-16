/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM.Entity
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/15 15:01:43
* 更新时间 : 2018/8/15 15:01:43
*************************************************************************************************
 * 该代码为自动生成代码，请勿编写任何有意义的信息
 * Copyright @ hongyichao 2017. All reghts reserved
*************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM.Entity
{
    /*
     对每个Entity表中的字段进行包装,Name表示字段, List存储反射出来的所有的特性名
     */
    public class PropertyAttributeMapper
    {
        /// <summary>
        /// 当前表的字段名
        /// </summary>
        public String Name { get; set; }
        public List<Attribute> Attributes{ get; private set; }
        public PropertyAttributeMapper()
        {
            Attributes = new List<Attribute>();
        }
    }
}
