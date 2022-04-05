using System;
using System.Collections.Generic;

namespace animals
{
    public class UserInput
    {
        string[] Arr;
        public UserInput(string[] arr)
        {
            Arr = arr;
        }

        public int GetChoice()
        {
            System.Console.WriteLine("-----------------GOD SIM 2.0-----------------");
            System.Console.WriteLine("What type of animal would you like to create?");
            int i = 1;
            foreach (string line in Arr)
            {
                Console.WriteLine(i + ": " + line);
                i++;
            }

            int input = -1;
            while (input == -1)
            {
                input = GetPetNumber();
            }

            return input;
        }

        public int GetPetNumber()
        {
            int i;
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
                return i;
            }
            catch
            {
                return -1;
            }
            return -1;
        }

        public ITalkable GetThePet(int pet)
        {
            if (pet == 2)
            {
                System.Console.WriteLine("How many mice has this good boy/girl taken care of?");

                int mice = GetMice();
                while (mice == -1)
                {
                    mice = GetMice();
                }

                System.Console.WriteLine("What is this good boy/girl's name?");

                string name = Console.ReadLine();

                ITalkable cat = new Cat(mice, name);

                return cat;

            }
            else if (pet == 1)
            {
                System.Console.WriteLine("Is this a good boy/girl?(y/n)");

                bool isGoodBoi = GetGoodBoiStatus();

                System.Console.WriteLine("What is this good boy/girl's name?");
                string name = Console.ReadLine();

                ITalkable dog = new Dog(isGoodBoi, name);
                return dog;
            }
            else
            {
                throw new Exception();
            }
        }

        public int GetMice()
        {
            int mice;

            try
            {
                mice = Convert.ToInt32(Console.ReadLine());
                return mice;
            }
            catch
            {
                return -1;
            }
        }

        public bool GetGoodBoiStatus()
        {
            string response = "";
            bool isGoodBoi;

            response = Console.ReadLine();

            if (response == "y")
            {
                return true;
            }
            else if(response == "n"){
                return false;
            }
            else
            {
                System.Console.WriteLine("Excuse Me?");
                GetGoodBoiStatus();
                return false;
            }

        }
    }
}