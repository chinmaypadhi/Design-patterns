using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class logger
    {
        private static logger loggerIns;
        private logger()
        {

        }
        public static logger getInstance()
        {
            if(loggerIns == null)
            { 
                loggerIns = new logger();
            }
            return loggerIns;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            logger obj1 =  logger.getInstance();
            logger obj2 = logger.getInstance();

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());


            Console.Read();
        }
    }


}




