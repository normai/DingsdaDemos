/**
 * file        : 20191212°1011
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
   /// This class constitues a dragon
   /// </summary>
   /// <remarks>class 20191212°1013</remarks>
   class Dragon : ICountable, IFlyable
   {
      /// <summary>
      /// This constructor's sole purpose is to put the new dragon automatically on the Flyables list
      /// </summary>
      /// <remarks>class 20191212°1015</remarks>
      public Dragon()
      {
         Utils.iIdCounter++;
         this.ID = Utils.iIdCounter;
         Utils.dings.Add(this);

         Utils.flyables.Add(this);

         Console.WriteLine("Create " + this.Me);
      }

      /// <summary>
      /// This property is wanted by the ICountable interface. Not that to make
      /// the property sensible, we also need to set it properly in the constructor
      /// </summary>
      /// <remarks>prop 20191216°1541</remarks>
      public int ID { get; set; }

      /// <summary>
      /// This property is wanted by the ICountable interface.
      /// </summary>
      /// <remarks>prop 20191216°1543 </remarks>
      public string Me
      {
         get
         {
            string s = this.GetType().Name + " " + this.ID;
            return s;
         }
      }

      /// <summary>
      /// This method needs to exist due to the iFlyable interface.
      /// </summary>
      /// <remarks>method 20191212°1021</remarks>
      public void Fly()
      {
         string s = " - " + this.Me + " swings it's wings. (Hashcode " + this.GetHashCode() + ")";
         Console.WriteLine(s);
      }
   }
}
