using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Project.BusinessLayer
{
    class Validator
    {
        public bool NotNull(object thisobject)
        {
            bool notnull = true;

            foreach (PropertyInfo item in thisobject.GetType().GetProperties())
            {
                if (item.GetValue(thisobject, null) != null)
                {
                    if (String.IsNullOrEmpty(item.GetValue(thisobject, null).ToString()))
                    {
                        notnull = false;
                    }
                }
            }

            return notnull;
        }
    }
}
