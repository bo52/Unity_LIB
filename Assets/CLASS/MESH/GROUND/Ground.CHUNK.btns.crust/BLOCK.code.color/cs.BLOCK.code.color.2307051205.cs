//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307051205_ЦветнойКодБлока
{
    /// <summary>
    /// БЛОК (цвет и код)
    /// </summary>
    public struct Class
    {
        static public string INFO = "INFO";
        public byte КОД;
        public Color32 c;
        public Class(byte КОД, Color32 c)
        {
            this.КОД = КОД;
            this.c = c;
        }
    }
}
