using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 文件及文件夹检查类
 * */
namespace generalizedService
{
    class FilesCheker
    {
        /**
         * 入口程序
         * 检查程序需要的文件夹是否齐全，源文件不存在时抛出异常
         * */
        public static void checkFiles()
        {
            if (SrcFilesExcise())
            {
                checkLogFiles();
                checkDescFiles();
            }
            else
            {
                //抛出异常
            }
        }

        /**
         * 检查日志文件夹和文件，不存在则创建
         * */
        private static void checkLogFiles()
        {

        }

        /**
         * 检查文件剪切目标路径，不存在则创建
         * */
        private static void checkDescFiles()
        {

        }

        /**
         * 检查文件剪切源文件目录是否存在
         * */
        private static bool SrcFilesExcise()
        {
            return true;
        }

    }
}
