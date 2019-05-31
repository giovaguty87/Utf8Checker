
using System;
using Unicode;
using System.IO;
using System.Text;


namespace ConsoleAppCheckEncoder
{
    class Program
    {
       //using (StreamReader sr = new StreamReader(txtName))
       //{
       //   sb.AppendLine(txtName.ToString());
       //   sb.AppendLine("= = = = = =");
       //   sb.Append(sr.ReadToEnd());
       //   sb.AppendLine();
       //   sb.AppendLine();
       //}
       //public static StringBuilder sb = new StringBuilder();

        public static Utf8Checker Checker = new Utf8Checker();

        /// <summary>
        /// Check encode in JSON file.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            foreach (string txtName in Directory.GetFiles(@"D:\\PersonalData\\BGlobal\\Translate", "*.json"))
            {
                var resp = Checker.Check(txtName.ToString());

                Console.WriteLine($"File : {Path.GetFileName(txtName)} with encode UTF-8 : {resp}");
            }
            
            Console.ReadLine();
        }
    }
}
