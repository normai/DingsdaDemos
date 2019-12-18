/*
 * This project shall demonstrate subtleties of the IEnumerable interface
 * [file 20191218°0221][project 20191218°0211]
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumablDings
{
   /// <summary>
   /// This class provides the UI for the IEnumalbDings project
   /// </summary>
   /// <remarks>[class 20191218°0223]</remarks>
   class Program
   {
      /// <summary>
      /// This method constitutes the program entry pointfor the IEnumalbDings project
      /// </summary>
      /// <remarks>[method 20191218°0231]</remarks>
      static void Main(string[] args)
      {
         // start [seq 20191218°0233]
         Console.WriteLine("*** Welcome to IEnumablDings ***");

         // work [seq 20191218°0235]
         IEnumablDemo.Go();

         // finish [seq 20191218°0237]
         Console.WriteLine("*** Bye. Press anykey to exit .. ***");
         Console.ReadKey();
         System.Threading.Thread.Sleep(6);
      }
   }
}
