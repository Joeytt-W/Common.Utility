using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Common.Utility.EnumHepler
{
    public class EnumUtils
    {
        /// <summary>
        /// 通过枚举值Name返回枚举描述内容
        /// </summary>
        /// <typeparam name="TEnum">枚举类型</typeparam>
        /// <param name="fldName">枚举值名称</param>
        /// <returns></returns>
        public static string GetEnumDescbyName<TEnum>(string fldName)
        {
            var arr = typeof(TEnum).GetField(fldName).GetCustomAttributes(false);
            if (arr.Length > 0)
            {
                var desAtrr = arr[0] as DescriptionAttribute;
                if (desAtrr != null)
                {
                    return desAtrr.Description;
                }

                return fldName;
            }
            return fldName;
        }

        /// <summary>
        /// 返回枚举描述列表
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static List<string> GetEnumDescList<TEnum>(Type enumType)
        {
            List<string> res = new List<string>();
            foreach (var val in enumType.GetEnumValues())
            {
                var name = Enum.GetName(enumType, val);

                var attr =
                    enumType.GetField(name).GetCustomAttributes(false);
                if (attr != null)
                {
                    var desAtrr = attr[0] as DescriptionAttribute;
                    string strDesc = desAtrr.Description;
                    res.Add(strDesc);
                }
            }
            return res;
        }

        /// <summary>
        /// 返回枚举值列表
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static List<int> GetEnumValueList<TEnum>(Type enumType)
        {
            List<int> res = new List<int>();
            foreach (var val in enumType.GetEnumValues())
            {
                res.Add((int)val);
            }
            return res;
        }

        /// <summary>
        /// 返回枚举值列表
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <returns></returns>
        public static List<EnumDTO> GetEnumLitemList(Type enumType)
        {
            List<EnumDTO> res = new List<EnumDTO>();
            foreach (var val in enumType.GetEnumValues())
            {
                var name = Enum.GetName(enumType, val);

                EnumDTO dto = new EnumDTO
                {
                    EValue = (int)val,
                    EName = name
                };
                var attr =
                    enumType.GetField(name).GetCustomAttributes(false);
                if (attr != null)
                {
                    var desAtrr = attr[0] as DescriptionAttribute;
                    dto.EDescription = desAtrr.Description;
                    res.Add(dto);
                }
            }
            return res;
        }
    }
    /// <summary>
    /// 枚举DTO对象
    /// </summary>
    public class EnumDTO
    {
        /// <summary>
        /// 枚举值
        /// </summary>
        public int EValue { get; set; }

        /// <summary>
        /// 枚举名称
        /// </summary>
        public string EName { get; set; }

        /// <summary>
        /// 枚举描述
        /// </summary>
        public string EDescription { get; set; }
    }
}
