using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTabPageDemo.Abstract
{
    public static class Constants
    {
        private const string DBFileName = "sqldemo.db3";

        public static string DatabasePath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}
