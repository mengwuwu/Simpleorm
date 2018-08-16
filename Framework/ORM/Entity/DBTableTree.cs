/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM.Entity
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/16 11:40:58
* 更新时间 : 2018/8/16 11:40:58
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
    /// <summary>
    /// 针对组成树的table进行描述,方便组建成代码
    /// </summary>
    public class DBTableTree
    {
        public String AsName { get; set; }
        public List<String> SelectQuery { get; set; } = new List<string>();
        public List<String> WhereQuery { get; set; } = new List<string>();
        public String GroudByQuery { get; set; }
        public String OrderByQuery { get; set; } 
    }
    /// <summary>
    /// 连接种类
    /// </summary>
    public enum JoinType
    {
        AND=1,
        OR=2,
        LeftJoin=3,
        RightJoin=4
    }
}
