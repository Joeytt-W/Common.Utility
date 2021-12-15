using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Common.Utility.EnumHepler
{
    public static class EnumExtension
    {
        /// <summary>
        /// 获取枚举名以及对应的Description
        /// </summary>
        /// <param name="type">枚举类型typeof(T)</param>
        /// <returns>返回Tuple  ,item1为枚举value，  item2为枚举对应的Description或枚举name</returns>
        public static List<Tuple<string, string>> GetEnumsAndDescriptionToTuple(this Type type)
        {
            if (type.IsEnum)
            {
                List<Tuple<string, string>> list = new List<Tuple<string, string>>();
                var enumValues = Enum.GetValues(type);
                foreach (Enum value in enumValues)
                {
                    if (string.IsNullOrEmpty(value.GetEnumDescription()))
                    {
                        list.Add(new Tuple<string, string>(Convert.ToInt32(value).ToString(), value.ToString()));
                    }
                    else
                    {
                        list.Add(new Tuple<string, string>(Convert.ToInt32(value).ToString(), value.GetEnumDescription()));
                    }
                }
                return list;
            }
            return null;
        }

        /// <summary>
        /// 根据枚举获取字典
        /// </summary>
        /// <typeparam name="T">枚举类型</typeparam>
        /// <param name="isReverse">是否反转</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetEnumsToDic<T>(bool isReverse = false)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                if (!isReverse)
                {
                    dic.Add(Convert.ToInt64(item).ToString(), item.ToString());
                }
                else
                {
                    dic.Add(item.ToString(), Convert.ToInt64(item).ToString());
                }
            }
            return dic;
        }


        /// <summary>
        /// 根据枚举获取字典
        /// </summary>
        /// <typeparam name="T">枚举类型</typeparam>
        /// <param name="isReverse">是否反转</param>
        /// <returns></returns>
        public static List<EnumClass> GetEnums<T>()
        {
            List<EnumClass> list = new List<EnumClass>();
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                list.Add(new EnumClass { Name = item.ToString(), Value = Convert.ToInt64(item).ToString() });
            }
            return list;
        }

        public static List<EnumClass> GetEnumsByDescription<T>()
        {
            List<EnumClass> list = new List<EnumClass>();
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                var enumObj=(Enum)item;
                
                list.Add(new EnumClass { Name = enumObj.GetEnumDescription(), Value = Convert.ToInt64(item).ToString() });
            }
            return list;
        }

        public static List<dynamic> GetEnumsToDynamic<T>()
        {
            List<dynamic> list = new List<dynamic>();
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                list.Add(item);
            }
            return list;
        }

        public static List<Tuple<string, string>> GetEnumsToTuple<T>()
        {
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                list.Add(new Tuple<string, string>(Convert.ToInt64(item).ToString(), item.ToString()));
            }
            return list;
        }

        /// <summary>
        /// 枚举 int 转 枚举名称
        /// </summary>
        /// <typeparam name="T">枚举</typeparam>
        /// <param name="itemValue">int值</param>
        /// <returns></returns>
        public static string ConvertEnumToString<T>(int itemValue)
        {
            return Enum.Parse(typeof(T), itemValue.ToString()).ToString();
        }

        public static Attribute GetEnumAttribute(this Enum value, Type attribute)
        {
            var enumType = value.GetType();
            var name = Enum.GetName(enumType, value);
            if (name != null)
            {
                // 获取枚举字段。
                var fieldInfo = enumType.GetField(name);
                if (fieldInfo != null)
                {
                    // 获取描述的属性。
                    var attr = Attribute.GetCustomAttribute(fieldInfo,
                        attribute, false);
                    return attr;
                }
            }
            return null;
        }

        /// <summary>
        /// 获取枚举描述内容;
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultval"></param>
        /// <returns></returns>
        public static string GetEnumDescription(this Enum value)
        {
            var attr = GetEnumAttribute(value, typeof(DescriptionAttribute));
            return (attr as DescriptionAttribute)?.Description ?? value.ToString();
        }

        /// <summary>
        /// 根据 枚举值 获取描述
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetEnumDescription<TEnum>(this string enumValue)
        {
            var enumType = (Enum)Enum.Parse(typeof(TEnum), enumValue);
            var attr = GetEnumAttribute(enumType, typeof(DescriptionAttribute));
            return (attr as DescriptionAttribute)?.Description ?? GetEnumName<TEnum>(enumValue);
        }

        /// <summary>
        /// 判断key 在枚举 T 中是否存在
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool IsDefined<T>(string key)
        {
            bool isDefined = Enum.IsDefined(typeof(T), key);
            return isDefined;
        }

        /// <summary>
        /// 根据枚举获取对应 value
        /// Enums.Sex.女.GetEnumToString()
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string GetEnumValueToString(this Enum @this)
        {
            return @this.GetEnumValueToInt().ToString();
        }

        public static int GetEnumValueToInt(this Enum @this)
        {
            return Convert.ToInt32(@this);
        }

        public static int GetEnumValueToInt<TEnum>(this string @this)
        {
            var value = GetEnumByValue<TEnum>(@this);
            var enumValue = Enum.Parse(typeof(TEnum), @this);
            return ((int)enumValue);
        }

        public static string GetEnumValueToString<TEnum>(this string @this)
        {
            return GetEnumValueToInt<TEnum>(@this).ToString();
        }

        /// <summary>
        /// 获取枚举 
        /// </summary>
        /// <typeparam name="T">枚举 类型</typeparam>
        /// <param name="value">枚举 value</param>
        /// <returns></returns>
        public static T GetEnumByValue<T>(this object value)
        {
            var res = (T)Enum.Parse(typeof(T), value.ToString());
            return res;
        }

        /// <summary>
        /// 枚举 int 转 枚举名称
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="itemValue"></param>
        /// <returns></returns>
        public static string GetEnumName<T>(string enumValue)
        {
            return Enum.Parse(typeof(T), enumValue).ToString();
        }

        /// <summary>
        /// 获取枚举 name
        /// </summary>
        /// <typeparam name="T">枚举 类型</typeparam>
        /// <param name="value">枚举 value</param>
        /// <returns></returns>
        public static string GetEnumNameByValue<T>(this object value)
        {
            var res = GetEnumByValue<T>(value);
            return res.ToString();
        }


        /// <summary>
        /// 通过枚举类型获取枚举列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<T> GetEnumNameList<T>()
        {
            List<T> list = Enum.GetValues(typeof(T)).OfType<T>().ToList();
            return list;
        }

        /// <summary>
        /// 通过枚举类型获取枚举 (特性DescriptionAttribute)描述 列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<string> GetEnumDescriptionList<T>()
        {
            var enums = Enum.GetValues(typeof(T));
            List<string> list = new List<string>(enums.Length);
            foreach (Enum value in enums)
            {
                var attr = GetEnumAttribute(value, typeof(DescriptionAttribute));
                list.Add((attr as DescriptionAttribute)?.Description ?? value.ToString());
            }
            return list;
        }

        /// <summary>
        /// 通过枚举类型获取所有枚举
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetAllItems<T>() where T : struct
        {
            foreach (object item in Enum.GetValues(typeof(T)))
            {
                yield return (T)item;
            }
        }

    }

    public class EnumClass
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }
}
