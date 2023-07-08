//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307061154_ЦветнойБлок
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
        static Color32 Green = new Color32(211, 151, 0, 255);
        Color32 Цвет { get; set; }
        cs2307081134_Координата3.Class Координата { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : IClass
    {
        static public string INFO = "INFO";
        #region КООРДИНАТА
        private cs2307081134_Координата3.Class _v; 
        public cs2307081134_Координата3.Class Координата => _v;
        #endregion
        private Color32 _c = IClass.Green; public Color32 Цвет { get => _c; set => _c = value; }
        public Class(cs2307081134_Координата3.Class v)
        {
            _v = v;
        }
        public Class(Vector3 v)
        {
            _v = new cs2307081134_Координата3.Class(v);
        }
        public Class(cs2307081134_Координата3.Class v,Color32 c)
        {
            _v = v;
            this._c = c;
        }
    }
}
