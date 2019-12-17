/*
 * [file 20191212°0311]
 */

using System;

namespace Interdingsda
{
   /// <summary>
   /// This class constitues an amphibious vehicle, it can wheel and swimm
   /// </summary>
   /// <remarks>[class 20191212°0313]</remarks>
   class Amphibious : Automobile, ISwimmable
   {
      /// <summary>
      /// This constructor's sole purpose is to put the new amphibious vehicle automatically on the Swimmables list.
      /// </summary>
      /// <remarks>[class 20191212°0315]</remarks>
      public Amphibious()
      {
         Utils.swimmables.Add(this);
      }

      /// <summary>
      /// This method needs to exist due to the iSwimmable interface.
      /// </summary>
      /// <remarks>[method 20191212°0321]</remarks>
      public void Swimm()
      {
         string s = " - " + base.Me + " turns the amphibian propeller.";
         Console.WriteLine(s);
      }
   }
}
