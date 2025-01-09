using System;

namespace OOPConcepts
{
    public static class Program
    {
        public static void Main()
        {
            Plant mySunflower = new Sunflower("Sunflower", "Yellow", 5);
            Plant myRose = new Rose("Orchid", "Purple", 8);

            mySunflower.Grow();
            myRose.Grow();
            if (mySunflower is IEdible edible)
            {
                edible.Eat();
            }
            if (myRose is IEdible edible2)
            {
                edible2.Eat();
            }
        }
    }
}
