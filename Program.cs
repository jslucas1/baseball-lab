using System;

namespace baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            // temp pitch vars
            IPitch fastball = new Fastball();
            IPitch curve = new Curveball();
            IPitch slider = new Slider();

            //Create our pitcher
            Pitcher craftyLefty = new Lefty(){Name = "Krafty", Team = "Mets"};

            //Throw the curve (no need to set since it was the default for a lefty)
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a strike!");

            //Throw a fastball
            craftyLefty.SetPitchBehavior(fastball);
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a strike!");

            //Throw a slider
            craftyLefty.SetPitchBehavior(slider);
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a ball :(");

            //Throw a curve
            craftyLefty.SetPitchBehavior(curve);
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("Strike 3, batters out!!");
        }
    }
}
