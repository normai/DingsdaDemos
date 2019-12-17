/*
 * [file 20191216°1511]
 */

namespace Interdingsda
{
   /// <summary>
   /// This interface makes objects having an identifyer
   /// </summary>
   /// <remarks>[interface 20191216°1513]</remarks>
   interface ICountable
   {
      /// <summary>
      /// This property makes the class countable
      /// </summary>
      /// <remarks>[imethod 20191216°1521]</remarks>
      int ID { get; set; }

      /// <summary>
      /// This property provides an object description. This represents not any
      /// stored value, but is calculated at runtime. Another — possibly more elegant
      /// way — to achieve this functionality were to overwrite the ToString() method.
      /// </summary>
      /// <remarks>[imethod 20191216°1521]</remarks>
      string Me { get; }
   }
}
