
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

        //public static string fileName = "D:\\PersonalData\\BGlobal\\Translate\\Designer_es.json";
        //public static string fileName = "D:\\PersonalData\\BGlobal\\Translate\\Login_es.json";
        //public static string fileName = "D:\\PersonalData\\BGlobal\\Translate\\Registration_es.json";

        //public static string fileName = "D:\\PersonalData\\BGlobal\\Translate\\WithOutEncode\\Designer_es.json";
        //public static string fileName = "D:\\PersonalData\\BGlobal\\Translate\\WithOutEncode\\Login_es.json";
        //public static string fileName = "D:\\PersonalData\\BGlobal\\Translate\\WithOutEncode\\Registration_es.json";
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
