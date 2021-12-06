/**
 * file        : 20191218°0221
 * project     : 20191218°0211
 * summary     : This project demonstrates subtleties of the IEnumerable interface
 * license     : The MIT License
 * authors     : Norbert C. Maier and contributors
 * copyright   : © 2019 - 2021 Norbert C. Maier and contributors
 * encoding    : UTF-8-with-BOM
 */

using System;

namespace IEnumablDings
{
   /// <summary>
   /// This class provides the UI for the IEnumalbDings project
   /// </summary>
   /// <remarks>class 20191218°0223</remarks>
   class Program
   {
      /// <summary>
      /// This method constitutes the program entry pointfor the IEnumalbDings project
      /// </summary>
      /// <remarks>method 20191218°0231</remarks>
      static void Main(string[] args)
      {
         // Start [seq 20191218°0233]
         Console.WriteLine("*** Welcome to IEnumablDings ***");

         // Work [seq 20191218°0235]
         IEnumablDemo.Go();

         // Finish [seq 20191218°0237]
         Console.WriteLine("*** Bye. Press anykey to exit .. ***");
         Console.ReadKey();
         System.Threading.Thread.Sleep(6);
      }
   }
}
