using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    class CustomMethods
    {
        private readonly Type[] _typeModel = new Type[] { typeof(Model.Color), typeof(EducationForm),
                                                typeof(Genre), typeof(Manufactures),
                                                typeof(Season), typeof(Weekday) };

        public bool TryGetEnumValue(Type itemType, string itemName, out object value)
        {
            if (itemType != null && _typeModel.Contains(itemType))
            {
                value = Enum.Parse(itemType, itemName);
                return true;
            }
            value = null;
            return false;
        }

        public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }
    }
}
