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
    public interface IClass : cs2307061154_ЦветнойБлок.IClass
    {
        public byte КОД { get; set; }
    }
    /// <summary>
    /// БЛОК (цвет и код)
    /// </summary>
    public class Class: cs2307061154_ЦветнойБлок.Class, IClass
    {
        static new public string INFO = "INFO";
        private byte _code; public byte КОД { get => _code; set => _code = value; }
        public Color32 c;
        public Class(byte КОД, Color32 c):base(c)
        {
            this.КОД = КОД;
        }
        public Class(byte КОД) : base()
        {
            this.КОД = КОД;
        }
    }
}
