using System;
using System.Collections.Generic;
using System.Text;

namespace pfdemo
{
    public class tools
    {
        public static string ReadFile(string path)
        {
            string result;
            if (!System.IO.File.Exists(path))
            {
                result = "不存在相应的目录";
            }
            else
            {
                System.IO.FileStream stream = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
                System.IO.StreamReader streamReader = new System.IO.StreamReader(stream, System.Text.Encoding.Default);
                result = streamReader.ReadToEnd();
                streamReader.Close();
                streamReader.Dispose();
            }
            return result;
        }
        public static void WriteFile(string path, string content)
        {
            try
            {
                object obj = new object();
                if (!System.IO.File.Exists(path))
                {
                    System.IO.FileStream fileStream = System.IO.File.Create(path);
                    fileStream.Close();
                }
                lock (obj)
                {
                    using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(path, false, System.Text.Encoding.Default))
                    {
                        streamWriter.WriteLine(content);
                        streamWriter.Close();
                        streamWriter.Dispose();
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
 
    }

    /// <summary> 
    /// 本类实现阿拉伯数字到大写中文的转换 
    /// 该类没有对非法数字进行判别 
    /// 请调用NumToChn方法 
    /// </summary> 
    public class NumFormat
    {
        public NumFormat()
        {
            // 
            // TODO: 在此处添加构造函数逻辑 
            // 
        }

        // 转换数字 
        private char ToNum(char x)
        {
            string strChnNames = "零壹贰叁肆伍陆柒捌玖";
            string strNumNames = "0123456789";
            return strChnNames[strNumNames.IndexOf(x)];
        }

        // 转换万以下整数 
        private string ChangeInt(string x)
        {
            string[] strArrayLevelNames = new string[4] { "", "十", "百", "千" };
            string ret = "";
            int i;
            for (i = x.Length - 1; i >= 0; i--)
                if (x[i] == '0')
                    ret = ToNum(x[i]) + ret;
                else
                    ret = ToNum(x[i]) +  ret;
            while ((i = ret.IndexOf("零零")) != -1)
                ret = ret.Remove(i, 1);
            if (ret[ret.Length - 1] == '零' && ret.Length > 1)
                ret = ret.Remove(ret.Length - 1, 1);
            if (ret.Length >= 2 && ret.Substring(0, 2) == "一十")
                ret = ret.Remove(0, 1);
            return ret;
        }

        // 转换整数 
        private string ToInt(string x)
        {
            int len = x.Length;
            string ret, temp;
            if (len <= 4)
                ret = ChangeInt(x);
            else if (len <= 8)
            {
                ret = ChangeInt(x.Substring(0, len - 4)) + "万";
                temp = ChangeInt(x.Substring(len - 4, 4));
                if (temp.IndexOf("千") == -1 && temp != "")
                    ret += "零" + temp;
                else
                    ret += temp;
            }
            else
            {
                ret = ChangeInt(x.Substring(0, len - 8)) + "亿";
                temp = ChangeInt(x.Substring(len - 8, 4));
                if (temp.IndexOf("千") == -1 && temp != "")
                    ret += "零" + temp;
                else
                    ret += temp;
                ret += "万";
                temp = ChangeInt(x.Substring(len - 4, 4));
                if (temp.IndexOf("千") == -1 && temp != "")
                    ret += "零" + temp;
                else
                    ret += temp;
            }
            int i;
            if ((i = ret.IndexOf("零万")) != -1)
                ret = ret.Remove(i + 1, 1);
            while ((i = ret.IndexOf("零零")) != -1)
                ret = ret.Remove(i, 1);
            if (ret[ret.Length - 1] == '零' && ret.Length > 1)
                ret = ret.Remove(ret.Length - 1, 1);
            return ret;
        }

        private string ToDecimal(string x)
        {
            string ret = "";
            for (int i = 0; i < x.Length; i++)
                ret += ToNum(x[i]);
            return ret;
        }

        public string NumToChn(string x)
        {
            if (x.Length == 0)
                return "";
            string ret = "";
            if (x[0] == '-')
            {
                ret = "负";
                x = x.Remove(0, 1);
            }
            if (x[0].ToString() == ".")
                x = "0" + x;
            if (x[x.Length - 1].ToString() == ".")
                x = x.Remove(x.Length - 1, 1);
            if (x.IndexOf(".") > -1)
                ret += ToInt(x.Substring(0, x.IndexOf("."))) + "点" + ToDecimal(x.Substring(x.IndexOf(".") + 1));
            else
                ret += ToInt(x);
            return ret;
        }
    }

    public class MoneyConvertChinese
    {
        /// <summary>
        /// 金额转为大写金额
        /// </summary>
        /// <param name="LowerMoney"></param>
        /// <returns></returns>
        public string MoneyToChinese(string LowerMoney)
        {
            string functionReturnValue = null;
            bool IsNegative = false; // 是否是负数
            if (LowerMoney.Trim().Substring(0, 1) == "-")
            {
                // 是负数则先转为正数
                LowerMoney = LowerMoney.Trim().Remove(0, 1);
                IsNegative = true;
            }
            string strLower = null;
            string strUpart = null;
            string strUpper = null;
            int iTemp = 0;
            // 保留两位小数 123.489→123.49　　123.4→123.4
            LowerMoney = Math.Round(double.Parse(LowerMoney), 2).ToString();
            if (LowerMoney.IndexOf(".") > 0)
            {
                if (LowerMoney.IndexOf(".") == LowerMoney.Length - 2)
                {
                    LowerMoney = LowerMoney + "0";
                }
            }
            else
            {
                LowerMoney = LowerMoney + ".00";
            }
            strLower = LowerMoney;
            iTemp = 1;
            strUpper = "";
            while (iTemp <= strLower.Length)
            {
                switch (strLower.Substring(strLower.Length - iTemp, 1))
                {
                    case ".":
                        strUpart = "圆";
                        break;
                    case "0":
                        strUpart = "零";
                        break;
                    case "1":
                        strUpart = "壹";
                        break;
                    case "2":
                        strUpart = "贰";
                        break;
                    case "3":
                        strUpart = "叁";
                        break;
                    case "4":
                        strUpart = "肆";
                        break;
                    case "5":
                        strUpart = "伍";
                        break;
                    case "6":
                        strUpart = "陆";
                        break;
                    case "7":
                        strUpart = "柒";
                        break;
                    case "8":
                        strUpart = "捌";
                        break;
                    case "9":
                        strUpart = "玖";
                        break;
                }

                switch (iTemp)
                {
                    case 1:
                        strUpart = strUpart + "分";
                        break;
                    case 2:
                        strUpart = strUpart + "角";
                        break;
                    case 3:
                        strUpart = strUpart + "";
                        break;
                    case 4:
                        strUpart = strUpart + "";
                        break;
                    case 5:
                        strUpart = strUpart + "拾";
                        break;
                    case 6:
                        strUpart = strUpart + "佰";
                        break;
                    case 7:
                        strUpart = strUpart + "仟";
                        break;
                    case 8:
                        strUpart = strUpart + "万";
                        break;
                    case 9:
                        strUpart = strUpart + "拾";
                        break;
                    case 10:
                        strUpart = strUpart + "佰";
                        break;
                    case 11:
                        strUpart = strUpart + "仟";
                        break;
                    case 12:
                        strUpart = strUpart + "亿";
                        break;
                    case 13:
                        strUpart = strUpart + "拾";
                        break;
                    case 14:
                        strUpart = strUpart + "佰";
                        break;
                    case 15:
                        strUpart = strUpart + "仟";
                        break;
                    case 16:
                        strUpart = strUpart + "万";
                        break;
                    default:
                        strUpart = strUpart + "";
                        break;
                }

                strUpper = strUpart + strUpper;
                iTemp = iTemp + 1;
            }

            strUpper = strUpper.Replace("零拾", "零");
            strUpper = strUpper.Replace("零佰", "零");
            strUpper = strUpper.Replace("零仟", "零");
            strUpper = strUpper.Replace("零零零", "零");
            strUpper = strUpper.Replace("零零", "零");
            strUpper = strUpper.Replace("零角零分", "整");
            strUpper = strUpper.Replace("零分", "整");
            strUpper = strUpper.Replace("零角", "零");
            strUpper = strUpper.Replace("零亿零万零圆", "亿圆");
            strUpper = strUpper.Replace("亿零万零圆", "亿圆");
            strUpper = strUpper.Replace("零亿零万", "亿");
            strUpper = strUpper.Replace("零万零圆", "万圆");
            strUpper = strUpper.Replace("零亿", "亿");
            strUpper = strUpper.Replace("零万", "万");
            strUpper = strUpper.Replace("零圆", "圆");
            strUpper = strUpper.Replace("零零", "零");

            // 对壹圆以下的金额的处理
            if (strUpper.Substring(0, 1) == "圆")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "零")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "角")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "分")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "整")
            {
                strUpper = "零圆整";
            }
            functionReturnValue = strUpper;

            if (IsNegative == true)
            {
                return "负" + functionReturnValue;
            }
            else
            {
                return functionReturnValue;
            }
        }
    }
}
