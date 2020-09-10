using System;
namespace baseball
{
    public class Slider : IPitch
    {
        public void Pitch()
        {
            Console.WriteLine("an 88 mph slider was thrown");
        }
    }
}