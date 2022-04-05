using System;

namespace animals
{
    public class Dog : Pet, ITalkable
    {
        public bool Friendly{get;}
        public Dog(bool friendly, string name) : base(name)
        {
            this.Friendly = friendly;
        }

        public string Talk()
        {
            return "Bark";
        }

        override
        public string ToString()
        {
            return "Dog: " + "name=" + Name + " friendly=" + Friendly;
        }

        public string GetName()
        {
            return Name;
        }

        public string ToSTring()
        {
            return "Dog";
        }
    }
}
