/*
 * file : 20191218°0411
 * summary : This class shall demonstrate the IEnumerable interface
 * ref : See e.g. MS Docs article 'IEnumerable<T> Interface' [ref 20191218°1212]
 *    https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1
 *    This article provides a big example code.
 * ref : See e.g. MS Docs article 'IEnumerator Interface' [ref 20191218°1212]
 *     https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.6.1
 * note : This code was started after fragments from ref 20191218°1212, then
 *       supplemented by the VS hint button to automatically rq   esolve problems.
 *       Those parts are that with the german comments, since it was a german VS.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumablDings
{
   /// <summary>
   /// This class catalogues a list of classes and it implements the IEnumerable interface.
   /// </summary>
   /// <remarks>[file 20191218°0413]</remarks>
   public class Thingies : IEnumerable<string>
   {
      /// <summary>
      /// This default constructor provides one Thingies object
      /// </summary>
      /// <remarks>[ctor 20191218°0421]</remarks>
      public Thingies()
      {
         Console.WriteLine("Create Thingies " + this.GetHashCode());
      }

      /// <summary>
      /// This method satisfies one interface requirement
      /// </summary>
      /// <remarks>[method 20191218°0431]</remarks>
      public IEnumerator<string> GetEnumerator()
      {
         IEnumerator<string> ieo = new ThingiesEnumerator();
         return ieo;
      }

      /// <summary>
      /// (This method was introduced by VS-Hint)
      /// </summary>
      /// <returns>[method 20191218°0433]</returns>
      IEnumerator IEnumerable.GetEnumerator()
      {
         throw new NotImplementedException();
      }
   }

   /// <summary>
   /// This class is wanted by the other class which implements IEnumerable<>.
   /// Note: Instead implementing IEnumerator<string>, we could also use keyword 'yield'
   /// </summary>
   /// <remarks>[class 20191218°0511]</remarks>
   public class ThingiesEnumerator : IEnumerator<string>
   {
      /// <summary>
      /// This field ...
      /// </summary>
      /// <returns>[field 20191218°0522]</returns>
      private int iCurrIndex = 0;

      /// <summary>
      /// This field ...
      /// </summary>
      /// <returns>[field 20191218°0524]</returns>
      private string[] aOutStrings = {"Hello", "Hallo", "Aloha", "Gruezi", "Hujambo" };

      // Implement the IEnumerator(T).Current publicly, but implement 
      // IEnumerator.Current, which is also required, privately.
      /// <summary>
      /// This method (was introduced by VS-Hint) ...
      /// </summary>
      /// <returns>[field 20191218°0526]</returns>
      public string Current
      {
         get
         {
            /*
            if (_sr == null || _current == null)
            {
               throw new InvalidOperationException();
            }
            return _current;
            */
            return aOutStrings[iCurrIndex];
         }
      }

      /// <summary>
      /// This property (was introduced by VS-Hint) ...
      /// </summary>
      /// <returns>[property 20191218°0528]</returns>
      ////object IEnumerator.Current => throw new NotImplementedException();
      object IEnumerator.Current => aOutStrings[iCurrIndex];

      /// <summary>
      /// This method ...
      /// </summary>
      /// <returns>[method 20191218°0532]</returns>
      public bool MoveNext()
      {
         ////throw new NotImplementedException();
         bool bRet = false; // pessimistic initialisation
         iCurrIndex++;
         if (iCurrIndex < aOutStrings.Length )
         {
            bRet = true;
         }
         return bRet;
      }

      /// <summary>
      /// This method (was introduced by VS-Hint) ...
      /// </summary>
      /// <returns>[field 20191218°0534]</returns>
      public void Reset()
      {
         ////throw new NotImplementedException();
         iCurrIndex = 0;
      }

      #region IDisposable Support

      /// <summary>
      /// This field (was introduced by VS-Hint) ...
      /// </summary>
      /// <returns>[field 20191218°0536]</returns>
      private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

      /// <summary>
      /// This method (was introduced by VS-Hint) ...
      /// </summary>
      /// <returns>[method 20191218°0538]</returns>
      protected virtual void Dispose(bool disposing)
      {
         if (!disposedValue)
         {
            if (disposing)
            {
               // TODO: verwalteten Zustand (verwaltete Objekte) entsorgen.
            }

            // TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte)
            //    freigeben und Finalizer weiter unten überschreiben.
            // TODO: große Felder auf Null setzen.

            disposedValue = true;
         }
      }

      // [todo 20191218°0542] (This todo was introduced by VS-Hint)
      // TODO: Finalizer nur überschreiben, wenn Dispose(bool disposing) weiter
      //        oben Code für die Freigabe nicht verwalteter Ressourcen enthält.
      /// <summary>
      /// This method (was introduced by VS-Hint) ...
      /// </summary>
      /// <returns>[method 20191218°0544]</returns>
      // ~ThingiesEnumerator() {
      //   // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode
      //   //    in Dispose(bool disposing) weiter oben ein.
      //   Dispose(false);
      // }

      // Dieser Code wird hinzugefügt, um das Dispose-Muster richtig zu implementieren.
      /// <summary>
      /// This method (was introduced by VS-Hint) ...
      /// </summary>
      /// <returns>[method 20191218°0546]</returns>
      public void Dispose()
      {
         // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode
         //   in Dispose(bool disposing) weiter oben ein.
         Dispose(true);
         // TODO: Auskommentierung der folgenden Zeile aufheben, wenn
         //        der Finalizer weiter oben überschrieben wird.
         // GC.SuppressFinalize(this);
      }
      #endregion
   }
}
