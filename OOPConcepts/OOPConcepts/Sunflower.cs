using System;

namespace OOPConcepts
{
    public class Sunflower : Flower, IEdible
    {
        public int Seeds { get; set; }
        public Sunflower(string name, string color, int seeds) : base(name, color)
        {
            Seeds = seeds;
        }

        public void Eat()
        {
            Console.WriteLine($"You can eat the sunflower {Name}'s seeds.");
        }

        public override void Grow()
        {
            Console.WriteLine($"The sunflower {Name} is growing beautifully.");
        }

        public override void Photosynthesize()
        {
            Console.WriteLine($"The sunflower {Name} is photosynthesizing");
        }
    }

}
