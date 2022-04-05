using System;

namespace animals
{
    public class Teacher : Person, ITalkable
    {
        public int Age{get;set;}
        public Teacher(int age, string name) : base(name)
        {
            this.Age = age;
        }

        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }

        public string GetName()
        {
            return Name;
        }

        public string ToSTring()
        {
            return "Teacher";
        }
    }
}
