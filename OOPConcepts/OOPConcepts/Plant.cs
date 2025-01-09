using System;

namespace OOPConcepts
{
    public abstract class Plant
    {
        protected string Name { get; set; }

        protected Plant(string name) 
        { 
            Name = name;
        }

        public abstract void Grow();

        public abstract void Photosynthesize();
    }
}
