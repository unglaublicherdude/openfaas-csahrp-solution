using System;
using System.Text;

namespace ToUpper
{
    internal static class Program
    {
        private static string getStdin() {
            var buffer = new StringBuilder();
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                buffer.AppendLine(s);
            }
            return buffer.ToString();
        }

        private static void Main(string[] args)
        {
            var buffer = getStdin();

            var responseValue = FunctionHandler.Handle(buffer);

            if(responseValue != null) {
                Console.Write(responseValue);
            }
        }
    }
}
