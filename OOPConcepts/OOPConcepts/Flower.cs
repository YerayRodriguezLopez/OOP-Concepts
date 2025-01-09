using System;

namespace OOPConcepts
{
    public class Flower : Plant
    {
        protected string Smell { get; set; }
        
        public Flower(string name, string smell) : base(name)
        {
            Smell = smell;
        }

        public override void Grow()
        {
            Console.WriteLine($"The flower {Name} is growing");
        }

        public override void Photosynthesize()
        {
            Console.WriteLine($"The flower {Name} is photosynthesizing");
        }
    }
}
