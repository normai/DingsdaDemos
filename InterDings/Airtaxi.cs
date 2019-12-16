/*
 * [file 20191212°0211]
 */

using System;

namespace Interdingsda
{
   /// <summary>
   /// This class constitues an airtaxe, it can wheel and fly
   /// </summary>
   /// <remarks>[class 20191212°0213]</remarks>
   class Airtaxi : Automobile, IFlyable
   {
      /// <summary>
      /// This constructor's sole purpose is to put the new airtaxi automatically on the Flyables list
      /// </summary>
      /// <remarks>[class 20191212°0215]</remarks>
      public Airtaxi()
      {
         Utils.flyables.Add(this);
      }

      /// <summary>
      /// This method needs to exist by the base classes abstract Park() method.
      /// </summary>
      /// <remarks>[method 20191212°0221]</remarks>
      public override void Park()
      {
         string s = base.Me + " go to garage or hangar.";
         Console.WriteLine(s);
      }

      /// <summary>
      /// This method needs to exist due to the iFlyable interface.
      /// </summary>
      /// <remarks>[method 20191212°0231]</remarks>
      public void Fly()
      {
         string s = " - " + this.Me + " rotates the rotors. (Hashcode " + this.GetHashCode() + ")";
         Console.WriteLine(s);
      }
   }
}
