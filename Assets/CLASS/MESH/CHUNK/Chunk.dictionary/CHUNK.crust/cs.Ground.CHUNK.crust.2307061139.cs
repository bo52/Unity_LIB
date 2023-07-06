//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307061139_КораЧанка
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass: cs2307051313_Словарь_Ulong.IClass
    {
        void Добавить(Vector3 v, byte КОД);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307051313_Словарь_Ulong.Class<cs2307051205_ЦветнойКодБлока.Class>, IClass
    {
        static new public string INFO = "INFO";
        public void Добавить(Vector3 v, byte КОД)
        {
            var b = new cs2307051205_ЦветнойКодБлока.Class(КОД);
            this.Добавить(v, b);
        }
    }
}
