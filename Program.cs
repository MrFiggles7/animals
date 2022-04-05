using System;
using System.Collections.Generic;

namespace animals
{
    class Program
    {
        private static readonly FileOutput OutFile = new FileOutput("./animalsWrite.txt");
        private static readonly FileInput InFile = new FileInput("./animals.txt");
        static void Main(string[] args)
        {
            List<ITalkable> zoo = new List<ITalkable>();
            string[] ReferenceList = new string[2];
            ReferenceList[0] = "Dog";
            ReferenceList[1] = "Cat";
            UserInput input = new UserInput(ReferenceList);

            int parameters = input.GetChoice();
            ITalkable pet = input.GetThePet(parameters);

            zoo.Add(pet);
            

            foreach(ITalkable thing in zoo){
                PrintOut(thing);
            }

            OutFile.FileClose();
            InFile.FileRead();
            InFile.FileClose();

            FileInput InData = new FileInput("./animals.txt");
            string line;
            while((line = InData.FileReadLine()) != null){
                System.Console.WriteLine(line);
            }
        }

        public static void PrintOut(ITalkable p){
            Console.WriteLine(p.GetName() + " says=" + p.Talk());
            OutFile.FileWrite(p.GetName() + " | " + p.Talk());
        }
    }
}
