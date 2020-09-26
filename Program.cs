using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLand
{
    class Program
    {
        static void Main(string[] args)
        {
            // string myString = "My \"so-called\" life";
            // string myString = "What if we need \na new line?";
            // string myString = "Go to your c:\\ drive";
            // string myString = @"Go to your c:\ drive"; // This tells C# that we want to use the backslash not as a escape sequence
            // string myString = string.Format("{0} = {1}", "First", "Second");
            // string myString = string.Format("{0:C}", 123.45); // Diplay local currency with "C"
            // string myString = string.Format("{0:N}", 1234567890); // Fromating for a large number "N"
            // string myString = string.Format("Percentage: {0:P}", .12345);
            // string myString = string.Format("Phone number: {0:(###) ###-####}", 123467509534); // Be aware 
            // that the bracket will suffer if the input is too long
            // string myString = string.Format("Happy day, happy day, this is a happy day ");
            // myString = myString.Substring(6, 14);
            // myString = myString.ToUpper();
            // myString = myString.Replace(" ", "--");
            // myString = string.Format("Length before trim: {0}, and the length after trim: {1}", 
            //    myString.Length, myString.Trim().Length);
            
            /*
            string myString = "";
            for (int i = 0; i <= 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */
            //But the "Append" method is more efficient computationally
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i <= 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
