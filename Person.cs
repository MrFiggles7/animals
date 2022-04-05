using System;

namespace animals
{
    public abstract class Person
    {
        public string Name {get;set;}

        public Person(string name){
            this.Name = name;
        }

        override
        public string ToString(){
            return "Person";
        }
    }
}
