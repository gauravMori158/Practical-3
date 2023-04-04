using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Laptop
    {
        private string _brand;
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Brand { get { return _brand; } set { _brand = value; } }
        /// <summary>
        /// Public Laptop Detail Function that takes 0 argument and return 0 argument.
        ///It diasplays Brand and Model of laptop.
        /// </summary>

        public string LaptopDetail()
        {
            return $"Brand : {Brand}\nModel : {Model}";
        }
         /// <summary>
         /// Print MotherBoard Information
         /// </summary>
         /// <returns>string</returns>
        private string MotherBoardInfo()
        {
            return "Mother Board Information !";
        }

        public static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.Brand = "HP";
            laptop.Model = "HP Pavailion";

            Console.WriteLine(laptop.LaptopDetail());
            Console.WriteLine(laptop.MotherBoardInfo()); 
        }

    }
}
