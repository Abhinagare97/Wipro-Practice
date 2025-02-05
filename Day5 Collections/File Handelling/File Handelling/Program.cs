using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Handelling
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            // string filename = @"C:\Users\\ACER\\Desktop\\resumes\newfile.txt";
            //FileStream fs = new FileStream(filename, FileMode.Create );
            //byte[] b = Encoding.Default.GetBytes("Hello this is the data that is to be saved in the file");
            //fs.Write(b,0,b.Length);

            //Console.WriteLine("Added succesfully");

            //fs.Close();
            //


            //if (File.Exists(filename))
            //{
            //   String Data = File.ReadAllText(filename);
            //    Console.WriteLine(Data);
            //    String[] dataarray = File.ReadAllLines(filename);
            //    foreach(var line in dataarray)
            //    {
            //        Console.WriteLine(line);
            //    }

            //}

            ////Copy files from source to destination
            //string destinationname = @"C:\Users\ACER\\Desktop\\resumes\newfile1.txt";
            //File.Copy(filename, destinationname);
            //string lines = File.ReadAllText(destinationname);
            //Console.WriteLine(lines);
            ////deltes file
            //File.Delete(filename);

            //string newfile = @"C:\Users\\ACER\\Desktop\\resumes\a.log";

            //DirectoryInfo df = new DirectoryInfo(newfile);
            //df.Create();
            //Console.WriteLine(df.CreationTime);
            //Console.WriteLine(df.LastAccessTime);
            //Console.WriteLine("Directory created");

            //Console.WriteLine(df.GetFiles());


            //****************************************************8
            string logdirectory = @"C:\Users\\ACER\\Desktop\\resumes\\a.log";
            string logfile = Path.Combine(logdirectory, "userlog.txt");

            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            DateTime time = DateTime.Now;

            string logentry = $"Name:{name}, Time:{time}";

            File.AppendAllText(logfile, logentry);



        }
    }
}
