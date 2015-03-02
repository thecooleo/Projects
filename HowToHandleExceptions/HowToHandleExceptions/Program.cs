using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HowToHandleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                StreamReader myReader = new StreamReader("\\boo\\TextFile2.txt");
                string line = "";
                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }
                myReader.Close();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file are you sure the directory exist?");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Couldnt find the file. Are you sure you are looking for the right file?")

            }
            catch (Exception e)
            {
                Console.WriteLine("Something didn't quite work correctly: {0}",e.Message);
            }
            finally {
                //perform any cleanup to roll back the data or close connections
                //to files database network etc

            }

                Console.ReadLine();
            
            }
    }
}
