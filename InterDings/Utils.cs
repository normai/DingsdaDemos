/*
 * [file 20191212°1111]
 */

using System;
using System.Collections.Generic;

namespace Interdingsda
{
   /// <summary>
   /// This grandparent class only exists to provide the ability to get
   ///  all our various dings on one single common list.
   /// </summary>
   /// <remarks>[class 20191212°1113]</remarks>
   static class Utils
   {
      /// <summary>
      /// This field provides one list with all existing thingies
      /// </summary>
      /// <remarks>[field 20191212°1143]</remarks>
      public static List<Object> dings = new List<Object>();

      /// <summary>
      /// This static list holds all wheeling dings.
      /// This is accidentially defined in the Dingsda class,
      /// it would better fit into the Automobile class. But as a
      /// static field, it plays no matter in which class it is homed.
      /// </summary>
      /// <remarks>[field 20191212°0445]</remarks>
      public static List<Automobile> autos = new List<Automobile>();

      /// <summary>
      /// This static list holds all flying dings.
      /// </summary>
      /// <remarks>[field 20191212°0447]</remarks>
      public static List<IFlyable> flyables = new List<IFlyable>();

      /// <summary>
      /// This static list holds all swimming dings.
      /// </summary>
      /// <remarks>[field 20191212°0449]</remarks>
      public static List<ISwimmable> swimmables = new List<ISwimmable>();

      /// <summary>
      /// This field provides a counter to be used as Ding-ID
      /// </summary>
      /// <remarks>[field 20191212°1133]</remarks>
      public static int iIdCounter = 0;

   }
}
