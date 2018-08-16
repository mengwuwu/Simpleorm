/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : DBBusiness.BasicBusiness
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/16 16:58:24
* 更新时间 : 2018/8/16 16:58:24
*************************************************************************************************
 * 该代码为自动生成代码，请勿编写任何有意义的信息
 * Copyright @ hongyichao 2017. All reghts reserved
*************************************************************************************************/
using DBMangerModels.ORMModels;
using DBRespository.BasicRespository;
using Framework.ORM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBusiness.BasicBusiness
{
    public class StudentBuiness
    {
        private readonly DbRepository respository;
        public StudentBuiness()
        {
            respository = new StudentRespository();
        }
        public StudentBuiness(DbRepository respository)//这里是为了扩展功能,实现loc
        {
            this.respository = respository;
        }
        public IEnumerable<StudentEntity> All()
        {
            return respository.All<StudentEntity>();
        }
    }
}
