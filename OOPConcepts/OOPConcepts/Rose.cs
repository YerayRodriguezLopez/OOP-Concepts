using System;

namespace OOPConcepts
{
    public class Rose : Flower
    {
        public int NumThorns { get; set; }
        public Rose(string name, string color, int numThorns) : base(name, color)
        {
            NumThorns = numThorns;
        }

        public override void Grow()
        {
            Console.WriteLine($"The rose {Name} is growing beautifully.");
        }

        public override void Photosynthesize()
        {
            Console.WriteLine($"The rose {Name} is photosynthesizing");
        }
    }
}
