//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace LIB.st2305271031
{
    /// <summary>
    ///
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        static public Vector3 fun230521171704(this uint id)
        {
            //30+30+
            //uint z = (id / field230521171702);
            //uint y = ((id - field230521171702 * z) / field230521171701);
            //uint x = (id - field230521171701 * y - field230521171702 * z);
            //return new Vector3(x, y, z);
        }
        /// <summary>
        /// 
        /// </summary>
        static public byte ���������������� => (byte)Random.Range(1, 30);
        /// <summary>
        /// 
        /// </summary>
        static public byte ������������������������ => (byte)Random.Range(0, 14);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tex"></param>
        /// <param name="v"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        static public bool ������������������������(Texture2D tex, Vector2Int v, byte a) => tex.GetPixel(v.x, v.y).a * byte.MaxValue > a;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tex"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        static public Color32 �������������������������(Texture2D tex, Vector2Int v)
        {
            bool b;
            var a = tex.GetPixel(v.x, v.y).a * byte.MaxValue;
            Color32 c = new Color32(0, 0, 0, (byte)a);
            var cnt = 0;
            foreach (var dv in new Vector2Int[] { Vector2Int.left, Vector2Int.right, Vector2Int.down, Vector2Int.up })
            {
                b = ������������������������(tex, v + dv, c.a);
                if (!b) continue;
                c.r += (byte)(1 + ������������������������ + (cnt % 2 == 0 ? 0 : 15));
                c.g += ����������������;
                cnt++;
            }
            return c;
        }
        /// <summary>
        ///
        /// </summary>
        static public void fun230527103100_�������������������������(cs2307011306_�������������.IClass TexLab)
        {
            var R = cs2307011306_�������������.IClass.���������������;
            Vector2Int v;
            for (var z = -R; z <= R; z++)
                for (var x = -R; x <= R; x++)
                {
                    v = TexLab.��������������������������(x, z);
                    TexLab.��������.SetPixel(v.x, v.y, �������������������������(TexLab.��������, v));
                    //TexLab.��������������������.��������(v);
                }
        }
        ///exit
    }
}
