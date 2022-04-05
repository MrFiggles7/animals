using System;
using System.IO;

namespace animals
{
    public class FileInput
    {
        public string FileName { get; set; }
        private StreamReader sr;

        public FileInput(string fileName)
        {
            this.FileName = fileName;
            try
            {
                sr = new StreamReader(FileName);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void FileRead()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(FileName);
                foreach (string line in lines)
                {
                    System.Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("File Write Error: " + FileName + " " + e);
            }


        }

        public string FileReadLine()
        {
            try
            {

                string line = sr.ReadLine();
                return line;

            }
            catch (Exception e)
            {
                System.Console.WriteLine("File Write Error: " + FileName + " " + e);
                return null;
            }
        }

        public void FileClose()
        {

            if (sr != null)
            {
                try
                {
                    sr.Close();
                }
                catch (IOException e)
                {
                    System.Console.WriteLine(e.ToString());
                }
            }


        }
    }
}
