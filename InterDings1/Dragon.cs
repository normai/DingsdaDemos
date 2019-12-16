/*
 * [file 20191212°1011]
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdingsda
{
   /// <summary>
   /// This class constitues a dragon
   /// </summary>
   /// <remarks>[class 20191212°1013]</remarks>
   class Dragon : Dingsda, IFlyable
   {
      /// <summary>
      /// This constructor's sole purpose is to put the new dragon automatically on the Flyables list
      /// </summary>
      /// <remarks>[class 20191212°1015]</remarks>
      public Dragon()
      {
         Dingsda.flyables.Add(this);
      }

      /// <summary>
      /// This method needs to exist due to the iFlyable interface.
      /// </summary>
      /// <remarks>[method 20191212°1021]</remarks>
      public void Fly()
      {
         string s = " - " + this.Me + " swings it's wings. (Hashcode " + this.GetHashCode() + ")";
         Console.WriteLine(s);
      }
   }
}
