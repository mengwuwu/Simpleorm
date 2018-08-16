using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM
{
    public interface IDBManager
    {
        void onCreate();
        void onUpgrade();
    }
}
