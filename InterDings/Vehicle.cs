﻿/*
 * [file 20191212°0911]
 */

using System;

namespace Interdingsda
{
   /// <summary>
   /// This class serves as base class for all other vessels
   /// </summary>
   /// <remarks>[class 20191212°0913]</remarks>
   abstract class Vehicle : Dingsda
   {
      /// <summary>
      /// This field tells one basic property of all vehicles
      /// </summary>
      /// <remarks>[class 20191212°0921]</remarks>
      public double speed = 0.0; // km/h

      /// <summary>
      /// This abstract method has no code body. So each derrived class
      ///  must implement such method, quite like with an interface.
      /// </summary>
      /// <remarks>[class 20191212°0931]</remarks>
      abstract public void Park();

      /// <summary>
      /// This virtual method has a code body. So each derrived class
      ///  can either use this default action, or overwrite it with it's
      ///  own implementation.
      /// </summary>
      /// <remarks>[class 20191212°0941]</remarks>
      virtual public void Clean()
      {
         string s = this.GetType().Name + " : Putz, schrubb, wisch, ..";
         Console.WriteLine(" " + s);
      }
   }
}
