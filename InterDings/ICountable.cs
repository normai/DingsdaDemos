/**
 * file        : 20191216°1511
 * summary     :
 * license     : The MIT License
 * authors     : Norbert C. Maier and contributors
 * copyright   : © 2019 - 2021 Norbert C. Maier and contributors
 * encoding    : UTF-8-with-BOM
 */

namespace Interdingsda
{
   /// <summary>
   /// This interface makes objects having an identifyer
   /// </summary>
   /// <remarks>interface 20191216°1513</remarks>
   interface ICountable
   {
      /// <summary>
      /// This property makes the class countable
      /// </summary>
      /// <remarks>method 20191216°1521</remarks>
      int ID { get; set; }

      /// <summary>
      /// This property provides an object description. This represents not any
      /// stored value, but is calculated at runtime. Another — possibly more elegant
      /// way — to achieve this functionality were to overwrite the ToString() method.
      /// </summary>
      /// <remarks>method 20191216°1521</remarks>
      string Me { get; }
   }
}
