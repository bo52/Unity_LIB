//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307051939_КоординатныйЧанкЗемли
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
        static cs2307051626_ЗЕМЛЯ.IClass ВидимаяЧастьЗемли=>cs2307051626_ЗЕМЛЯ.IClass.ВидимаяЧастьЗемли;
        Vector3Int Координата { get; set; }
        int Высота { get; set; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : IClass
    {
        static public string INFO = "INFO";
        public int Высота { get => _v.y; set => _v.y = value; }
        private Vector3Int _v = Vector3Int.zero; public Vector3Int Координата { get => _v; set => _v = value; }
        public Class(Vector3Int v)
        {
            this._v = v;
        }
    }
}
