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
         Console.WriteLine("*** Welcome to InterDings v0.3.0 ***");

         Go();

         bool bContinue = true;
         while (bContinue)
         {
            Console.WriteLine();
            Console.WriteLine("*** Select: Albert Caesar Doris Fritz Gunda eXit ***");

            ConsoleKeyInfo cki = Console.ReadKey(true);
            Console.WriteLine("You pressed \"" + cki.KeyChar + "\"");
            string sKey = cki.KeyChar.ToString().ToLower();
            switch (sKey)
            {
               case "a":
                  Console.WriteLine("Nothing yet implemented.");
                  break;
               case "c":
                  Console.WriteLine("Nothing yet implemented.");
                  break;
               case "d":
                  GoDoris();
                  break;
               case "f":
                  Console.WriteLine("Nothing yet implemented.");
                  break;
               case "g":
                  Console.WriteLine("Nothing yet implemented.");
                  break;
               case "x":
                  bContinue = false;
                  break;
               default:
                  Console.WriteLine("Unknown key pressed.");
                  bContinue = false;
                  break;
            }
         }

         Console.WriteLine("*** Bye. ***");
         System.Threading.Thread.Sleep(666);
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
            string s = "FATAL;";                       // this should never show up
            if (d is ICountable) {                     // just our groomed paranoia
               ICountable ic = (ICountable)d;
               s = ic.Me + ";";
            }
            Console.Write(" " + s);
         }

         Console.Write("\n\nList of all Automobiles :");
         foreach (Automobile a in Utils.autos)
         {
            Console.Write(" " + a.Me + ";");
         }

         Console.WriteLine("\n\nLet all Flyables fly :");
         foreach (IFlyable f in Utils.flyables)
         {
            f.Fly();
         }

         Console.WriteLine("\nLet all Swimmables swimm :");
         foreach (ISwimmable s in Utils.swimmables)
         {
            s.Swimm();
         }

         // This sequence demonstrates polymorphy and the 'is' operator.
         // For alternativ to 'is' e.g. [ref 20191212°1531]
         //   https://stackoverflow.com/questions/3561202/check-if-instance-is-of-a-type
         Console.WriteLine("\nList of all dings with type info :");
         foreach (Object d in Utils.dings)
         {
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
         /*
         Boolean bDummy = true;
         Console.WriteLine("\nTeste {0} Syntax {1}.", (bDummy ? 11 : 22), 23);
         */

         Console.WriteLine("\nLoop over all Dings and fly them if possible");
         foreach (Object d in Utils.dings)
         {
            if (d is IFlyable)
            {
               IFlyable f1 = (IFlyable) d;   // old C style cast operator
               IFlyable f2 = d as IFlyable;  // new C# style cast operator
               f1.Fly();
            }
         }
      }

      /// <summary>
      /// This method executes menu item 'd'
      /// </summary>
      /// <remarks>[mehtod 20191217°1011</remarks>
      private static void GoDoris()
      {
         Console.WriteLine("This shall execute any Doris Demos (nothing implemented yet).");
      }
   }
}
