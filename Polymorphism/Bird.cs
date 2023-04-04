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
        /// returns string that contains Parent Bird voice
        /// </summary>
        /// <returns>string</returns>
        public virtual string Voice()
        {
            return "Parent : Turr Turr";
        }
    }

    class Duck : Bird
    {
        /// <summary>
        /// returns string that contains Child Bird voice
        /// </summary>
        /// <returns>string</returns>
        public override string Voice()
        {
            return "Child : Quack Quack";
        }

        public static void Main(string[] args)
        {
            
            Duck duck = new Duck();
            Console.WriteLine(duck.Voice()); 

            Bird myBird = new Bird();
            Console.WriteLine(myBird.Voice() ); 

            Bird bird = new Duck();
            Console.WriteLine(bird.Voice());
           
            
        }
    }
}
