using System;

namespace Commom.Utility
{
    /// <summary>
    /// 日志调用类
    /// </summary>
    public class LogHelper
    {
        /// <summary>
        /// 日志对象
        /// </summary>
        private static LogChip logChiper = new LogChip(AppDomain.CurrentDomain.BaseDirectory + @"Log\", LogType.Daily);

        /// <summary>
        /// 写信息
        /// </summary>
        /// <param name="p"></param>
        public static void Write(string p)
        {
            logChiper.Write(DateTime.Now, p, MsgType.Information);
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="returnString"></param>
        public static void WriteLogo(string returnString)
        {
            logChiper.Write(DateTime.Now, returnString, MsgType.Information);
        }

        /// <summary>
        /// 写调试信息
        /// </summary>
        /// <param name="returnString"></param>
        public static void WriteDebug(string returnString)
        {
            logChiper.Write(DateTime.Now, returnString, MsgType.Information);
        }

        /// <summary>
        /// 写警告
        /// </summary>
        /// <param name="returnString"></param>
        public static void WriteWarn(string returnString)
        {
            logChiper.Write(DateTime.Now, returnString, MsgType.Warning);
        }

        /// <summary>
        /// 写错误信息
        /// </summary>
        /// <param name="returnString"></param>
        public static void WriteError(string returnString)
        {
            logChiper.Write(DateTime.Now, returnString, MsgType.Error);
        }

        public static void WriteException(Exception ex)
        {
            WriteError(GetExceptionMessage(ex));
        }
        internal static string GetExceptionMessage(Exception err)
        {
            string text = err.Message;
            if (err.InnerException != null)
            {
                string text2 = text;
                text = string.Concat(new string[]
                {
                    text2,
                    ":",
                    err.InnerException.Message,
                    Environment.NewLine,
                    err.InnerException.StackTrace
                });
            }
            else
            {
                text = text + ":" + Environment.NewLine + err.StackTrace;
            }
            return text;
        }
    }
}
