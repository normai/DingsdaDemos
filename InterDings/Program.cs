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
         foreach (Object d in Utils.dings)
         {
            ////Console.Write(" " + d.Me + ";");
            ICountable ic = (ICountable) d; // in civilized paranoia, we would validate with 'is' operator before
            Console.Write(" " + ic.Me + ";");
         }

         Console.Write("\n\nList of all Automobiles :");
         //foreach (Automobile a in Automobile.autos) // why does this work as well?
         foreach (Automobile a in Utils.autos)
         {
            Console.Write(" " + a.Me + ";");
         }

         // Dingsda.flyables.

         Console.WriteLine("\n\nLet all Flyables fly :");
         foreach (IFlyable f in Utils.flyables)
         {
            Console.Write(" - " + f.GetHashCode());
            f.Fly();
         }

         Console.WriteLine("\nLet all Swimmables swimm :");
         foreach (ISwimmable s in Utils.swimmables)
         {
            s.Swimm();
         }

         // This sequence demonstrates polymorphy, is, ..
         // For alternatives and exact meanings see e.g. [ref 20191212°1531]
         // https://stackoverflow.com/questions/3561202/check-if-instance-is-of-a-type
         Console.WriteLine("\nList of all dings with type info :");
         foreach (Object d in Utils.dings)
         {
            ////Console.Write(" - " + d.Me.PadRight(12) + " :");
            ICountable ic = (ICountable) d;
            Console.Write(" - " + ic.Me.PadRight(12) + " :");

            // build string with all castable types
            string s = "";
            s = (ic is Airplane) ? s + " Airplane" : s;
            s = (ic is Airtaxi) ? s + " Airtaxi" : s;
            s = (ic is Amphibious) ? s + " Amphibious" : s;
            s = (ic is Automobile) ? s + " Automobile" : s;
            s = (ic is Boat) ? s + " Boat" : s;
            s = (ic is Object) ? s + " Object" : s; // formerly Dingsda
            s = (ic is Dragon) ? s + " Dragon" : s;
            s = (ic is IFlyable) ? s + " IFlyable" : s;
            s = (ic is ISwimmable) ? s + " ISwimmable" : s;
            s = (ic is Vehicle) ? s + " Vehicle" : s;
            Console.WriteLine(s);
         }

         // Sidekick demo. Since the ternary operator is not a command but an
         // expression, you can use it at places where a if-condition were impossible.
         Boolean bDummy = true;
         Console.WriteLine("\nTeste {0} Syntax {1}.", (bDummy ? 11 : 22), 23);

         Console.WriteLine("\nLoop over all Dings and fly them, but only if allowed");
         foreach (Object d in Utils.dings)
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
