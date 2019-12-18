/*
 * [file 20191212°0411]
 */

using System;

namespace Interdingsda
{
   /// <summary>
   /// This class constitues an automobile, it can wheel
   /// </summary>
   /// <remarks>[class 20191212°0413]</remarks>
   public class Automobile : Vehicle
   {
      /// <summary>
      /// This constructor creates an automobile
      /// </summary>
      /// <remarks>[method 20191212°0441]</remarks>
      public Automobile()
      {
         Utils.autos.Add(this);
      }

      /// <summary>
      /// This method needs to exist here because it is wanted by
      /// the base classes abstract Park() method
      /// </summary>
      /// <remarks>[method 20191212°0421]</remarks>
      public override void Park()
      {
         string s = base.Me + " go to the garage.";
         Console.WriteLine(s);
      }

      /// <summary>
      /// This method turns the wheels.
      /// </summary>
      /// <remarks>[method 20191212°0431]</remarks>
      public void Drive()
      {
         string s = this.Me + " turns the wheels.";
         Console.WriteLine(s);
      }
   }
}
