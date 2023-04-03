using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Bird
    {
        /// <summary>
        /// Void typed Method Voice that only prints initial Bird voice.
        /// </summary>
        public void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }

    class Duck : Bird
    {
        /// <summary>
        /// Void typed Method Voice that only prints initial Duck voice.
        /// </summary>
        public void Voice()
        {
            Console.WriteLine("Quack Quack");
        }

        public static void Main(string[] args)
        {

            //Bird bird = new Bird();
            Duck duck = new Duck();

            Bird myBird = new Bird();

            //  Duck myDuck = new Bird();
            Bird bird = new Duck();
            bird.Voice();


            myBird.Voice();

            // myDuck.Voice();
            duck.Voice();
            //bird.Voice();
        }
    }
}
