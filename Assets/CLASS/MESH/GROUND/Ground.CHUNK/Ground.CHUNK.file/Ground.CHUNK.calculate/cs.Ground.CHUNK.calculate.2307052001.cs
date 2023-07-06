//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307052001_ВычисляемыйЧанкЗемли
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2307051939_КоординатныйЧанкЗемли.IClass
    {
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307051939_КоординатныйЧанкЗемли.Class, IClass
    {
        static new public string INFO = "INFO";
        public Class(Vector3Int v) : base(v)
        {
        }
    }
}
