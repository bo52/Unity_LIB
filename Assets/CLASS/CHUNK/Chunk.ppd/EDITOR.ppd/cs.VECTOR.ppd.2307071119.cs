//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307071119_ВекторПаралепипеда
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
        public static int R = cs2307061242_СловарныйЧанк.IClass.РазмерЧанка;
        public static int r = (int)(0.5f * R - 1);
        int Левая { get; set; }
        int Правая { get; set; }
        bool Показать(System.Action<Vector3> fun = null);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : IClass
    {
        static public string INFO = "INFO";
        private bool Развернуть = false;
        private Vector2 _v; 
        public int Левая { get => (int)_v.x; set => _v.x = value; }
        public int Правая { get => (int)_v.y; set => _v.y = value; }
        private string name_x = "x";
        private string name_z = "z";
        private int x_min = 0;
        private int z_min = 0;
        private int x_max = 100;
        private int z_max = 100;
        private string header = "Вектор";
        public Class(string header)
        {
            this.header = header;
            x_min = 0;
            name_x = "x=левая " + header;
            name_z = "z=правая " + header;
            z_min = 0;
            x_max = IClass.r;
            z_max = IClass.r;
        }
        public bool Показать(System.Action<Vector3> fun = null)
        {
            var b = false;
            var v = _v;
            st2305161246.Class.fun230516124600(() =>
            {
                var x = (int)v.x;
                var z = (int)v.y;
                GUILayout.BeginVertical();
                var X = st2305141354.Class.fun230514135400_slider_int(ref x, name_x, x_min, x_max);
                var Z = st2305141354.Class.fun230514135400_slider_int(ref z, name_z, z_min, z_max);
                GUILayout.EndVertical();
                if (X || Z)
                {
                    v = new Vector3(x, z);
                    b = true;
                    return;
                }
                b = false;
            }, header, ref Развернуть);
            if (b)
            {
                _v = v;
                fun?.Invoke(v);
            }
            return b;
        }
    }
}
