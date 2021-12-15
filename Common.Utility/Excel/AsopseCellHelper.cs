using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Common.Utility.Excel
{
    public class AsopseCellHelper
    {
        /// <summary>
        /// 将DataTable中数据写入到CSV文件中
        /// </summary>
        /// <param name="dt">提供保存数据的DataTable</param>
        /// <param name="fileName">CSV的文件路径</param>
        public static void SaveCSV(DataTable dt, string fullPath)
        {
            FileInfo fi = new FileInfo(fullPath);
            if (!fi.Directory.Exists)
            {
                fi.Directory.Create();
            }
            FileStream fs = new FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            string data = "";
            //写出列名称
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                data += dt.Columns[i].ColumnName.ToString();
                if (i < dt.Columns.Count - 1)
                {
                    data += ",";
                }
            }
            sw.WriteLine(data);
            //写出各行数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string str = dt.Rows[i][j].ToString();
                    str = str.Replace("\"", "\"\"");//替换英文冒号 英文冒号需要换成两个冒号
                    if (str.Contains(',') || str.Contains('"')
                        || str.Contains('\r') || str.Contains('\n')) //含逗号 冒号 换行符的需要放到引号中
                    {
                        str = string.Format("\"{0}\"", str);
                    }

                    data += str;
                    if (j < dt.Columns.Count - 1)
                    {
                        data += ",";
                    }
                }
                sw.WriteLine(data);
            }
            sw.Close();
            fs.Close();
            //DialogResult result = MessageBox.Show("CSV文件保存成功！");
            //if (result == DialogResult.OK)
            //{
            //    System.Diagnostics.Process.Start("explorer.exe", Common.PATH_LANG);
            //}
        }

        /// <summary>
        /// 将CSV文件的数据读取到DataTable中
        /// </summary>
        /// <param name="fileName">CSV文件路径</param>
        /// <returns>返回读取了CSV数据的DataTable</returns>
        public static DataTable OpenCSV(string filePath)
        {
            Encoding encoding = Encoding.UTF8; //Encoding.ASCII;//
            DataTable dt = new DataTable();
            FileStream fs = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);

            //StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            StreamReader sr = new StreamReader(fs, encoding);
            //string fileContent = sr.ReadToEnd();
            //encoding = sr.CurrentEncoding;
            //记录每次读取的一行记录
            string strLine = "";
            //记录每行记录中的各字段内容
            string[] aryLine = null;
            string[] tableHead = null;
            //标示列数
            int columnCount = 0;
            //标示是否是读取的第一行
            bool IsFirst = true;
            //逐行读取CSV中的数据
            while ((strLine = sr.ReadLine()) != null)
            {
                //strLine = Common.ConvertStringUTF8(strLine, encoding);
                //strLine = Common.ConvertStringUTF8(strLine);

                if (IsFirst == true)
                {
                    tableHead = strLine.Split(',');
                    IsFirst = false;
                    columnCount = tableHead.Length;
                    //创建列
                    for (int i = 0; i < columnCount; i++)
                    {
                        DataColumn dc = new DataColumn(tableHead[i]);
                        dt.Columns.Add(dc);
                    }
                }
                else
                {
                    aryLine = strLine.Split(',');
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < columnCount; j++)
                    {
                        dr[j] = aryLine[j].Replace("\"", "");
                    }
                    dt.Rows.Add(dr);
                }
            }
            //if (aryLine != null && aryLine.Length > 0)
            //{
            //    dt.DefaultView.Sort = tableHead[0] + " " + "asc";
            //}

            sr.Close();
            fs.Close();
            return dt;
        }


        /// <summary>
        /// 读取Excel文件为DataTable，使用Aspose.Cells.dll
        /// </summary>
        /// <param name="filepath"> Excel文件的全路径 </param>
        /// <returns> DataTable</returns>
        public static DataTable ExcelToDataTable(string filepath)
        {
            DataTable dt = new DataTable();
            try
            {
                if (!File.Exists(filepath))
                {
                    return null;
                }
                Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(filepath);
                //workbook.(filepath);
                Aspose.Cells.Worksheet worksheet = workbook.Worksheets[0];
                dt = worksheet.Cells.ExportDataTable(0, 0, worksheet.Cells.MaxDataRow + 1, worksheet.Cells.MaxColumn + 1, true);//showTitle  
                return dt;
            }
            catch (System.Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// JSON保存到CSV
        /// </summary>
        /// <param name="dataDir">路径</param>
        /// <returns></returns>
        public static string JsonToCSV(string dataDir)
        {
            // Read JSON file
            string str = File.ReadAllText(dataDir + "SampleJson.json");

            // Create empty workbook
            Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook();

            // Get Cells
            Aspose.Cells.Cells cells = workbook.Worksheets[0].Cells;

            // Set JsonLayoutOptions
            Aspose.Cells.Utility.JsonLayoutOptions importOptions = new Aspose.Cells.Utility.JsonLayoutOptions();
            importOptions.ConvertNumericOrDate = true;
            importOptions.ArrayAsTable = true;
            importOptions.IgnoreArrayTitle = true;
            importOptions.IgnoreObjectTitle = true;
            Aspose.Cells.Utility.JsonUtility.ImportData(str, cells, 0, 0, importOptions);

            // Save Workbook
            workbook.Save(dataDir + @"Sample_out.csv");

            return "成功";
        }

        /// <summary>
        /// CSV内容转换为JSON
        /// </summary>
        /// <param name="dataDir">路径</param>
        /// <returns></returns>
        public static string CSVToJson(string dataDir)
        {
            // Load CSV file
            Aspose.Cells.LoadOptions loadOptions = new Aspose.Cells.LoadOptions(Aspose.Cells.LoadFormat.Csv);
            //Aspose.Cells.TxtLoadOptions txtLoadOptions = new Aspose.Cells.TxtLoadOptions();
            //txtLoadOptions.Encoding = Encoding.UTF8;
            //Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(dataDir + "Sample_out.csv", txtLoadOptions);
            Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(dataDir + "Sample_out.csv", loadOptions);
            Aspose.Cells.Cell lastCell = workbook.Worksheets[0].Cells.LastCell;

            // Set ExportRangeToJsonOptions
            Aspose.Cells.Utility.ExportRangeToJsonOptions options = new Aspose.Cells.Utility.ExportRangeToJsonOptions();
            Aspose.Cells.Range range = workbook.Worksheets[0].Cells.CreateRange(0, 0, lastCell.Row + 1, lastCell.Column + 1);
            string data = Aspose.Cells.Utility.JsonUtility.ExportRangeToJson(range, options);

            // Write from CSV to a JSON file
            System.IO.File.WriteAllText(dataDir + "CSV_out.json", data);

            return "成功";
        }



        #region 将DataTable保存到Excel内
        /// <summary>
        /// 将DataTable保存到Excel内
        /// </summary>
        /// <param name="dtSource">数据源</param>
        /// <param name="headerWidth">Excel列宽</param>
        /// <param name="filePath">Excel文件保存路径</param>
        /// <param name="sheetRowMax">excel sheet内最大行记录数(默认:60000)</param>
        public static void ExportExcelToSave(DataTable dtSource, string filePath,
            Dictionary<string, double> headerWidth = null,
            int sheetRowMax = 60000)
        {
            Workbook wb = getWorkBookExcel(dtSource, headerWidth, sheetRowMax);
            wb.Save(filePath);
        }
        #endregion

        #region 将DataTable生成Excel文件的数据流
        /// <summary>
        /// 将DataTable生成Excel文件的数据流
        /// </summary>
        /// <param name="dtSource">数据源</param>
        /// <param name="headerWidth">Excel列宽</param>
        /// <param name="dateTimeColumnFormat">时间列格式(默认:yyyy-MM-dd)</param>
        /// <param name="sheetRowMax">excel sheet内最大行记录数(默认:60000)</param>
        /// <returns>返回DataTable生成Excel文件的数据流</returns>
        public static MemoryStream ExportExcelToStream(DataTable dtSource,
            Dictionary<string, double> headerWidth = null,
            int sheetRowMax = 60000)
        {
            Workbook wb = getWorkBookExcel(dtSource, headerWidth, sheetRowMax);
            return wb.SaveToStream();
        }
        #endregion

        #region 将DataTable保存到Excel内并返回Workbook
        /// <summary>
        /// 将DataTable保存到Excel内并返回Workbook
        /// </summary>
        /// <param name="dtSource">数据源</param>
        /// <param name="headerWidth">Excel列宽</param>
        /// <param name="sheetRowMax">excel sheet内最大行记录数</param>
        /// <returns>返回已经被数据源填充的Workbook</returns>
        private static Workbook getWorkBookExcel(DataTable dtSource,
            Dictionary<string, double> headerWidth = null,
            int sheetRowMax = 60000)
        {
            Workbook wb = new Workbook();
            //标题样式
            Style syTitle = new CellsFactory().CreateStyle();
            syTitle.Font.IsBold = true;
            syTitle.HorizontalAlignment = TextAlignmentType.Center;

            //需要sheet的个数
            int sheetCount = dtSource.Rows.Count / sheetRowMax;
            for (int i = 0; i <= sheetCount; i++)
            {
                //数据源行开始位置
                int rowStartIndex = i * sheetRowMax;
                //数据源行结束位置
                int rowEndIndex = ((i + 1) * sheetRowMax) > dtSource.Rows.Count ?
                    dtSource.Rows.Count : ((i + 1) * sheetRowMax);

                if (rowStartIndex < rowEndIndex)
                {
                    int rowStart = 1;
                    int sheetIndex = wb.Worksheets.Add();
                    Worksheet ws = wb.Worksheets[sheetIndex - 1];
                    //标题
                    for (int j = 0; j < dtSource.Columns.Count; j++)
                    {
                        string columnName = dtSource.Columns[j].ColumnName;
                        ws.Cells[0, j].Value = dtSource.Columns[j].ColumnName;
                        ws.Cells[j].SetStyle(syTitle);
                        //设置excel列宽
                        if (headerWidth != null)
                        {
                            ws.Cells.SetColumnWidth(j, headerWidth[columnName]);
                        }
                    }
                    for (int k = rowStartIndex; k < rowEndIndex; k++)
                    {
                        for (int m = 0; m < dtSource.Columns.Count; m++)
                        {
                            string drValue = dtSource.Rows[k][m].ToString();

                            switch (dtSource.Columns[m].DataType.ToString().ToLower())
                            {
                                case "system.string"://字符串类型
                                    ws.Cells[rowStart, m].Value = drValue;
                                    break;
                                case "system.datetime"://日期类型
                                    DateTime dateV;
                                    DateTime.TryParse(drValue, out dateV);
                                    string dateL;
                                    //如果时分秒都为0，则精确到天，否则精确到秒
                                    if (dateV == DateTime.Parse(dateV.ToString("yyyy-MM-dd")))
                                    {
                                        dateL = dateV.ToString("yyyy-MM-dd");
                                    }
                                    else
                                    {
                                        dateL = dateV.ToString("yyyy-MM-dd HH:mm:ss");
                                    }

                                    ws.Cells[rowStart, m].Value = dateL;
                                    break;
                                case "system.boolean"://布尔型
                                    bool boolV = false;
                                    bool.TryParse(drValue, out boolV);
                                    ws.Cells[rowStart, m].Value = boolV;
                                    break;
                                case "system.int16"://整型
                                case "system.int32":
                                case "system.int64":
                                case "system.byte":
                                    int intV = 0;
                                    int.TryParse(drValue, out intV);
                                    ws.Cells[rowStart, m].Value = intV;
                                    break;
                                case "system.decimal"://浮点型
                                case "system.double":
                                    double doubV = 0;
                                    double.TryParse(drValue, out doubV);
                                    ws.Cells[rowStart, m].Value = doubV;
                                    break;
                                case "system.dbnull"://空值处理
                                    ws.Cells[rowStart, m].Value = "";
                                    break;
                                default:
                                    ws.Cells[rowStart, m].Value = "";
                                    break;
                            }

                        }
                        rowStart++;
                    }
                }
            }

            return wb;
        }
        #endregion

        #region 用于Web导出
        /// <summary>
        /// 用于Web导出
        /// </summary>
        /// <param name="dtSource"></param>
        /// <param name="strFileName"></param>
        /// <param name="headerWidth"></param>
        /// <param name="sheetRowMax"></param>
        public static HttpResponseMessage ExportByWeb(DataTable dtSource,
            Dictionary<string, double> headerWidth = null, int sheetRowMax = 60000)
        {
            byte[] bytes = ExportExcelToStream(dtSource, headerWidth, sheetRowMax).GetBuffer();

            //返回一个http响应的消息对象
            if (bytes != null)
            {
                HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
                result.Content = new StreamContent(new MemoryStream(bytes));
                result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                //文件命名        
                result.Content.Headers.ContentDisposition.FileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xls";

                return result;
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
        #endregion
    }
}
