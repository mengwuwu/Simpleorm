using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ORM
{
    public abstract class DbOperatorAttribute:Attribute
    {
        public override bool Equals(object obj)
        {
            DbOperatorAttribute attr = obj as DbOperatorAttribute;
            if (attr == null) return false;
            return Equals(attr);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public abstract bool Equals(DbOperatorAttribute attr);
    }
}
