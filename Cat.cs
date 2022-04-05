using System;

namespace animals
{
    public class Cat : Pet, ITalkable
    {
        public int MousesKilled {get;set;}
        public Cat(int mousesKilled, string name) : base(name)
        {
            this.MousesKilled = mousesKilled;
        }

        public void AddMouse()
        {
            MousesKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }

        override
        public string ToString() 
        {
        return "Cat: " + "name=" + Name + " mousesKilled=" + MousesKilled;
        }

        public string GetName()
        {
            return Name;
        }

        public string ToSTring()
        {
            return "Cat";
        }
    }
}
