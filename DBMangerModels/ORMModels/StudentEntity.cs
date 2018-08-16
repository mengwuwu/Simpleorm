/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : DBMangerModels.ORMModels
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/15 10:58:57
* 更新时间 : 2018/8/15 10:58:57
*************************************************************************************************
 * 该代码为自动生成代码，请勿编写任何有意义的信息
 * Copyright @ hongyichao 2017. All reghts reserved
*************************************************************************************************/
using Framework.ORM;
using Framework.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMangerModels.ORMModels
{
    public class StudentEntity : IDataEntity
    {
        [DBIncreament]
        public String Id { get; set; }
        public String Name { get; set; }
        public String Age { get; set; }
        public string MapperDBName() => "t_student";
    }
}
