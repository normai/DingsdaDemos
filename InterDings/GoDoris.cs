/**
 * file        : 20191217°1211
 * summary     : File for simple team collaboration
 * license     : The MIT License
 * authors     : Norbert C. Maier and contributors
 * copyright   : © 2019 - 2021 Norbert C. Maier and contributors
 * encoding    : UTF-8-with-BOM
 */

using System;
using System.Collections;                                      // For IEnumerable

namespace Interdingsda
{
   /// <summary>
   /// This class hosts Doris' demos
   /// </summary>
   /// <remarks>class 20191217°1213</remarks>
   class GoDoris
   {
      /// <summary>
      /// This method performs Doris' demo
      /// </summary>
      /// <remarks>class 20191217°1215</remarks>
      public static void Go()
      {
         // A very first shy experiment [seq 20191217°1311]
         Console.WriteLine();
         var x1 = new Automobile();
         Console.WriteLine("Doris hat ein neues Auto : " + x1.Me);

         // Loop over the existing things as IEnumerables [seq 20191217°1321]
         Console.WriteLine("\nFrom a list of Objects, we make a list of IEnumerables, and still get the specialized types :");
         IEnumerable ienumabl = Utils.dings;
         int iCount = 0;
         foreach (var x2 in ienumabl)
         {
            iCount++;
            Console.WriteLine(" - " + iCount + " " + x2.ToString().PadRight(24) + " type = " + x2.GetType().Name );
         }

         // Randomly create lots of thingies [seq 20191217°1331]
         Console.WriteLine("\nRandomly create lots of thingies :");
         var rand = new Random();
         for (int i1 = 0; i1 < 93; i1++)
         {
            int i2 = rand.Next(1, 8);
            switch (i2)
            {
               case 1: new Airplane(); break;
               case 2: new Airtaxi(); break;
               case 3: new Amphibious(); break;
               case 4: new Automobile(); break;
               case 5: new Boat(); break;
               case 6:
               case 7:
               case 8: new Dragon(); break;
               default: break;
            }
         }

      }
   }
}
