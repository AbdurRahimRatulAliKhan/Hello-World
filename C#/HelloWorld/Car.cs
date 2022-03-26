using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    /// <summary>
    /// 
    /// </summary>
    interface IfirstInterface 
    {
        /// <summary>
        /// 
        /// </summary>
         void animalSound1(); // interface method

    }

    interface IsecondInterface
    {
        /// <summary>
        /// 
        /// </summary>
        void animalSound2(); // interface method
    }
 
    class Pig : IfirstInterface, IsecondInterface
    {
        /// <summary>
        /// 
        /// </summary>
        public void animalSound1()
        {
            Console.WriteLine("The Pig says: wee wee.");
        }

        public void animalSound2()
        {
            Console.WriteLine("fhgjshdjhfjkhs  jhjksd");
        }
    }
}
