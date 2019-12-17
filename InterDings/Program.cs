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
         // intro [line 20191212°0823]
         Console.WriteLine("*** Welcome to InterDings v0.3.0x ***");

         // provide one object of each existing type [seq 20191212°0841]
         Airplane ap1 = new Airplane();
         Airtaxi at1 = new Airtaxi();
         Amphibious am1 = new Amphibious();
         new Automobile();
         new Boat();
         new Dragon();

         // keyboard menu [seq 20191217°1351]
         bool bContinue = true;
         while (bContinue)
         {
            // notify [seq 20191217°1352]
            Console.WriteLine();
            Console.WriteLine("*** Select: defaulT Albert Beatrix Caesar Doris Emili Fritz Gunda eXit ***");

            // read [seq 20191217°1353]
            ConsoleKeyInfo cki = Console.ReadKey(true);
            Console.WriteLine("You pressed \"" + cki.KeyChar + "\"");
            string sKey = cki.KeyChar.ToString().ToLower();

            // dispatch [seq 20191217°1354]
            switch (sKey)
            {
               case "a":
                  GoAlbert.Go();
                  break;
               case "b":
                  GoBeatrix.Go();
                  break;
               case "c":
                  GoCaesar.Go();
                  break;
               case "d":
                  GoDoris.Go();
                  break;
               case "e":
                  GoEmili.Go();
                  break;
               case "f":
                  GoFritz.Go();
                  break;
               case "g":
                  GoGunda.Go();
                  break;
               case "t":
                  Program.Go();
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

         // closing [seq 20191212°0825]
         Console.WriteLine("*** Bye. ***");
         System.Threading.Thread.Sleep(666);
      }

      /// <summary>
      /// This static method holds the functionality
      /// </summary>
      /// <remarks>[method 20191212°0831]</remarks>
      static void Go()
      {
         // output list of all thingies [seq 20191212°0842]
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

         // output list of all Automobiles [seq 20191212°0843]
         Console.Write("\n\nList of all Automobiles :");
         foreach (Automobile a in Utils.autos)
         {
            Console.Write(" " + a.Me + ";");
         }

         // fly all Flyables [seq 20191212°0844]
         Console.WriteLine("\n\nLet all Flyables fly :");
         foreach (IFlyable f in Utils.flyables)
         {
            f.Fly();
         }

         // swimm all Swimmables [seq 20191212°0845]
         Console.WriteLine("\nLet all Swimmables swimm :");
         foreach (ISwimmable s in Utils.swimmables)
         {
            s.Swimm();
         }

         // This sequence demonstrates polymorphy and the 'is' operator. [seq 20191212°0846]
         // For alternativ to 'is' e.g. [ref 20191212°1531]
         //   https://stackoverflow.com/questions/3561202/check-if-instance-is-of-a-type
         Console.WriteLine("\nList of all dings with type info :");
         foreach (Object d in Utils.dings)
         {
            ICountable ic = (ICountable) d;
            Console.Write(" - " + ic.Me.PadRight(12) + " :");

            // build string with all castable types [seq 20191212°0847]
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

         // [seq 20191212°0848]
         // Sidekick demo. Since the ternary operator is not a command but an
         // expression, you can use it at places where a if-condition were impossible.
         /*
         Boolean bDummy = true;
         Console.WriteLine("\nTeste {0} Syntax {1}.", (bDummy ? 11 : 22), 23);
         */

         // fly if it can [seq 20191212°0849]
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
   }
}
