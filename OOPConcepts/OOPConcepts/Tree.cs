using System;

namespace OOPConcepts
{
    public abstract class Tree : Plant
    {
        public abstract float Height { get; set; }

        protected Tree(string name, float height) : base(name)
        {
            Height = height;
        }

        public override void Grow()
        {
            Console.WriteLine($"The tree {Name} is growing");
        }

        public override void Photosynthesize()
        {
            Console.WriteLine($"The tree {Name} is photosynthesizing");
        }
    }
}
