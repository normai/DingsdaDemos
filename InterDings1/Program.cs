/*
 * [file 20191212°0811]
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdingsda
{
   /// <summary>
   /// This (static) class provides the basic program controls ..
   /// </summary>
   /// <remarks>[method 20191212°0813]</remarks>
   class Program
   {
      /// <summary>
      /// This static method provides the program entry point
      /// </summary>
      /// <remarks>[method 20191212°0821]</remarks>
      static void Main(string[] args)
      {
         Console.WriteLine("*** Welcome to InterDingsda v0.1.1 ***");

         Go();

         Console.WriteLine("*** Bye. ***");
         Console.ReadKey();
      }

      /// <summary>
      /// This static method holds the functionality
      /// </summary>
      /// <remarks>[method 20191212°0831]</remarks>
      static void Go()
      {
         Airplane ap1 = new Airplane();
         Airtaxi at1 = new Airtaxi();
         Amphibious am1 = new Amphibious();
         new Automobile();
         new Boat();
         new Dragon();

         Console.Write("\nList of all Dings :");
         foreach (Dingsda d in Dingsda.dings)
         {
            Console.Write(" " + d.Me + ";");
         }

         Console.Write("\n\nList of all Automobiles :");
         //foreach (Automobile a in Automobile.autos) // why does this work as well?
         foreach (Automobile a in Dingsda.autos)
         {
            Console.Write(" " + a.Me + ";");
         }

         // Dingsda.flyables.

         Console.WriteLine("\n\nLet all Flyables fly :");
         foreach (IFlyable f in Dingsda.flyables)
         {
            ///Console.Write(" - " + f.GetHashCode());
            f.Fly();
         }

         Console.WriteLine("\nLet all Swimmables swimm :");
         foreach (ISwimmable s in Dingsda.swimmables)
         {
            s.Swimm();
         }

         // This sequence demonstrates polymorphy, is, ..
         // For alternatives and exact meanings see e.g. [ref 20191212°1531]
         // https://stackoverflow.com/questions/3561202/check-if-instance-is-of-a-type
         Console.WriteLine("\nList of all dings with type info :");
         foreach (Dingsda d in Dingsda.dings)
         {
            Console.Write(" - " + d.Me.PadRight(12) + " :");

            // The original formulation of the multi-if sequence in the
            // first branch extremely bloated. In the else-branch you find it
            // replaced by a terse version using the ternary '?:' operator.
            if (false) // toggle to switch used code
            {
               if (d is Airplane)
               {
                  Console.Write(" Airplane");
               }
               if (d is Airtaxi)
               {
                  Console.Write(" Airtaxi");
               }
               if (d is Amphibious)
               {
                  Console.Write(" Amphibious");
               }
               if (d is Automobile)
               {
                  Console.Write(" Automobile");
               }
               if (d is Boat)
               {
                  Console.Write(" Boat");
               }
               if (d is Dingsda)
               {
                  Console.Write(" Dingsda");
               }
               if (d is Dragon)
               {
                  Console.Write(" Dragon");
               }
               if (d is IFlyable)
               {
                  Console.Write(" IFlyable");
               }
               if (d is ISwimmable)
               {
                  Console.Write(" ISwimmable");
               }
               if (d is Vehicle)
               {
                  Console.Write(" Vehicle");
               }
               Console.WriteLine();
            }
            else
            {
               string s = "";

               //s = (d is Airplane) ? s + " Airplane" : s;
               if (d is Airplane)
               {
                  s = s + " Airplane";
               }
               else
               {
                  s = s;
               }

               s = (d is Airtaxi) ? s + " Airtaxi" : s;
               s = (d is Amphibious) ? s + " Amphibious" : s;
               s = (d is Automobile) ? s + " Automobile" : s;
               s = (d is Boat) ? s + " Boat" : s;
               s = (d is Dingsda) ? s + " Dingsda" : s;
               s = (d is Dragon) ? s + " Dragon" : s;
               s = (d is IFlyable) ? s + " IFlyable" : s;
               s = (d is ISwimmable) ? s + " ISwimmable" : s;
               s = (d is Vehicle) ? s + " Vehicle" : s;
               Console.WriteLine(s);
            }
         }

         // One additional demo. Since the ternary operator is not a
         // command but an expression, you can use it at places where
         // a if-condition would not fit.
         Boolean bDummy = true;
         Console.WriteLine("\nTeste{0} Syntax{1}.", (bDummy ? 11 : 22), 23);

         Console.WriteLine("\nLoop over all Dings and fly them, but only if allowed");
         foreach (Dingsda d in Dingsda.dings)
         {
            if (d is IFlyable)
            {
               IFlyable f1 = (IFlyable)d;   // old style cast operator
               IFlyable f2 = d as IFlyable; // C# style cast operator
               f1.Fly();
               //f2.Fly();
            }
         }


         Console.Write("\n");
      }
   }
}
