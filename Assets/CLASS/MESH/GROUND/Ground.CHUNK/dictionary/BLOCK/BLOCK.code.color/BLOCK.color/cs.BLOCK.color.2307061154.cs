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
        public Color32 Цвет { get; set; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : IClass
    {
        static public string INFO = "INFO";
        private Color32 _c = IClass.Green; public Color32 Цвет { get => _c; set => _c = value; }
        public Class()
        {

        }
        public Class(Color32 c)
        {
            this._c = c;
        }
    }
}
