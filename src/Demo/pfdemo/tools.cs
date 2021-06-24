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
}
