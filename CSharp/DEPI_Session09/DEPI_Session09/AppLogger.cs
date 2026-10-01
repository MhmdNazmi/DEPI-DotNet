using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session09
{
    internal class AppLogger
    {
        static AppLogger? _instance = null;

        private AppLogger() { }

        public static AppLogger GetLogger()
        {
            if (_instance == null)
            {
                _instance = new AppLogger();
            }
            return _instance;
        }


    }
}
