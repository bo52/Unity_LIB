//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307061149_БлокиЧанка
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2307051313_Словарь_Ulong.IClass
    {
        void Добавить(Vector3 v);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307051313_Словарь_Ulong.Class<cs2307061154_ЦветнойБлок.Class>, IClass
    {
        static new public string INFO = "INFO";

        public virtual void Добавить(Vector3 v)
        {
            var b = new cs2307061154_ЦветнойБлок.Class(v);
            base.Добавить3(b.Координата.id, b);
        }
    }
}
