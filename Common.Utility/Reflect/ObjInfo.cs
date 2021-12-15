using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Commom.Utility.Reflect
{
    public class ObjInfo
    {
        public static Dictionary<string, List<ClassAttribute>> _System_ClassAttrCache = new Dictionary<string, List<ClassAttribute>>();
        public static Dictionary<string, List<ClassAttribute>> _System_ClassFieldCache = new Dictionary<string, List<ClassAttribute>>();


        /// <summary>  
        /// 获取对象的属性和值（带缓存）
        /// </summary>  
        /// <param name="obj">对象</param>  
        /// <returns>返回属性与值一一对应的字典</returns>  
        public static List<ClassAttribute> GetPropertyValue<T>(T obj)
        {
            if (obj != null)
            {
                Type type = obj.GetType();
                string key = type.ToString();
                if (_System_ClassAttrCache.ContainsKey(key))
                {
                    return _System_ClassAttrCache[key];
                }
                List<ClassAttribute> classAttributes = new List<ClassAttribute>();


                PropertyInfo[] propertyInfos = type.GetProperties();

                foreach (PropertyInfo item in propertyInfos)
                {
                    Object[] obs = item.GetCustomAttributes(false);
                    classAttributes.Add(new ClassAttribute()
                    {
                        AttributeName = item.Name,
                        AttributeValue = (item.GetValue(obj, null) == null ? "" : item.GetValue(obj, null)).ToString(),
                        AttributeDes = (obs != null && obs.Length > 0) ? (obs[0] as DescriptionAttribute).Description : ""
                    });
                }
                _System_ClassAttrCache.Add(key, classAttributes);
                return classAttributes;
            }
            return null;
        }

        /// <summary>  
        /// 获取对象的字段和值 （带缓存）
        /// </summary>  
        /// <param name="obj">对象</param>  
        /// <returns>返回属性与值一一对应的字典</returns>  
        public static List<ClassAttribute> GetFieldValue<T>(T obj)
        {
            if (obj != null)
            {
                Type type = obj.GetType();
                string key = type.ToString();
                if (_System_ClassFieldCache.ContainsKey(key))
                {
                    return _System_ClassFieldCache[key];
                }

                List<ClassAttribute> classAttributes = new List<ClassAttribute>();
                FieldInfo[] fieldInfos = type.GetFields();

                foreach (FieldInfo item in fieldInfos)
                {

                    Object[] obs = item.GetCustomAttributes(false);

                    classAttributes.Add(new ClassAttribute()
                    {
                        AttributeName = item.Name,
                        AttributeValue = (item.GetValue(obj) == null ? "" : item.GetValue(obj)).ToString(),
                        AttributeDes = (obs != null && obs.Length > 0) ? (obs[0] as DescriptionAttribute).Description : ""
                    });
                }
                _System_ClassFieldCache.Add(key, classAttributes);
                return classAttributes;
            }
            return null;
        }

    }
}
