using System;

namespace animals
{
    public abstract class Pet
    {
        public string Name {get;}

        public Pet(string name){
            this.Name = name;
        }

        override
        public string ToString(){
            return "Pet";
        }
    }
}
