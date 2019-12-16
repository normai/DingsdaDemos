/*
 * [file 20191212°0511]
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdingsda
{
   /// <summary>
   /// This class constitues a boat, it can swimm
   /// </summary>
   /// <remarks>[class 20191212°0513]</remarks>
   class Boat : Vehicle, ISwimmable
   {
      /// <summary>
      /// This constructor's sole purpose is to put the new boat vehicle automatically on the Swimmables list.
      /// </summary>
      /// <remarks>[class 20191212°0515]</remarks>
      public Boat()
      {
         Utils.swimmables.Add(this);
      }

      /// <summary>
      /// This method needs to exist by the base classes abstract Park() method.
      /// </summary>
      /// <remarks>[method 20191212°0521]</remarks>
      public override void Park()
      {
         string s = this.Me + " go to garage or boathouse.";
         Console.WriteLine(s);
      }

      /// <summary>
      /// This method needs to exist due to the iSwimmable interface.
      /// </summary>
      /// <remarks>[method 20191212°0521]</remarks>
      public void Swimm()
      {
         string s = " - " + this.Me + " turns the ship's propeller.";
         Console.WriteLine(s);
      }
   }
}
