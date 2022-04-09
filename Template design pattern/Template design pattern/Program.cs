using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_design_pattern
{

    public abstract class DataProcessor
    {
        public void ReadProcessAndSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }

        public abstract void ReadData();
        public abstract void ProcessData();
        public void SaveData()
        {
            Console.WriteLine("Save data to DB");
        }

    }

    public class ExcelFile:DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Read data from excel file");
        }
        public override void ProcessData()
        {
            Console.WriteLine("process data from excel file");
        }
    }

   public class TextFile:DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Reads data from Text File");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process data from text file");
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataProcessor obj = new ExcelFile();
            obj.ReadProcessAndSave();
            DataProcessor obj2 = new TextFile();
            obj2.ReadProcessAndSave();
            Console.Read();
        }
    }
}


