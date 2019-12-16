/*
 * [file 20191212°0111]
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
         Dingsda.flyables.Add(this);
      }

      /// <summary>
      /// This method needs to exist due to the base classes abstract Park() method.
      /// </summary>
      /// <remarks>[method 20191212°0121]</remarks>
      public override void Park()
      {
         string s = this.Me + " go to the hangar.";
         Console.WriteLine(s);
      }

      /// <summary>
      /// This method needs to exist due to the iFlyable interface.
      /// </summary>
      /// <remarks>[method 20191212°0131]</remarks>
      public void Fly()
      {
         string s = " - " + this.Me + " turns on the nozzles.";
         Console.WriteLine(s);
      }
   }
}
