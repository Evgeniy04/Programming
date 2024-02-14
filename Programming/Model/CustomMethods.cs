using System;
using System.Linq;

static class CustomMethods
{
    static public readonly Type[] TypeModel = new Type[] { typeof(Color), typeof(EducationForm),
                                            typeof(Genre), typeof(Manufactures),
                                            typeof(Season), typeof(Weekday) };

    static public bool TryGetEnumValue(Type itemType, string itemName, out object value)
    {
        if (itemType != null && TypeModel.Contains(itemType))
        {
            value = Enum.Parse(itemType, itemName);
            return true;
        }
        value = null;
        return false;
    }

    static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
    {
        if (Enum.TryParse<T>(itemName, true, out value))
        {
            return true;
        }
        value = default;
        return false;
    }
}
