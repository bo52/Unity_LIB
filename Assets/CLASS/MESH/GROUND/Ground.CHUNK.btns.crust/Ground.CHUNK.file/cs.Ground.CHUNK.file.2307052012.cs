//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307052012_ФайловыйЧанкЗемли
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass: cs2307052001_ВычисляемыйЧанкЗемли.IClass
    {
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307052001_ВычисляемыйЧанкЗемли.Class,IClass
    {
        static new public string INFO = "INFO";
        public Class(Vector3Int v) : base(v)
        {
        }
    }
}
