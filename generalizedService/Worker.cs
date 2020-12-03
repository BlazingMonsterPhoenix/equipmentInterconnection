using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace generalizedService
{
    class Worker
    {

        /**
         * 入口程序
         * */
        public static void work(object sender, ElapsedEventArgs args)
        {
            //读数据
            StringBuilder sb = TxtAnalysis.ExecuteOption(GlobleParams.getDeviceID);
            //写日志
            writeLog(sb);
        }

        /**
         * 写日志
         */
        private static void writeLog(StringBuilder sb)
        {
            FileStream fs = new FileStream(GlobleParams.setLogFilePath(), FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("gb2312"));
            sw.WriteLine(sb.ToString());
            sw.Close();
            sw.Dispose();
            fs.Close();
            fs.Dispose();
        }


    }
}
