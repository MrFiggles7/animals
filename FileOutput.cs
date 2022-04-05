using System;
using System.IO;

namespace animals
{
    public class FileOutput
    {
        private string FileName;
        private StreamWriter sw;


        public FileOutput(string fileName)
        {
            this.FileName = fileName;
            try
            {
                sw = new StreamWriter(FileName);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("File Open Error: " + FileName + " " + e);
            }
        }

        public void FileWrite(string line)
        {
            try
            {
                sw.WriteLine(line);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("File Open Error: " + FileName + " " + e);
            }
        }

        public void FileClose()
        {
                if (sw != null)
                {
                    try
                    {
                        sw.Close();
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.ToString());
                    }
                }

        }
    }
}
