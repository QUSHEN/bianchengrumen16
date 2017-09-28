using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDemo
{
    static class FileOperator
    {
        public static string filesize(long length)//文件字节数
        {
            double size = Convert.ToDouble(length);//length转换成double
            if(size < 1048576)//2的20次方，文件小于1MB
            {
                return string.Format("{0:N0}KB", size / 1024);
            }
            else
                return string.Format("{0:N1}MB", size / 1048576);
        }
    }
}
