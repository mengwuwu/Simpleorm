/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM.Attributes
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/15 10:56:23
* 更新时间 : 2018/8/15 10:56:23
*************************************************************************************************
 * 该代码为自动生成代码，请勿编写任何有意义的信息
 * Copyright @ hongyichao 2017. All reghts reserved
*************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM.Attributes
{
    /// <summary>
    /// 定义DB中字段自增
    /// </summary>
    public class DBIncreamentAttribute : DbOperatorAttribute
    {
        public override bool Equals(DbOperatorAttribute attr)
        {
            return true;
        }
    }
}
