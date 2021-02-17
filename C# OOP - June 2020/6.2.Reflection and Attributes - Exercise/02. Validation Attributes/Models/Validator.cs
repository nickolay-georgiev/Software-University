using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes.Models
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var objProperties = obj.GetType().GetProperties();

            foreach (var prop in objProperties)
            {
                var attributes = prop.GetCustomAttributes<MyValidationAttribute>();

                foreach (var attribute in attributes)
                {
                    bool result = attribute.IsValid(prop.GetValue(obj));

                    if(result == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
