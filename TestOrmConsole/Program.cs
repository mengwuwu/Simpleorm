using DBMangerModels.ORMModels;
using Framework.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DBInitial.DBNameModel = new DBNameModel() { Name = "Android sdk DB name", Path = "", Version = "1.1.1" };
            DBInitial.DBTableName.Add(typeof(StudentEntity));
        }
    }
}
