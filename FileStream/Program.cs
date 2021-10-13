using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamExample
{
    /// <summary>
    /// File apprears in the project folder => bin => Debug
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //WriteFile();
            //ReadFile();

            bool b = true;

            while (b)
            {
                Console.WriteLine(" 0) Create file 1) read Data 2) write Data 3) Append Data");
                int res = Int32.Parse(Console.ReadLine());
                Console.WriteLine("File Name?");
                string tempFileName = Console.ReadLine();
                string fileName = tempFileName + ".txt";

                if(res == 0)
                {
                    CreateFile(fileName);
                }
                if (res == 1)
                {
                    ReadFile2(fileName);
                }
                if (res == 2)
                {
                    OverideAllData(fileName);
                }
                if (res == 3)
                {
                    AppendData(fileName);
                }

            }
            
        }

        public static void CreateFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.ReadWrite);
            Console.WriteLine("File Created.");
            fs.Close();
        }

        public static void ReadFile2(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Print content of file");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd(); //read all the text nd print

            //using a readline
            //string str = sr.ReadLine();
            //while(str != null)
            //{
            //    Console.WriteLine(str);
            //    str = sr.ReadLine();
            //}

            Console.WriteLine(str);
            sr.Close();
            fs.Close();

            Console.ReadLine();
        }

        public static void OverideAllData(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fs);

            Console.WriteLine("Enter text to write here");
            var str = Console.ReadLine();

            streamWriter.WriteLine(str);
            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();
        }

        public static void AppendData(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fs);

            Console.WriteLine("Enter text to write here");
            var str = Console.ReadLine();

            streamWriter.WriteLine(str);
            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();
        }
        public static void ReadFile()
        {
            FileStream fs = new FileStream("Sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Print content of file");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd(); //read all the text nd print

            //using a readline
            //string str = sr.ReadLine();
            //while(str != null)
            //{
            //    Console.WriteLine(str);
            //    str = sr.ReadLine();
            //}
         
            Console.WriteLine(str);
            sr.Close();
            fs.Close();

            Console.ReadLine();
        }

        public static void WriteFile()
        {
            FileStream fs = new FileStream("Sample.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fs);

            Console.WriteLine("Enter text to write here");
            var str = Console.ReadLine();

            streamWriter.WriteLine(str);
            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();


            #region write multiple lines
            //Console.WriteLine("enter first text");
            //var str1 = Console.ReadLine();
            //Console.WriteLine("enter second text");
            //var str2 = Console.ReadLine();

            //streamWriter.WriteLine(str1);
            //streamWriter.WriteLine(str2);

            //streamWriter.Flush();
            //streamWriter.Close();
            //fs.Close();

            #endregion

        }


    }
}
