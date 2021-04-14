using System;
using System.IO;
using System.IO.Compression;
namespace FolderZipper
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("== File Zipper ==");
            Console.WriteLine("Please enter the number of the option you would like to do : \n1. Zip a File\n2. Extract a zip file.");
            var Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("What is the start path?");
                    var start = Console.ReadLine();
                    var zip = Console.ReadLine();
                    try
                    {
                        ZipFile.CreateFromDirectory(start, zip);
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                case 2:
                    Console.WriteLine("What is the zip file you would like extracted?");
                    var extract = Console.ReadLine();
                    var Zip = Console.ReadLine();
                    try
                    {
                        ZipFile.ExtractToDirectory(Zip, extract);
                    }
                    catch (UnauthorizedAccessException _e)
                    {
                        Console.WriteLine(_e.ToString());
                    }
                    break;
            }
        }
    }
}