/**
 * file        : 20191218°0311
 * summary     : This class works off some IEnumerable demos
 * license     : The MIT License
 * authors     : Norbert C. Maier and contributors
 * copyright   : © 2019 - 2021 Norbert C. Maier and contributors
 * encoding    : UTF-8-with-BOM
 */

using System;
using System.Collections.Generic;
using Interdingsda;                                            // For Automobile

namespace IEnumablDings
{
   /// <summary>
   /// This static class holds the functionality of this project.
   /// </summary>
   /// <remarks>class 20191218°0313</remarks>
   public static class IEnumablDemo
   {
      /// <summary>
      /// This method performs the wanted demos ..
      /// </summary>
      /// <remarks>method 20191218°0321</remarks>
      public static void Go()
      {
         Console.WriteLine("Go ..");

         // Acquire an enumerator [seq ]
         Thingies t = new Thingies();
         IEnumerator<string> en1 = t.GetEnumerator();

         /*
         string s1 = en1.Current;
         en1.MoveNext();
         string s2 = en1.Current;
         en1.MoveNext();
         string s3 = en1.Current;
         en1.Reset();
         en1.Dispose();
         */

         /*
         Todo : What happens, if the Enumerator were empty, and would
           not yield any value even on the first use of en1.Current?
           How can such situation be handled? [todo 20191218°1231]
         */

         // Use an enumerator [seq ]
         Console.WriteLine("Using IEnumerator<string> en1 = t.GetEnumerator();");
         do
         {
            Console.WriteLine(" - " + en1.Current);
         }
         while (en1.MoveNext());

         // Try it with LINQ [seq ]
         /*
         IEnumerator<string> en2 = t.GetEnumerator();
         var x = from s in en2 select s;
         */
      }
   }
}
