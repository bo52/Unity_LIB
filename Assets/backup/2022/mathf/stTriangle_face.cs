using System.Collections.Generic;
using UnityEngine;
using System.Linq;
//Face_16112020105642929.STRUCT
namespace utility2022
{
    using mathf2022;
    /// <summary>
    /// ��� x,y,z �������
    /// ���������� c������ �� �������
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
            public byte �������
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
        static public List<STRUCT> ����������(Vector3 v) => (from s in new List<STRUCT> { new STRUCT(v.x, 0), new STRUCT(v.y, 1), new STRUCT(v.z, 2) } orderby Mathf.Abs(s.val) descending select s).ToList();
        static public bool ���������������(List<STRUCT> l, out byte �������)
        {
            ������� = l[0].�������;
            if (l[0].i != 1)
                return false;

            if (Mathf.Abs(l[1].val) < 0.2f)
                return false;

            ������� = l[1].�������;
            return true;
        }
        static public byte �����������������(Vector3 normal)
        {
            var l = ����������(normal);
            byte �������;
            if (���������������(l, out �������))
                return �������;

            return �������;
        }
        static public byte ����������������������������(Vector3 A, Vector3 B, Vector3 C) => �����������������(stMathf_normal.�������������������(A, B, C));
    }
}