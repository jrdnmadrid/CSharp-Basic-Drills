using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenTwelveThirteen
{
    //Custom Delegate
    public delegate void CustomDel(string s);
    //Single Delegate
    public delegate void HelloFunctionDelegate(string Message);
    class Program
    {
        public static void Hello(string s)
        {
            Console.WriteLine(" Hello, {0}", s);
        }

        public static void Goodbye(string s)
        {
            Console.WriteLine(" Goodbye, {0}", s);
        }

        static void Main(string[] args)
        {
            //Single delegate
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello) ;
            del("Hello from Delegate");

            //Multicast delegate
            CustomDel hiDel, byeDel, multiDel;

            hiDel = Hello;

            byeDel = Goodbye;

            multiDel = hiDel + byeDel;

            Console.WriteLine("Invoking hiDel:");
            hiDel("Jordan");
            Console.WriteLine("Invoking byeDel:");
            byeDel("Madrid");
            Console.WriteLine("Invoking multiDel:");
            multiDel("Jordan Madrid");

            //Log Errors!
            Exception ex = new Exception();
            LogException("test", "TestLog", ex.ToString());

        }    
        
          public static void LogException(string strFileName, string strFunctionName, string strContent)
        {
            StreamWriter writer = null;
            StringBuilder strBuilder = null;
            string dir = "C:\\Users\\jrdnm\\DevelopmentProjects\\VisualStudioProjects\\All C Sharp Drills\\SevenTwelveThirteen\\LogError";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string path = Path.Combine(dir, strFileName + ".log");
            strBuilder = new StringBuilder("Log : ");
            strBuilder.Append(strFunctionName + " | ");
            strBuilder.Append(strContent);

            writer = new StreamWriter(path, true);
            writer.Write(strBuilder);
            writer.Close();

        }
    }
}
