using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Extensions
{
    public static class GenericExtension
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
        public static bool IsNull<T>(this T obj) where T : class
        {
            if (obj is string)
            {
                return (obj as string).IsNullOrEmpty();
            }
            return obj == null;
        }
        public static void IsNull<T>(this T obj, Action<T> Act) where T : class
        {
            if (obj is string)
            {
                if ((obj as string).IsNullOrEmpty())
                {
                    Act(obj);
                }
            }

            if (obj == null)
            {
                Act(obj);
            }
        }
        public static bool IsNotNull<T>(this T obj)
        {
            if (obj is string)
            {
                return !(obj as string).IsNullOrEmpty();
            }
            return obj != null;
        }
        public static void IsNotNull<T>(this T obj, Action<T> Act)
        {
            if (obj is string)
            {
                if (!(obj as string).IsNullOrEmpty())
                {
                    Act(obj);
                }
            }

            if (obj != null)
            {
                Act(obj);
            }
        }

        public static T ToCast<T>(this object Obj)
        {
            return (T)Convert.ChangeType(Obj, typeof(T));
        }

        public static T With<T>(this T item, Action<T> action)
        {
            if (item != null)
            {
                action(item);
            }
            return item;
        }
        public static void Do<T>(this T obj, Action<T> action)
        {
            if (obj is not null)
            {
                action(obj);
            }
        }
    }
}
