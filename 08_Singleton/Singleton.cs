using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Singleton
{
    internal class Singleton
    {
        private static Singleton instance = new Singleton();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
