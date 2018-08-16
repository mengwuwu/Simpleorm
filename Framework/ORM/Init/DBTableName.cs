/************************************************************************************************
* 项目名称 : $projectname$
* 项目描述 : 
* 版本号   : v1.0.0.0
* 作者     : 97097
* 所在的域 : DESKTOP-N6JTN02
* 命名空间 : Framework.ORM
* 机器名称 : DESKTOP-N6JTN02
* CLR版本号: 4.0.30319.42000
* 创建时间 : 2018/8/15 10:27:32
* 更新时间 : 2018/8/15 10:27:32
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
    /*
     针对每个配置的DB表进行管控,要嘛对其升级,要嘛添加新表,要嘛直接判断
         */
    public class DBTableName : List<Type>, IDBManager
    {
        public void InitDB()
        {
            for(var i = 0; i < this.Count(); i++)
            {
                //针对每个值进行操作,实现当前DB的初始化管理
            }
        }
        public virtual void onCreate()
        {
            throw new NotImplementedException();
        }

        public virtual void onUpgrade()
        {
            throw new NotImplementedException();
        }

    }
}
