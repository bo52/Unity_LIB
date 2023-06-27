using System.Collections.Generic;
using UnityEngine;
using System.Linq;
//Face_16112020105642929.STRUCT
namespace utility2022
{
    using mathf2022;
    /// <summary>
    /// ось x,y,z НОРМАЛИ
    /// определить cторону по нормали
    /// </summary>
    static public class stTriangle_face
    {
        public struct STRUCT
        {
            public byte i;
            public float val;
            public STRUCT(float val, byte i)
            {
                this.i = i;
                this.val = val;
            }
            public byte СТОРОНА
            {
                get
                {
                    var s = (byte)(2 * i);
                    if (val < 0) return s;
                    s++;
                    return s;
                }
            }
        }
        static public List<STRUCT> Возрастает(Vector3 v) => (from s in new List<STRUCT> { new STRUCT(v.x, 0), new STRUCT(v.y, 1), new STRUCT(v.z, 2) } orderby Mathf.Abs(s.val) descending select s).ToList();
        static public bool СторонаНеВысота(List<STRUCT> l, out byte сторона)
        {
            сторона = l[0].СТОРОНА;
            if (l[0].i != 1)
                return false;

            if (Mathf.Abs(l[1].val) < 0.2f)
                return false;

            сторона = l[1].СТОРОНА;
            return true;
        }
        static public byte ОпределитьСторону(Vector3 normal)
        {
            var l = Возрастает(normal);
            byte сторона;
            if (СторонаНеВысота(l, out сторона))
                return сторона;

            return сторона;
        }
        static public byte ОпределитьСторонуТругольника(Vector3 A, Vector3 B, Vector3 C) => ОпределитьСторону(stMathf_normal.НормальТриугольника(A, B, C));
    }
}