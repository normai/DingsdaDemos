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
      /// This property provides an object description. Another way to achieve
      /// this functionality were possibly to overwrite the ToString() method.
      /// </summary>
      /// <remarks>[imethod 20191216°1521]</remarks>
      string Me { get; set; }
   }
}
