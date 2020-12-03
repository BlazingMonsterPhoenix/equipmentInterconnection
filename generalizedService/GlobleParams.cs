using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generalizedService
{
    class GlobleParams
    {
        //文件夹所在磁盘
        private static string desc;
        //数据采集频率（单位：秒）
        private static double frequency;
        //原文件所在路径（由desc+程序配置文件参数获取）
        private static string scrFolder;
        //剪切文件目标路径（由desc+程序配置文件参数获取）
        private static string destFolder;
        //读取成功文件路径（由desc+程序配置文件参数获取）
        private static string successPath;
        //读取失败文件路径（由desc+程序配置文件参数获取）
        private static string errorPath;

        //设备编号
        public static string deviceID;
        //数据库ip地址
        public static string databaseIP;
        //数据库用户名
        public static string databaseUser;
        //数据库密码
        public static string databasePassword;
        //日志文件夹路径
        public static string logDirectoryPath;
        //日志文件路径
        public static string logFilePath;

        /****************  Set方法区  *******************/
        public static void setDesc(string d)
        {
            desc = d;
            scrFolder = desc + ":\\";
            destFolder = desc + ":\\";
            successPath = desc + ";\\";
            errorPath = desc + ";\\";
        }

        /*****异常处理：非double型字符串******/
        public static void setFrequency(string f)
        {
            frequency = Double.Parse(f);
        }

        public static void setDeviceID(string id)
        {
            deviceID = id;
        }

        public static void setDatabaseIP(string ip)
        {
            databaseIP = ip;
        }

        public static void setDatabaseUser(string user)
        {
            databaseUser = user;
        }

        public static void setDatabasePassword(string password)
        {
            databasePassword = password;
        }

        public static void setLogDirectoryPath(string logDir)
        {
            logDirectoryPath = logDir;
        }

        public static void setLogFilePath(string logPath)
        {
            logFilePath = logPath;
        }


        /****************  Get方法区  *******************/
        public static double getFrequency()
        {
            return frequency;
        }

        public static string getScrFolder()
        {
            return scrFolder;
        }

        public static string getDestFolder()
        {
            return destFolder;
        }

        public static string getSuccessPath()
        {
            return successPath;
        }

        public static string getErrorPath()
        {
            return errorPath;
        }

        public static string getDeviceID()
        {
            return deviceID;
        }

        public static string getDatabaseIP()
        {
            return databaseIP;
        }

        public static string getDatabaseUser()
        {
            return databaseUser;
        }

        public static string getDatabasePassword()
        {
            return databasePassword;
        }

        public static string getLogDirectoryPath()
        {
            return logDirectoryPath;
        }

        public static string setLogFilePath()
        {
            return logFilePath;
        }

        public static string getConnectionString()
        {
            return "server=" + GlobleParams.getDatabaseIP() + ";port=3306;userid=" + GlobleParams.getDatabaseUser() +
                ";password=" + GlobleParams.getDatabasePassword() + ";database=" + ";charset=utf8;";        //数据库表来自程序的配置文件
        }

    }
}
