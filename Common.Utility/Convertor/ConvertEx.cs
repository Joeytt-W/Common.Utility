using System;
using System.Globalization;

namespace Commom.Utility.Convertor
{
    /// <summary>    
    ///数据转换器, 实际封装.Net的Convert对象.
    /// </summary>
    public class ConvertEx
    {
        /// <summary>
        /// 将日期转换为指定格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <param name="format">日期格式, 如: yyyy-MM-dd</param>
        /// <returns>返回字符串类型</returns>
        public static string ToDateString(DateTime dt, string format)
        {
            return dt.ToString(format, DateTimeFormatInfo.CurrentInfo);
        }
        public static string ToDateString(DateTime dt)
        {
            return ToDateString(dt, "yyyy-MM-dd");
        }

        /// <summary>
        /// 将日期转换为年/月/日格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYYMMDDLong(DateTime dt)
        {
            return dt.ToString("yyyy/MM/dd", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年月(YYMM)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYMM(DateTime dt)
        {
            return dt.ToString("yyMM", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年(YY)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYY(DateTime dt)
        {
            return dt.ToString("yy", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年(YYYY)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYY(DateTime dt)
        {
            return dt.ToString("yyyy", DateTimeFormatInfo.CurrentInfo);
        }


        /// <summary>
        /// 将日期转换为年月(YYYYMM)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYYMM(DateTime dt)
        {
            return dt.ToString("yyyyMM", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年月日(YYYYMMDD)格式的字符串，当日期为系统最小日期否返回空字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYYMMDD(DateTime dt)
        {
            string temp = dt.ToString("yyyyMMdd", DateTimeFormatInfo.CurrentInfo);
            if (temp == "00010101") temp = "";
            return temp;
        }

        /// <summary>
        /// 将日期转换为年月日时分秒(YYYYMMDDHHMMSS)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYYMMDDHHMMSS(DateTime dt)
        {
            return dt.ToString("yyyyMMddHHmmss", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为日/月/年 时:分:秒(DD/MM/YYYY HH:MM:SS)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharDD_MM_YYYY_HHMMSS(DateTime dt)
        {
            return dt.ToString("dd/MM/yyyy HH:mm:ss", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年/月/日 时:分:秒(YYYY/MM/DD HH:MM:SS)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYY_MM_DD_HHMMSS(DateTime dt)
        {
            return dt.ToString("yyyy/MM/dd HH:mm:ss", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年月日 时:分:秒(YYYYMMDD HH:MM:SS)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYYMMDDHHMMSS000(DateTime dt)
        {
            return dt.ToString("yyyyMMdd HH:mm:ss:000", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年月日(YYMMDD)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYMMDD(DateTime dt)
        {
            return dt.ToString("yyMMdd", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 转换为Boolean类型
        /// </summary>
        /// <param name="o">必须是可转换为Boolean类型的字符串如"True","False",或其它特殊对象</param>
        /// <returns>返回bool类型</returns>
        public static bool ToBoolean(object o)
        {
            if (null == o) return false;
            try
            {
                return ToBoolean(o.ToString());
            }
            catch { return false; }
        }

        public static bool ToBoolean(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            else
            {
                return str.Trim().Equals("1") || str.Trim().ToLower().Equals("true");
            }
        }
        public static bool ToBoolean(int i)
        {
            return i == 1;
        }
        /// <summary>
        /// 转换为浮点类型
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static float ToFloat(object o)
        {
            return ToFloat(o, 0);
        }
        public static float ToFloat(object o, float defalut)
        {
            if (null == o) return defalut;
            try
            {
                return (float)Convert.ToDouble(o.ToString());
            }
            catch { return defalut; }
        }
        /// <summary>
        /// 转换为decimal类型(有效十进制数)
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static decimal ToDecimal(object o)
        {
            if (null == o) return 0;
            if (string.IsNullOrWhiteSpace(o.ToString())) return 0;
            try
            {

                return Convert.ToDecimal(o.ToString());
            }
            catch { return 0; }
        }

        public static double ToDouble(object o)
        {
            return (double)ToDecimal(o);
        }

        /// <summary>
        /// 四舍五入
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static object ToDecimalFormat(decimal d)
        {
            return (object)(decimal.Round(d, 2).ToString("0.00"));
        }
        /// <summary>
        /// 四舍五入(重载)
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static object ToDecimalFormat(object d)
        {
            return (object)(decimal.Round(Convert.ToDecimal(d == null || d.ToString() == "" ? "0" : d.ToString()), 2).ToString("0.00"));
        }

        /// <summary>
        /// 转换为日期对象
        /// </summary>
        /// <param name="o">日期对象(泛型)，如为空的字段数据DBNull.NULL</param>
        /// <returns></returns>
        public static DateTime ToDateTime(DateTime? o)
        {
            if (null == o) return DateTime.MinValue;
            try
            {
                return DateTime.Parse(o.ToString());
            }
            catch { return DateTime.MinValue; }
        }

        /// <summary>
        /// 转换日期字符串. 对象为空则返回'null'字符串(无单引号). 
        /// 用于动态组合SQL字符串.
        /// </summary>
        /// <param name="o">日期对象</param>
        /// <param name="dateFormat">日期格式</param>
        /// <param name="quotationMark">返回的日期字符串是否打上单引号</param>        
        public static string ToDateTimeString(object o, string dateFormat, bool quotationMark)
        {
            try
            {
                DateTime? dateGenType = ToDateTime(o);
                string datestr = string.Empty;
                if (dateGenType == null)
                    return "null";
                else
                {
                    DateTime dt = DateTime.Parse(dateGenType.ToString());
                    datestr = dt.ToString(dateFormat, DateTimeFormatInfo.CurrentInfo);
                }
                if (quotationMark)
                    return "'" + datestr + "'";
                else
                    return datestr;
            }
            catch
            {
                return "null";
            }
        }
        public static string ToDateTimeString(object o)
        {
            DateTime dateTime = ToDateTime(o);
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 转换为日期对象
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(object o)
        {
            if (null == o || o == DBNull.Value) return ToDateTime("1900-01-01");
            try
            {
                return Convert.ToDateTime(o.ToString());
            }
            catch { return ToDateTime("1900-01-01"); }
        }

        /// <summary>
        /// 转换为整数
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static int ToInt(object o)
        {
            if (null == o) return 0;
            try
            {
                return Convert.ToInt32(o.ToString());
            }
            catch { return 0; }
        }

        /// <summary>
        /// 转换整数
        /// </summary>
        /// <param name="o"></param>
        /// <returns>成功返回相应的整数，失败返回-1</returns>
        public static int ToInt32(string o)
        {
            int rstInt = 0;
            return int.TryParse(o, out rstInt) == true ? rstInt : -1;
        }

        public static int ToInt(bool b)
        {
            return b ? 1 : 0;
        }
        public static Int64 ToInt64(object o)
        {
            if (null == o) return 0;
            try
            {
                return Convert.ToInt64(o.ToString());
            }
            catch { return 0; }
        }
        /// <summary>
        /// 转换为字符串
        /// </summary>
        /// <param name="obj">当对象为空，返回string.Empty</param>
        /// <returns></returns>
        public static string ToString(object obj)
        {
            if (obj == null) return string.Empty;
            return obj.ToString().Trim();
        }

        /// <summary> 
        /// 金额小写变大写 
        /// </summary> 
        /// <param name="smallnum"></param> 
        /// <returns></returns> 
        public static string ToCapital(decimal smallnum)
        {
            string cmoney, cnumber, cnum, cnum_end, cmon, cno, snum, sno;
            int snum_len, sint_len, cbegin, zflag, i;
            if (smallnum > 1000000000000 || smallnum < -99999999999)
                return "";
            if (smallnum == 0)
                return "零元整";
            cmoney = "仟佰拾亿仟佰拾万仟佰拾元角分";// 大写人民币单位字符串 
            cnumber = "壹贰叁肆伍陆柒捌玖";// 大写数字字符串 
            cnum = "";// 转换后的大写数字字符串 
            cnum_end = "";// 转换后的大写数字字符串的最后一位 
            cmon = "";// 取大写人民币单位字符串中的某一位 
            cno = "";// 取大写数字字符串中的某一位 

            snum = System.Decimal.Round(smallnum, 2).ToString("############.00"); ;// 小写数字字符串 
            snum_len = snum.Length;// 小写数字字符串的长度 
            sint_len = snum_len - 2;// 小写数字整数部份字符串的长度 
            sno = "";// 小写数字字符串中的某个数字字符 
            cbegin = 15 - snum_len;// 大写人民币单位中的汉字位置 
            zflag = 1;// 小写数字字符是否为0(0=0)的判断标志 
            i = 0;// 小写数字字符串中数字字符的位置 

            if (snum_len > 15)
                return "";
            for (i = 0; i < snum_len; i++)
            {
                if (i == sint_len - 1)
                    continue;


                cmon = cmoney.Substring(cbegin, 1);
                cbegin = cbegin + 1;
                sno = snum.Substring(i, 1);
                if (sno == "-")
                {
                    cnum = cnum + "负";
                    continue;
                }
                else if (sno == "0")
                {
                    if (cnum.Length - 2 < 0)
                    {
                        continue;
                    }

                    cnum_end = cnum.Substring(cnum.Length - 2, 1);
                    if (cbegin == 4 || (cbegin == 8 || cnum_end.IndexOf("亿") >= 0 || cbegin == 12))
                    {
                        cnum = cnum + cmon;
                        if (cnumber.IndexOf(cnum_end) >= 0)
                            zflag = 1;
                        else
                            zflag = 0;
                    }
                    else
                    {
                        zflag = 0;
                    }
                    continue;
                }
                else if (sno != "0" && zflag == 0)
                {
                    cnum = cnum + "零";
                    zflag = 1;
                }
                cno = cnumber.Substring(System.Convert.ToInt32(sno) - 1, 1);
                cnum = cnum + cno + cmon;
            }
            if (snum.Substring(snum.Length - 2, 1) == "0")
            {
                return cnum + "整";
            }
            else
                return cnum;
        }

        /// <summary>
        /// 时间转整型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int DateToInt(object obj)
        {
            DateTime dateTime = (obj != null && obj != DBNull.Value) ? DateTime.Parse(obj.ToString()) : DateTime.MinValue;
            string str = dateTime.Year.ToString();
            string text = dateTime.Month.ToString();
            if (text.Length == 1)
            {
                text = "0" + text;
            }
            string text2 = dateTime.Day.ToString();
            if (text2.Length == 1)
            {
                text2 = "0" + text2;
            }
            return int.Parse(str + text + text2);
        }

        /// <summary>
        /// 将时间转成oracle语法的条件
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string OracleDateFormat(object date)
        {
            return string.Format("(to_date('{0}','yyyy-MM-dd HH24:mi:ss'))", date);
        }

        public static decimal ToMoney(object obj, int decimals)
        {
            decimal result;
            try
            {
                decimal sourceNum = 0m;
                bool flag = decimal.TryParse(obj.ToString(), out sourceNum);
                if (flag)
                {
                    result = Convert.ToDecimal(ToRound(sourceNum, decimals).ToString("f2"));
                    return result;
                }
                result = decimal.Zero;
                return result;
            }
            catch (Exception ex)
            {

                // throw;
            }
            result = decimal.Zero;
            return result;
        }

        public static string CreateZeros(int zeroCounts)
        {
            string text = string.Empty;
            bool flag = zeroCounts == 0;
            string result;
            if (flag)
            {
                text = "";
                result = text;
            }
            else
            {
                for (int i = 0; i < zeroCounts; i++)
                {
                    text += "0";
                }
                result = text;
            }

            return result;
        }

        public static decimal ToRound(decimal sourceNum, int toRemainIndex)
        {
            decimal num = sourceNum;
            decimal result;
            try
            {
                string text = sourceNum.ToString();
                bool flag = !text.Contains(".");
                if (flag)
                {
                    num = Convert.ToDecimal(text + "." + CreateZeros(toRemainIndex));
                    result = num;
                }
                else
                {
                    bool flag2 = text.Length - text.IndexOf(".") - 1 <= toRemainIndex;
                    if (flag2)
                    {
                        num = Convert.ToDecimal(text + CreateZeros(toRemainIndex - (text.Length - text.IndexOf(".") - 1)));
                        result = num;
                    }
                    else
                    {
                        string value = string.Empty;
                        value = text.Substring(0, text.IndexOf(".") + toRemainIndex + 1);
                        decimal num2 = Convert.ToDecimal(value);


                        bool flag3 = int.Parse(text.Substring(text.IndexOf(".") + toRemainIndex + 1)) >= 5;
                        if (flag3)
                        {
                            string value2 = "0." + CreateZeros(toRemainIndex - 1) + "1";
                            num = num2 + Convert.ToDecimal(value2);

                        }
                        else
                        {
                            num = num2;
                        }

                        result = num;
                    }

                }

            }
            catch (Exception)
            {

                result = num;
                throw;
            }

            return result;
        }

        /// <summary>
        /// 转换成星期几
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string DateToWeekDay(object obj)
        {
            switch (((obj != null && obj != DBNull.Value) ? DateTime.Parse(obj.ToString()) : DateTime.MinValue).DayOfWeek)
            {
                case DayOfWeek.Friday:
                    return "星期五";
                case DayOfWeek.Thursday:
                    return "星期四";
                case DayOfWeek.Wednesday:
                    return "星期三";
                case DayOfWeek.Tuesday:
                    return "星期二";
                case DayOfWeek.Monday:
                    return "星期一";
                case DayOfWeek.Saturday:
                    return "星期六";
                case DayOfWeek.Sunday:
                    return "星期日";
                default:
                    return "";
            }
        }
    }
}
