//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307071130_ВысотаПаралепипеда
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
        int Высота { get; set; }
        bool Показать(System.Action<Vector3> fun = null);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : IClass
    {
        static public string INFO = "INFO";
        private int _h = 1; public int Высота { get => _h; set => _h = value; }
        public bool Показать(System.Action<Vector3> fun = null) => st2305141354.Class.fun230514135400_slider_int(ref _h, "Высота", 1, cs2307061242_СловарныйЧанк.IClass.ГраничныйРазмерЧанка);
    }
}
