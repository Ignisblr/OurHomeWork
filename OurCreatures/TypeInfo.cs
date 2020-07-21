using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    class TypeInfo
    {
        Type type_ = null;
        
        public TypeInfo()
        {; }

        public TypeInfo(Type type)
        {
            this.type_ = type;
        }

        //public IDictionary<PropertyInfo, string> GetPublicProperties()
        //{
        //    IList<PropertyInfo> publicProperties = null;
        //    if (this.type_ != null)
        //    {
        //       publicProperties = type_.GetProperties(BindingFlags.Public).ToList();
        //    }
        //    return publicProperties;
        //}

    }
}
