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
    public class Class : cs2307061154_ЦветнойБлок.Class, IClass
    {
        static new public string INFO = "INFO";
        #region КОД
        private byte _code; 
        public byte КОД { get => _code; set => _code = value; }
        #endregion
        public Color32 c;
        public Class(byte КОД, cs2307081134_Координата3.Class v, Color32 c) : base(v, c)
        {
            this.КОД = КОД;
        }
        public Class(byte КОД,Vector3 v) : base(v)
        {
            this.КОД = КОД;
        }
        public Class(byte КОД, cs2307081134_Координата3.Class v) : base(v)
        {
            this.КОД = КОД;
        }
    }
}
