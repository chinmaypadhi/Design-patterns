using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_pattern
{
    //interface
public interface Icalculate
    {
         void Calculate(double num1, double num2);    
    }

    //implimented Class for devide
    public class Divide : Icalculate
    {
        public void Calculate(double num1, double num2)
        {
            Console.WriteLine("a/b is {0}",num1/num2);
        }
    }

    //implimented Class for Addition


    public class ADD : Icalculate
    {
        public void Calculate(double num1, double num2)
        {
            Console.WriteLine("a+b is {0}", num1 + num2);
        }
    }

    //implimented Class for substraction

    public class Substract : Icalculate
    {
        public void Calculate(double num1, double num2)
        {
            Console.WriteLine("a-b is {0}", num1 - num2);
        }
    }


    //Factory class

    public  class CalculateFactory
    {
        public Icalculate getCalculation(string Type)
        {
            Icalculate obj = null;
            if(Type.ToLower().Equals("add"))
            {
                obj = new ADD();
            }
           else if (Type.ToLower().Equals("substract"))
            {
                obj = new Substract();
            }
            else if (Type.ToLower().Equals("devide"))
            {
                obj = new Divide();
            }
            else
            {
                Console.WriteLine("We don't do that");
            }
            return obj;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entyer the first no");

            double num1 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("entyer the first no");

            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the calculation type");
            string str = Console.ReadLine();

            CalculateFactory obj = new CalculateFactory();
            Icalculate obj1= obj.getCalculation(str);
            obj1.Calculate(num1, num2);

            Console.Read();

        }
    }
}
