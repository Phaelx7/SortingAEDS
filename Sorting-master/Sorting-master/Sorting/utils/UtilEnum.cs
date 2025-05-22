using System.ComponentModel;
using System.Reflection;

namespace Sorting.utils
{
    public static class UtilEnum
    {
        public static string GetDescription(Enum value)
        {
            var type = value.GetType();

            var field = type.GetField(value.ToString());

            var attribute = field?.GetCustomAttribute<DescriptionAttribute>();

            return attribute?.Description ?? value.ToString();

        }

    }
}