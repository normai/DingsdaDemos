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
   class Dragon : ICountable, IFlyable
   {
      /// <summary>
      /// This constructor's sole purpose is to put the new dragon automatically on the Flyables list
      /// </summary>
      /// <remarks>[class 20191212°1015]</remarks>
      public Dragon()
      {
         Utils.flyables.Add(this);
      }

      /// <summary>
      /// This property is wanted by the ICountable interface. Not that to make
      /// the property sensible, we also need to set it properly in the constructor
      /// </summary>
      /// <remarks>[prop 20191216°1541] </remarks>
      int ICountable.ID { get; set; }

      /// <summary>
      /// This property is wanted by the ICountable interface.
      /// </summary>
      /// <remarks>[prop 20191216°1543] </remarks>
      public string Me { get; set; }

      /// <summary>
      /// This method needs to exist due to the iFlyable interface.
      /// </summary>
      /// <remarks>[method 20191212°1021]</remarks>
      public void Fly()
      {
         string s = " - " + this.Me + " swings it's wings.";
         Console.WriteLine(s);
      }
   }
}
