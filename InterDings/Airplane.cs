/**
 * file        : 20191212°0111
 * summary     :
 * license     : The MIT License
 * authors     : Norbert C. Maier and contributors
 * copyright   : © 2019 - 2021 Norbert C. Maier and contributors
 * encoding    : UTF-8-with-BOM
 */

using System;

namespace Interdingsda
{
   /// <summary>
   /// This class constitues an airplane, it can fly
   /// </summary>
   /// <remarks>[class 20191212°0113]</remarks>
   class Airplane : Vehicle, IFlyable
   {
      /// <summary>
      /// This constructor's sole purpose is to put the new airplane automatically on the Flyables list
      /// </summary>
      /// <remarks>[class 20191212°0115]</remarks>
      public Airplane()
      {
         Utils.flyables.Add(this);
      }

      /// <summary>
      /// This method needs to exist due to the base classes abstract Park() method.
      /// </summary>
      /// <remarks>[method 20191212°0121]</remarks>
      public override void Park()
      {
         string s = base.Me + " go to the hangar.";
         Console.WriteLine(s);
      }

      /// <summary>
      /// This method needs to exist due to the iFlyable interface.
      /// </summary>
      /// <remarks>[method 20191212°0131]</remarks>
      public void Fly()
      {
         string s = " - " + this.Me + " turns on the nozzles. (Hashcode " + this.GetHashCode() + ")";
         Console.WriteLine(s);
      }
   }
}
